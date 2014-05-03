using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassProject
{
    public partial class frmPersonalization : Form
    {
        private int[] OddsMapLow  = { 0, 0, 0, 1, 1, 1, 1, 1, 2, 2, 3, 3, 4 };
        private int[] OddsMapMid  = { 0, 0, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4 };
        private int[] OddsMapHigh = { 0, 1, 2, 2, 3, 3, 4, 4, 4, 4, 4 };
        private static string seed ="";
        private static int meshAmount = 1;

        public frmPersonalization()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmPersonalization_Load(sender, e);
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPersonalization_Load(object sender, EventArgs e)
        {
            txtLevels.Text = frmMapDisplay.Levels.ToString();
            txtSeed.Text = frmPersonalization.seed;
            cmbMeshLevel.SelectedIndex = frmPersonalization.meshAmount;
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            txtLevels.Text = frmMapDisplay.DefaultLevels.ToString();
            cmbMeshLevel.SelectedIndex = 1;
            txtSeed.Text = "";
        }

        private void frmPersonalization_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMapDisplay.Levels = int.Parse(txtLevels.Text);
            switch (cmbMeshLevel.SelectedIndex)
            {
                case 0:
                    frmMapDisplay.OddsMap = OddsMapLow;
                    break;
                case 1:
                    frmMapDisplay.OddsMap = OddsMapMid;
                    break;
                case 2:
                    frmMapDisplay.OddsMap = OddsMapHigh;
                    break;
            }
            frmMapDisplay.useSeed = true;
            if (txtSeed.Text == "")
            {
                frmMapDisplay.useSeed = false;
            }
            else
            {
                //try to convert txtSeed to an integer if it fails it will convert it in to its Hash Code Equivalent
                if (!int.TryParse(txtSeed.Text, out frmMapDisplay.SeedValue))
                {
                    frmMapDisplay.SeedValue = txtSeed.Text.GetHashCode();
                }
            }
            frmPersonalization.seed=txtSeed.Text;
            frmPersonalization.meshAmount=cmbMeshLevel.SelectedIndex;
        }

        private void txtLevels_TextChanged(object sender, EventArgs e)
        {
            int textValue=0;
            
            if(int.TryParse(txtLevels.Text, out textValue) & ( textValue <= 0 ||textValue >= 256))
            {
                btnSave.Enabled = false;
                errorProvider.SetError(txtLevels, "Not A Valid Number Between 1 and 256");
            }
            else
                btnSave.Enabled = true;
            
        }        
    }
}
