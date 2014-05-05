using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows;
using BiomeGeneration;

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
            System.Windows.Point[] points = {
               new System.Windows.Point(3, 5),
               new System.Windows.Point(200, 250),
               new System.Windows.Point(3, 5),
               new System.Windows.Point(200, 250),
               new System.Windows.Point(500, 30),
               new System.Windows.Point(20, 450),
               new System.Windows.Point(500, 30),
               new System.Windows.Point(20, 450)};       // keys of this last point

  /*          System.Windows.Point[] points = {
               new System.Windows.Point(10, 300),
               new System.Windows.Point(10, 300),
               new System.Windows.Point(10, 300),
               new System.Windows.Point(10, 10),
               new System.Windows.Point(10, 10),
               new System.Windows.Point(10, 10),
               new System.Windows.Point(10, 10),
               new System.Windows.Point(10, 300)}; */

            Biome biome = new Biome(points, 16);

            //txt_keyOutput.SelectedText = biome.GetCustomKey();

            txt_keyOutput.SelectedText = biome.m_climates[0];
            txt_biome1.SelectedText = biome.m_climates[1];
            txt_biome2.SelectedText = biome.m_climates[2];
            txt_biome3.SelectedText = biome.m_climates[3];
            txt_biome4.SelectedText = biome.m_climates[4];
            txt_biome5.SelectedText = biome.m_climates[5];
            txt_biome6.SelectedText = biome.m_climates[6];
            txt_biome7.SelectedText = biome.m_climates[7];
  //          txt_test1.SelectedText = biome.FetchBiome(biome.m_climates[0]);
        
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
