using System;
using System.Windows.Forms;

namespace SilentCryptoMiner
{
    public partial class Advanced
    {
        public Advanced()
        {
            InitializeComponent();
        }

        public Builder F;

        private void advanced_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string algo = "";
            try
            {
                algo = comboAlgorithm.Text.Split(new string[] { "(", ")" }, StringSplitOptions.None)[1].Split(' ')[0];
            }
            catch {}

            if (ReferenceEquals(algo, ""))
            {
                MessageBox.Show("Incorrect Algorithm");
                return;
            }

            Type minertype;

            switch (algo)
            {
                case "ethash":
                case "etchash":
                    minertype = typeof(MinerETH);
                    break;
                default:
                    minertype = typeof(MinerXMR);
                    break;
            }
            
            dynamic miner = Activator.CreateInstance(minertype);
            miner.comboAlgorithm.Text = algo;
            miner.nid = F.listMiners.Items.Count > 0 ? ((dynamic)F.listMiners.Items[F.listMiners.Items.Count-1]).nid + 1 : 0;
            miner.F = F;
            F.listMiners.Items.Add(miner);
            ((dynamic)F.listMiners.Items[F.listMiners.Items.Count-1]).Show();
            
            Hide();
        }
    }
}