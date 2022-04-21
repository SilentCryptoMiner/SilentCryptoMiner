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