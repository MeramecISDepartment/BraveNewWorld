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
 /*            System.Windows.Point[] points = {
               new System.Windows.Point(3, 5),
               new System.Windows.Point(200, 250),
               new System.Windows.Point(3, 5),
               new System.Windows.Point(200, 250),
               new System.Windows.Point(500, 30),
               new System.Windows.Point(20, 450),
               new System.Windows.Point(500, 30),
               new System.Windows.Point(20, 450)};    */   // keys of this last point

           System.Windows.Point[] points = {
               new System.Windows.Point(175, 200),
               new System.Windows.Point(50, 100),
               new System.Windows.Point(10, 300),
               new System.Windows.Point(100, 10),
               new System.Windows.Point(10, 100),
               new System.Windows.Point(100, 100),
               new System.Windows.Point(10, 10),
               new System.Windows.Point(10, 300)}; 

            Biome biome = new Biome(points, 16);

            //txt_keyOutput.SelectedText = biome.GetCustomKey();
            

                txt_keyOutput.SelectedText = biome.GetKeys()[0];
                txt_biome1.SelectedText = biome.GetKeys()[1];
                txt_biome2.SelectedText = biome.GetKeys()[2];
                txt_biome3.SelectedText = biome.GetKeys()[3];
                txt_biome4.SelectedText = biome.GetKeys()[4];
                txt_biome5.SelectedText = biome.GetKeys()[5];
                txt_biome6.SelectedText = biome.GetKeys()[6];
                txt_biome7.SelectedText = biome.GetKeys()[7]; 
  //          txt_test1.SelectedText = biome.FetchBiome(biome.m_climates[0]);

                txt_climate1.SelectedText = biome.GetClimate()[0];
                txt_climate2.SelectedText = biome.GetClimate()[1];
                txt_climate3.SelectedText = biome.GetClimate()[2];
                txt_climate4.SelectedText = biome.GetClimate()[3];
                txt_climate5.SelectedText = biome.GetClimate()[4];
                txt_climate6.SelectedText = biome.GetClimate()[5];
                txt_climate7.SelectedText = biome.GetClimate()[6];
                txt_climate8.SelectedText = biome.GetClimate()[7];
            }        
        


        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
