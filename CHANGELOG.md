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