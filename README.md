<img src="https://github.com/UnamSanctam/SilentCryptoMiner/blob/master/SilentCryptoMiner.png?raw=true">

# SilentCryptoMiner v2.2.1 - Miner for ETH, ETC, XMR, RTM & more

A silent (hidden) cryptocurrency miner capable of mining ETH, ETC, XMR, RTM and much more, with many features suited for mining silently.

This miner can mine all the following algorithms and thus any cryptocurrency that uses one of them:
<details>
 <summary>List of algorithms</summary>
 <table>
	<tr><th>Algorithm</th><th>Example Cryptocurrency</th></tr>
	<tr><td>ethash</td><td>Ethereum, Metaverse, Callisto, QuarkChain, EtherGem, Etho, Expanse, Ellaism</td></tr>
	<tr><td>etchash</td><td>Ethereum Classic</td></tr>
	<tr><td>rx/0</td><td>Monero</td></tr>
	<tr><td>gr</td><td>Raptoreum</td></tr>
	<tr><td>argon2/chukwa</td><td>2ACoin</td></tr>
	<tr><td>rx/arq</td><td>ArQmA</td></tr>
	<tr><td>cn-heavy/xhv</td><td>Haven, Blockcloud</td></tr>
	<tr><td>cn/ccx</td><td>Conceal</td></tr>
	<tr><td>astrobwt</td><td>Dero</td></tr>
	<tr><td>cn/fast</td><td>Electronero, ElectroneroXP</td></tr>
	<tr><td>rx/keva</td><td>Kevacoin</td></tr>
	<tr><td>cn-pico</td><td>Kryptokrona</td></tr>
	<tr><td>cn/half</td><td>Masari</td></tr>
	<tr><td>argon2/ninja</td><td>NinjaCoin</td></tr>
	<tr><td>kawpow</td><td>Ravencoin</td></tr>
	<tr><td>rx/sfx</td><td>Safex</td></tr>
	<tr><td>cn/r</td><td>Sumokoin</td></tr>
	<tr><td>cn-pico/tlo</td><td>Talleo</td></tr>
	<tr><td>argon2/chukwav2</td><td>Turtlecoin</td></tr>
	<tr><td>cn/upx2</td><td>Uplexa</td></tr>
	<tr><td>rx/wow</td><td>Wownero</td></tr>
	<tr><td>cn/zls</td><td></td></tr>
	<tr><td>cn/double</td><td></td></tr>
	<tr><td>cn/2</td><td></td></tr>
	<tr><td>cn/xao</td><td></td></tr>
	<tr><td>cn/rwz</td><td></td></tr>
	<tr><td>cn/rto</td><td></td></tr>
	<tr><td>cn-heavy/tube</td><td></td></tr>
	<tr><td>cn-heavy/0</td><td></td></tr>
	<tr><td>cn/1</td><td></td></tr>
	<tr><td>cn-lite/1</td><td></td></tr>
	<tr><td>cn-lite/0</td><td></td></tr>
	<tr><td>cn/0</td><td></td></tr>
</table>
</details>

## Main Features

* Native & .NET - Miner installer/injector and watchdog coded in C#, Shellcode loader/injector coded in C, miner requires .NET Framework 4.5
* Shellcode - All .NET C# parts are converted into Shellcode and injected using a native C loader, can be disabled
* Injection (Silent/Hidden) - Hide miner behind another process like explorer.exe, conhost.exe, svchost.exe and others
* Idle Mining - Can be configured to mine at different CPU and GPU usages or not at all while computer is or isn't in use
* Stealth - Pauses the miner and clears the GPU memory while any of the programs in the "Stealth Targets" option are open
* Watchdog - Monitors the miner file and replaces the file if removed and starts it if the injected miner is closed down
* Multiple Miners - Can create multiple miners to run at the same time, for example one XMR (CPU) miner and one ETH (GPU) miner
* CPU & GPU Mining - Can mine on Both CPU and GPU (Nvidia & AMD)
* Bypass Windows Defender - Can add exclusions into Windows Defender to avoid being detected
* Process Killer - Constantly checks for any programs in the "Kill Targets" list and kills them if found
* Remote Configuration - Can get the miner settings remotely from a specified URL every 100 minutes
* Web Panel Support - Has support for monitoring and configuring all the miners efficiently in an online web panel

## Downloads

Pre-Compiled: https://github.com/UnamSanctam/SilentCryptoMiner/releases

## Wiki

You can find the wiki [here](https://github.com/UnamSanctam/SilentCryptoMiner/wiki) or at the top of the page. The wiki contains information about the miner and all of its features, it also has some answers to frequently asked questions.

## Web Panel

You can find the web panel that the miner officially supports here: [UnamWebPanel](https://github.com/UnamSanctam/UnamWebPanel). The web panel can be used to monitor your miners hashrate, status, connection settings and more. It can also be used to change the miner settings just like how the option "Remote Configuration" does it.

## Changelog

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
* Changed miner to be installed with the "System" user when run as administrator which means that it will now run when the computer is started with any user
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
* Removed Hide File option due to it restricting the file from being written to, thus enabling it to cause unwanted behaviour and bugs
* Fixed possible bug where the random encryption keys could be generated with illegal characters
* Fixed builder bug where it didn't clear the miner set for the Watchdog between builds
* Fixed Monero icon
### v2.0.0 (08/11/2021)
* Initial release

[You can view the full Changelog here](CHANGELOG.md)

## Author

* **Unam Sanctam**

## Disclaimer

I, the creator, am not responsible for any actions, and or damages, caused by this software.

You bear the full responsibility of your actions and acknowledge that this software was created for educational purposes only.

This software's main purpose is NOT to be used maliciously, or on any system that you do not own, or have the right to use.

By using this software, you automatically agree to the above.

## License

This project is licensed under the MIT License - see the [LICENSE](/LICENSE) file for details

## Donate

XMR: 8BbApiMBHsPVKkLEP4rVbST6CnSb3LW2gXygngCi5MGiBuwAFh6bFEzT3UTufiCehFK7fNvAjs5Tv6BKYa6w8hwaSjnsg2N

BTC: bc1q26uwkzv6rgsxqnlapkj908l68vl0j753r46wvq

ETH: 0x40E5bB6C61871776f062d296707Ab7B7aEfFe1Cd

ETC: 0xd513e80ECc106A1BA7Fa15F1C590Ef3c4cd16CF3

RVN: RFsUdiQJ31Zr1pKZmJ3fXqH6Gomtjd2cQe

LINK: 0x40E5bB6C61871776f062d296707Ab7B7aEfFe1Cd

DOGE: DNgFYHnZBVLw9FMdRYTQ7vD4X9w3AsWFRv

LTC: Lbr8RLB7wSaDSQtg8VEgfdqKoxqPq5Lkn3