using Bunifu.UI.WinForms.Extensions;
using PalworldServer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalworldServer
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private bool CheckServerStatus()
        {
            // Checking if server exists
            string path = tbFolder.Text;

            if (Directory.Exists(path) && File.Exists(path + "/PalworldServer/PalServer.exe"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private async void StatusCheck (Process process)
        {
            // Checking if server is running
            await Task.Delay(1000);
            if (process.HasExited)
            {
                LogConsole("Server Stopped");
                btnStart.Enabled = true;
                btnInstall.Enabled = false;
                lblStatus.Text = "Server Status: Installed and Ready";
            }
            else
            {
                LogConsole("Server is Running");
                btnStart.Enabled = false;
                btnInstall.Enabled = false;
                lblStatus.Text = "Server Status: Running";
            }
        }

        private void brnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.Minimize();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // Setting Current Fodler as Working Directory or Settings Folder
            string path = Settings.Default["ServerFolder"].ToString();
            if (path == "")
            {
                path = Directory.GetCurrentDirectory();
            }
            tbFolder.Text = path;

            // Checking if server exists
            if (CheckServerStatus())
            {
                btnInstall.Enabled = false;
                btnStart.Enabled = true;
                lblStatus.Text = "Server Status: Installed and Ready";
            }
            else
            {
                btnInstall.Enabled = true;
                btnStart.Enabled = false;
                lblStatus.Text = "Server Status: Not Installed";
            }

            LogConsole("Ready");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Starting Server
            tbLogs.Clear();
            LogConsole("Starting Server...");
            string path = tbFolder.Text;
            string serverPath = path + "/PalworldServer";

            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = serverPath + "/PalServer.exe";
            startInfo.Arguments = "-log";
            startInfo.RedirectStandardOutput = true;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            process.StartInfo = startInfo;
            process.OutputDataReceived += (s, ev) => LogConsole(ev.Data);
            process.Start();

            LogConsole("Server Started");
            btnStart.Enabled = false;
            btnInstall.Enabled = false;
            lblStatus.Text = "Server Status: Running";
        }

        private async void LogConsole(string text)
        {
            if (tbLogs.InvokeRequired)
            {
                tbLogs.Invoke(new Action<string>(LogConsole), new object[] { text });
            }
            else
            {
                tbLogs.AppendText(text + Environment.NewLine);
            }
        }

        // Helper method to update UI controls safely
        private void UpdateUI(Action action)
        {
            if (InvokeRequired)
            {
                Invoke(action);
            }
            else
            {
                action.Invoke();
            }
        }

        private void ServerInstalled(Process process)
        {
            process.CancelOutputRead();
            LogConsole("Server Installation Complete");

            // Last Check
            if (CheckServerStatus())
            {
                UpdateUI(() =>
                {
                    btnInstall.Enabled = false;
                    btnStart.Enabled = true;
                    lblStatus.Text = "Server Status: Installed and Ready";
                });
            }
            else
            {
                UpdateUI(() =>
                {
                    btnInstall.Enabled = true;
                    btnStart.Enabled = false;
                    lblStatus.Text = "Server Status: Not Installed";
                });
            }

            // Copy Config
            string path = tbFolder.Text;
            string serverPath = path + "/PalworldServer";
            string configPath = serverPath + "/Pal/Saved/Config/WindowsServer";
            Directory.CreateDirectory(configPath);
            File.Copy(serverPath + "/DefaultPalWorldSettings.ini", configPath + "/PalWorldSettings.ini", true);
            LogConsole("Config Copied");

            // Open Config
            Process.Start(configPath + "/PalWorldSettings.ini");
        }

        private void btnInstall_Click(object sender, EventArgs e)
        {
            // Disabling Controls 
            btnInstall.Enabled = false;
            btnStart.Enabled = false;
            lblStatus.Text = "Server Status: Installing...";
            tbLogs.Clear();

            // Downloading SteamCMD (Latest)
            LogConsole("Downloading SteamCMD...");
            string path = tbFolder.Text;
            string steamcmdurl = "https://steamcdn-a.akamaihd.net/client/installer/steamcmd.zip";

            // Performing Download
            System.Net.WebClient wc = new System.Net.WebClient();
            wc.DownloadFile(steamcmdurl, path + "/steamcmd.zip");

            // Creating Folder for SteamCMD
            Directory.CreateDirectory(path + "/SteamCMD");
            LogConsole("Folder for SteamCMD Created");

            // Unpacking SteamCMD with progress
            LogConsole("Unpacking SteamCMD...");
            using (var zip = Ionic.Zip.ZipFile.Read(path + "/steamcmd.zip"))
            {
                zip.ExtractAll(path + "/SteamCMD", Ionic.Zip.ExtractExistingFileAction.OverwriteSilently);
            }

            // Deleting SteamCMD Zip
            LogConsole("Performing Cleanup...");
            File.Delete(path + "/steamcmd.zip");
            LogConsole("SteamCMD was Installed, running...");

            // Running SteamCMD with output into log
            Directory.CreateDirectory(path + "/PalworldServer");
            string steamPath = path + "/SteamCMD";
            string serverPath = path + "/PalworldServer";

            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = steamPath + "/steamcmd.exe";
            startInfo.Arguments = "+login anonymous +force_install_dir " + serverPath + " +app_update 2394010 validate +quit && exit";
            startInfo.RedirectStandardOutput = true;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            process.StartInfo = startInfo;
            process.OutputDataReceived += (s, ev) => LogConsole(ev.Data);
            process.EnableRaisingEvents = true;
            process.Start();
            process.BeginOutputReadLine();
            process.Exited += (s, ev) => ServerInstalled(process);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            // Selecting Folder or creating new one
            LogConsole("Selecting Folder...");
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select Palworld Server Folder";
            fbd.SelectedPath = tbFolder.Text;
            fbd.RootFolder = Environment.SpecialFolder.MyComputer;
            fbd.ShowNewFolderButton = true;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                tbFolder.Text = fbd.SelectedPath;
                LogConsole("Folder Selected: " + fbd.SelectedPath);
            }

            btnStart.Enabled = CheckServerStatus();
            btnInstall.Enabled = !CheckServerStatus();

            if (btnInstall.Enabled)
            {
                lblStatus.Text = "Server Status: Installed and Ready";
            }
            else
            {
                lblStatus.Text = "Server Status: Not Installed";
            }

            Settings.Default["ServerFolder"] = tbFolder.Text;
            Settings.Default.Save();
        }
    }
}
