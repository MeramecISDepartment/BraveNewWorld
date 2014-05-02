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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void frmWelcome_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
             //opens up the graph form
            frmMapDisplay mapdisplay = new frmMapDisplay();
           mapdisplay.Show();

           


       
        }

        private void btnPerso_Click(object sender, EventArgs e)
        {

            Form Personalization = new frmPersonalization();

            Personalization.Show();


        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Form settings = new frmSettings();

            settings.Show();
        }

    }
}
