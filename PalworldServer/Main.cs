using Bunifu.UI.WinForms.Extensions;
using PalworldServer.Properties;
using System;
using System.Diagnostics;
using System.IO;
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

        // Button Handlers
        private void brnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.Minimize();
        }

        private bool GetServerStatus()
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

        private async void AfterLoader(Bunifu.UI.WinForms.BunifuLoader loading)
        {
            await Task.Delay(1000);

            // Checking if user has internet connection
            using (var client = new System.Net.WebClient())
            {
                try
                {
                    using (client.OpenRead("https://www.google.com/"))
                    {
                        // Internet is available
                    }
                }
                catch
                {
                    // Internet is not available
                    MessageBox.Show("You are not connected to the internet, please connect and try again", "No Internet Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }

            // Checking if DirectX is installed
            if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.System) + "/d3d11.dll"))
            {
                MessageBox.Show("DirectX is not installed (11 or later), please install it and try again", "DirectX Not Installed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            // Checking if Steam API is up
            string steamapiurl = "https://api.steampowered.com/ISteamApps/UpToDateCheck/v1/?appid=2394010&version=1";
            using (var client = new System.Net.WebClient())
            {
                try
                {
                    using (client.OpenRead(steamapiurl))
                    {
                        string response = client.DownloadString(steamapiurl);
                        if (!response.Contains("success\":true"))
                        {
                            MessageBox.Show("Steam API for Palworld is not available, please try again later", "Steam API Not Available", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch
                {
                    // Steam API is not available
                    MessageBox.Show("Steam API is not available, please try again later", "Steam API Not Available", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }

            // Checking if this app has write permissions
            try
            {
                File.WriteAllText("TestWrite.txt", "test");
                File.Delete("TestWrite.txt");
            }
            catch
            {
                MessageBox.Show("This app does not have write permission, please run it properly", "No Write Permission", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            // Check Github for updates by version.txt
            string versionurl = "https://raw.githubusercontent.com/LynxarA-Coding/Palworld-Server-Creator/master/version.txt";
            using (var client = new System.Net.WebClient())
            {
                try
                {
                    using (client.OpenRead(versionurl))
                    {
                        string response = client.DownloadString(versionurl);
                        // Response is in format: 1.0.0
                        // Check if version here is lower than current version
                        // If higher, the it is ok
                        string[] version = response.Split('.');
                        string[] appversion = Application.ProductVersion.Split('.');

                        if (Convert.ToInt32(version[0]) > Convert.ToInt32(appversion[0]) || Convert.ToInt32(version[1]) > Convert.ToInt32(appversion[1]) || Convert.ToInt32(version[2]) > Convert.ToInt32(appversion[2]))
                        {
                            MessageBox.Show("There is a new version of this app, please download it from Github", "New Version Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Exit();
                        }
                    }
                }
                catch
                {
                    // Github is not available
                    MessageBox.Show("Github is not available, please try again later", "Github Not Available", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Setting Current Fodler as Working Directory or Settings Folder
            string path = Settings.Default["ServerFolder"].ToString();
            if (path == "")
            {
                path = Directory.GetCurrentDirectory();
            }
            tbFolder.Text = path;

            // Checking if server exists
            if (GetServerStatus())
            {
                btnInstall.Text = "Update Server";
                btnInstall.Enabled = true;
                btnStart.Enabled = true;
                lblStatus.Text = "Server Status: Installed and Ready";
                lblStatus.ForeColor = System.Drawing.Color.DimGray;
            }
            else
            {
                btnInstall.Text = "Install Server";
                btnInstall.Enabled = true;
                btnStart.Enabled = false;
                lblStatus.Text = "Server Status: Not Installed";
                lblStatus.ForeColor = System.Drawing.Color.DimGray;
            }

            LogConsole("Ready");

            this.Controls.Remove(loading);
            pnlMain.Enabled = true;
            pnlMain.Visible = true;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Bunifu.UI.WinForms.BunifuLoader loading = new Bunifu.UI.WinForms.BunifuLoader();
            loading.Color = System.Drawing.Color.Black;
            loading.Thickness = 30;
            loading.Size = new System.Drawing.Size(200, 200);
            loading.Location = new System.Drawing.Point(this.Width / 2 - loading.Width / 2, this.Height / 2 - loading.Height / 2);
            this.Controls.Add(loading);
            AfterLoader(loading);
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
            lblStatus.ForeColor = System.Drawing.Color.FromArgb(20, 255, 20);
        }

        // Console logger for server installation output
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
            // Stop reading output on exit
            process.CancelOutputRead();

            if (btnInstall.Text != "Update Server")
            {
                // Copy Config
                string path = tbFolder.Text;
                string serverPath = path + "/PalworldServer";
                string configPath = serverPath + "/Pal/Saved/Config/WindowsServer";
                Directory.CreateDirectory(configPath);
                File.Copy(serverPath + "/DefaultPalWorldSettings.ini", configPath + "/PalWorldSettings.ini", true);
                LogConsole("Config Copied");

                // Open Config
                Process.Start(configPath + "/PalWorldSettings.ini");
                LogConsole("Server Installation Complete");
            }
            else
            {
                LogConsole("Server Update Complete");
            }

            // Last Check
            if (GetServerStatus())
            {
                UpdateUI(() =>
                {
                    btnInstall.Text = "Update Server";
                    btnInstall.Enabled = true;
                    btnStart.Enabled = true;
                    lblStatus.Text = "Server Status: Installed and Ready";
                    lblStatus.ForeColor = System.Drawing.Color.DimGray;
                });
            }
            else
            {
                UpdateUI(() =>
                {
                    btnInstall.Text = "Install Server";
                    btnInstall.Enabled = true;
                    btnStart.Enabled = false;
                    lblStatus.Text = "Server Status: Not Installed";
                    lblStatus.ForeColor = System.Drawing.Color.DimGray;
                });
            }
        }

        private void btnInstall_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to install/update the server? (It will NOT rewrite your save file)", "Install/Update Server", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            // Disabling Controls 
            btnInstall.Enabled = false;
            btnStart.Enabled = false;
            lblStatus.Text = "Server Status: Installing...";
            lblStatus.ForeColor = System.Drawing.Color.FromArgb(239, 214, 50);
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

            // Run SteamCMD + install Palworld Server
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

            btnStart.Enabled = GetServerStatus();

            if (btnInstall.Enabled)
            {
                btnInstall.Text = "Update Server";
                lblStatus.Text = "Server Status: Installed and Ready";
                lblStatus.ForeColor = System.Drawing.Color.DimGray;
            }
            else
            {
                btnInstall.Text = "Install Server";
                lblStatus.Text = "Server Status: Not Installed";
                lblStatus.ForeColor = System.Drawing.Color.DimGray;
            }

            // Save Settings (apply new folder)
            Settings.Default["ServerFolder"] = tbFolder.Text;
            Settings.Default.Save();
        }
    }
}
