# Palworld Server Creator App
🎮 Welcome to the Palworld Server Creator! This repository provides a simple solution for managing your Palworld server.

![img](https://i.imgur.com/XHYB2em.png)

*Image is from 1.0.0, not updated due to the UI difference only in the Header (app name + version) text*

## 🚀 Quick Start 
- Download the latest release from the Releases page: [here](https://github.com/LynxarA-Coding/PalworldServerCreator/releases/latest)
- Run the executable (PalworldServer.exe).
- Choose the folder to your liking (it will create two folders inside, one for SteamCMD, one for the Server itself)
- Click "Install Server"
- Wait until it installs fully
- Edit the Config the program opens
- Start the Server

## It installs SteamCMD - What is it? 🛠️
SteamCMD is a command-line tool developed by Valve (those who made Steam) that allows users to install and update various apps, including game servers like Palworld. The Palworld Server Creator App utilizes SteamCMD under the hood to simplify the server setup process.

## 🔒 Security
Triage (malware sandbox) test showed the following results: [link](https://tria.ge/240201-k6bs4aagdq/behavioral1) <br>
The score is up because of my Update check from Github. Instead of checking release tags it checks the text in version.txt that is not the most optimal option. <br>
Why I didn't use the option that is not suspicious? The reason is simple. To check tags, Github API needs authentication with a key that I don't want to include in the repo (not secured key can be abused) **Main.cs Lines 107-134**  <br>
If someone has an idea how can I implement the version check safer without hosting my own API, please open an issue ticket or pull request

## 🛠️ Updates and Maintenance 
v1.0.0:
To update the Palworld server, you need to save the `Pal\Saved` folder
- Save the `Pal\Saved` folder outside the Server
- Delete full server folder, including SteamCMD
- Do the Quick Start actions again
- Put the `Pal\Saved` folder back into the newly created server

v1.1.0:
To update the Palworld server, you need to select the correct Root folder and click "Update Server"

## ❓Troubleshooting
For any issues or questions, check the Issues section.

## 🌟 Contributions
Contributions are welcome! Feel free to submit a pull request with your improvements.

## 🚨 Important Note 
Palworld Server App is NOT an official application or affiliated with Pocketpair. This tool is developed independently to enhance user experience in managing Palworld servers.

## 📝 License
This project is licensed under the Apache License Version 2.0 by January 2004
