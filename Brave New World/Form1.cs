using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Brave_New_World
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point[] points = {
               new Point(20, 50),
               new Point(60, 05),
               new Point(75, 40),
               new Point(10, 10),
               new Point(40, 45),
               new Point(10, 20),
               new Point(15, 30),
               new Point(200, 10)};

            Biome biome = new Biome(points, 16);

            txt_keyOutput.SelectedText = biome.GetCustomKey();
          

        }


    }
}
