### 3.0.1 (07/09/2022)
* Fixed GPU checking when running as the System user
* Future-proofed some possible future detections
### 3.0.0 (07/09/2022)
* Rewrote entire miner and watchdog in C++ to replace the C# miner and watchdog
* Rewrote much of the builder for the rewritten miner and watchdog
* Added custom C++ compiler package
* Added custom compiled version of SysWhispers2 to randomize syscalls seed on every build
* Changed default injection target to conhost.exe
* Removed injection target "explorer.exe" due to new protections and inconvenience
* Added new injection target "dwm.exe"
* Removed now unnecessary options "Shellcode Loader", "In-memory watchdog" and "Do built-in obfuscations" because of the rewrite
* Removed now unnecessary DLL modules because of direct implementations
* Temporarily removed the "DEBUG" and "Overwrite old miners" options
* Updated both miners
* Added Spanish translation (Xeneht)
* Added Russian translation (BITIW)
### 2.6.1 (19/08/2022)
* Fixed mysterious reported ETH stratum disconnection
* Further improved ETH miner web panel status reporting from feedback
* Reduced minimum minor CUDA version for more driver compatibility
* Reduced ETH VRAM CUDA overhead slightly
* Reduced critical process protection delay
* Fixed missing builder admin shield images
### 2.6.0 (18/08/2022)
* Bypassed new Windows Defender exclusion detection and removal
* Added new improved process hollowing module ProcessInject which replaces the old process hollowing
* Added new "Critical Processes (BSoD)" option to mark the miners and watchdog as critical processes, thus causing a BSoD when killed
* Added new in-memory native DLL loader for the new modules, ProcessInject and ProcessProtect
* Greatly improved dynamic DAG/VRAM management, including better regeneration when enough VRAM becomes available to mine
* Changed startup flow to be more dynamic and persistent
* Improved the watchdogs persistence
* Greatly improved ETH miners web panel status reporting logic
* Improved ETH miners failover connection logic and default timing parameters
* Removed AstroBWT algorithms due to constant forking and instabilities
* Updated XMR miner
* Added Polish translation (Werlrlivx)
### 2.5.0 (06/07/2022)
* Added language localizer to allow translations of all controls through XML
* Added Swedish translation
* Changed "Save Path" to show "Program Files" for clarity when "Run as System" and "Run as Administrator" are both enabled
* Moved AMSI bypass from the RunPE module into the miner to bypass Assembly.Load detections
* Obfuscated all remaining strings inside all files
* Remade manifest to reduce detections
* Added new advanced option to disable built-in obfuscations
* Updated rootkit to reduce detections and improve compatibility and reliability
* Improved process hollowing implementation
### 2.4.1 (06/06/2022)
* Removed Panthera (Panthera) algorithm due to reported collateral issues
* Updated ETH miner CUDA and OpenCL implementations
* Added ETH miner OpenCL fallback for Nvidia cards if CUDA is unavailable
* Fixed connections to some ghostrider pools
* Fixed ETH first web panel configuration and first "Remote Configuration" pool switching
* Fixed Clover platform support
* Fixed non-intended administrator permission request during normal user first installation start
* Fixed brief powershell window popup on administrator installation startups with "Run as System" disabled
### 2.4.0 (29/05/2022)
* Added new Ubqhash (ubqhash) algorithm
* Added new CryptoNight-GPU (cn/gpu) algorithm
* Added new Panthera (panthera) algorithm
* Added new AstroBWT V2 (astrobwt/v2) algorithm
* Added new option "Stealth on Fullscreen" to pause the miner when Windows reports a fullscreen program to be open on the user running the miner
* Added executable name to the web panel "Active Window" reporting
* Added executable name reporting of the found "Stealth Targets" during "Stealth" to the web panel
* Added UTF8 encoding to GPU and CPU name web panel reporting
* Added C# shellcode injector for in-memory watchdog injection without an intermediary "Shellcode Loader"
* Changed Task Scheduler task creation from schtasks command to powershell to greatly increase customizability of the task
* Changed Task Scheduler task conditions and settings to the most optimal for the miner
* Changed Task Scheduler task to start at system startup instead of any user login when "Run as System" is enabled
* Fixed Task Scheduler task on some systems when install path contains spaces
* Replaced many commands with obfuscated powershell versions
* Reworked miner installation code and methods
* Reworked miner checking loops to ensure correct web panel status reporting and better performance
* Added support for reporting to the web panel when running at least two miners of the same miner type
* Improved watchdog miner restoration
* Updated the rootkit
### 2.3.2 (30/04/2022)
* Changed miner to install into Program Files if installed with "Run as System" enabled
* Changed miner to instead start from the Task Scheduler instead of CMD immediately after install if running as administrator
* Changed Icon preview to reload after loading a save
* Reworked "Remote Configuration" and web panel API calls for better performance, flexibility and less overhead
* Changed miner to immediately start reporting to the web panel on start
* Added new "Starting" miner status when first reporting to the web panel
* Added new miner version reporting to the web panel
* Added new currently active window reporting to the web panel
* Added new miner run time reporting to the web panel
* Inverted some advanced options for better clarity
### v2.3.1 (21/04/2022)
* Changed ETH miner to force desired CUDA settings, can increase hashrate on newer drivers/GPUs
* Changed ETH miner to not mine on integrated Intel GPUs, meaning CPUs with a GPU in them since they are not profitable and can cause lag
* Reworked manifest system to reduce overall detections
* Reduced C# detections greatly, especially helpful for those with "Shellcode Loader" disabled
* Changed "Entry Name" check to reallow backslashes for Task Scheduler subsections
* Improved "Disable Windows Update" function with better persistence and effectiveness
* Added advanced option to disable the miner from running after install so that it will only run on startup
### v2.3.0 (09/04/2022)
* Added option to disable Windows Update which stops updates from being found and installed
* Changed Watchdog to now run only in memory with no file dropped
* Added new Advanced Options form to make space for more options
* Added advanced option to use old Watchdog behaviour and start as a dropped file instead of only in memory
* Added advanced option to not overwrite old installed miners if desired
* Changed HTTP library to always follow redirects
* Decreased miner stealth and idle check loop timer for faster checks
* Moved process hollowing code back into DLL
* Added custom user level manifest
* Reduced some antivirus detections, mainly in C# code
* Cleaned up builder and miner code
* Fixed uninstaller
* Removed duplicate disable sleep command
* Updated miner
### v2.2.1 (05/04/2022)
* Added morphing to Windows Defender exclusion command to avoid static detection
* Added option to run/install the miner as System instead of always doing so by default
* Changed rootkit target program from nslookup.exe to dialer.exe and modified rootkit workflow
* Fixed XMR difficulty negotiation
* Fixed XMR worker name variable replacement
* Fixed XMR CUDA library locator for unicode characters
* Fixed missing builder events
### v2.2.0 (01/04/2022)
* Added custom system-wide idle detection that replaces the previous dedicated Windows API idle detection, this allows the miner to be run as "System"
* Changed miner to be installed with the "System" user when run as administrator, which means that it will now run when the computer is started with any user
* Added field to customize the entry name displayed in the startup registry and Task Scheduler
* Added option to automatically delete the original miner file after installation finishes
* Added option to disable sleep and hibernation on the computer
* Added option to block websites/domains from being able to be accessed by using the hosts file
* Fixed computer name and username convertions when containing non-ASCII characters
* Changed default library and installation locations to avoid path access restrictions by some programs
* Fixed XMR miner GPU CUDA libraries
* Fixed missing Watchdog Loader obfuscation step when using "Pause for Obfuscation"
* Improved GhostRider algorithm implementation
* Changed ETH miner idle sleeping 
* Fixed minor builder bugs
* Cleaned up form elements
* Added icon file error checking
* Updated compilers
* Updated miners
### v2.1.0 (09/01/2022)
* Added Ghost Rider algorithm, mainly used for the coin Raptoreum
* Added JSON generator inside builder for easier "Remote Configuration" and web panel configuration creation
* Added rootkit helper signatures to relevant files to ensure that files and processes are not hidden from the miner processes
* Added new "Out of free VRAM" status for the web panel if no GPU has enough current free VRAM to mine the selected coin
* Added "remote-config" and "api-endpoint" configuration options for the "Remote Configuration" and web panel configurations
* Changed save/load form serialization to also save checkbox and toggle text states
* Changed default "Startup" "Filename" due to certain anticheats blocking default "Startup" folder access
* Changed "Shellcode Loader" code and overall flow
* Improved rootkit stability and stealth
* Cleaned up messy and unclear form control names, breaks old save compatibility
### v2.0.1 (09/11/2021)
* Removed "Hide File" option due to it restricting the file from being written to, thus enabling it to cause unwanted behaviour and bugs
* Fixed possible bug where the random encryption keys could be generated with illegal characters
* Fixed builder bug where it didn't clear the miner set for the Watchdog between builds
* Fixed Monero icon
### v2.0.0 (08/11/2021)
* Initial release