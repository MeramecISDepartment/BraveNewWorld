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
 /*           Point[] points = {
               new Point(10, 300),
               new Point(60, 05),
               new Point(75, 40),
               new Point(10, 10),
               new Point(40, 45),
               new Point(10, 20),
               new Point(15, 30),
               new Point(200, 450)}; */      // keys of this last point

            Point[] points = {
               new Point(10, 300),
               new Point(10, 300),
               new Point(10, 300),
               new Point(10, 10),
               new Point(10, 10),
               new Point(10, 10),
               new Point(10, 10),
               new Point(10, 300)};

            Biome biome = new Biome(points, 16);

            //txt_keyOutput.SelectedText = biome.GetCustomKey();

            txt_keyOutput.SelectedText = biome.m_key[0];
            txt_biome1.SelectedText = biome.m_key[1];
            txt_biome2.SelectedText = biome.m_key[2];
            txt_biome3.SelectedText = biome.m_key[3];
            txt_biome4.SelectedText = biome.m_key[4];
            txt_biome5.SelectedText = biome.m_key[5];
            txt_biome6.SelectedText = biome.m_key[6];
            txt_biome7.SelectedText = biome.m_key[7];
        
        
        }


    }
}
