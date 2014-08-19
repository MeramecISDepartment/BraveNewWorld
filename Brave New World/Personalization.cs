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

        // if the user choses Low, Med, High. the random number will be selected between these numbers.
        private int[] OddsMapLow  = { 0, 0, 0, 1, 1, 1, 1, 1, 2, 2, 3, 3, 4 };
        private int[] OddsMapMid  = { 0, 0, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4 };
        private int[] OddsMapHigh = { 0, 1, 2, 2, 3, 3, 4, 4, 4, 4, 4 };

        /// <summary>
        /// On Form Close will the form save.
        /// </summary>
        private bool saveOnClose = true;

        /// <summary>
        ///text value of the random seed. 
        /// </summary>
        private static string seed ="";

        /// <summary>
        /// number of levels on the map.
        /// </summary>
        private static int meshAmount = 1;

        public frmPersonalization()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            saveOnClose = false;
            this.Close();
        }

        /// <summary>
        /// Save Button
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// On Load
        /// </summary>
        private void frmPersonalization_Load(object sender, EventArgs e)
        {
            txtLevels.Text = frmMapDisplay.Levels.ToString();
            txtSeed.Text = frmPersonalization.seed;
            cmbMeshLevel.SelectedIndex = frmPersonalization.meshAmount;
        }
        /// <summary>
        /// Default Button Click
        /// </summary>
        private void btnDefault_Click(object sender, EventArgs e)
        {
            //Resets form to default settings.
            txtLevels.Text = frmMapDisplay.DefaultLevels.ToString();
            cmbMeshLevel.SelectedIndex = 1;
            txtSeed.Text = "";
        }

        /// <summary>
        /// On Form Close
        /// </summary>
        private void frmPersonalization_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (saveOnClose)
            {
                frmMapDisplay.Levels = int.Parse(txtLevels.Text);
                //set the odds map of the generated map equal to High, Medium, Low settings
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
                //sets the seed to being used if you
                
                if (txtSeed.Text != "")
                {
                    frmMapDisplay.useSeed = true;
                    //try to convert txtSeed to an integer if it fails it will convert it in to its Hash Code Equivalent
                    if (!int.TryParse(txtSeed.Text, out frmMapDisplay.SeedValue))
                    {
                        frmMapDisplay.SeedValue = txtSeed.Text.GetHashCode();
                    }
                }
                frmPersonalization.seed=txtSeed.Text;
                frmPersonalization.meshAmount=cmbMeshLevel.SelectedIndex;
            }
        }
        /// <summary>
        /// On Level Text Change
        /// </summary>
        private void txtLevels_TextChanged(object sender, EventArgs e)
        {
            int textValue=0;
            
            if(int.TryParse(txtLevels.Text, out textValue) & ( textValue <= 0 ||textValue > 256))
            {
                btnSave.Enabled = false;
                errorProvider.SetError(txtLevels, "Not A Valid Number Between 1 and 256");
            }
            else
                btnSave.Enabled = true;
            
        }

     
    }
}
