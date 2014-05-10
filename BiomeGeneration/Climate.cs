/********************************************************************************************
 * 
 * Class:       JBiome
 * Project:     Brave New World
 * Author:      Keith Emery
 * Date:        5/03/14
 * Description: A climate object consists simply of a key and a value. A list of key-value
 *              pairs is used to assign values to point within a contour
 *              
 * ******************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//
namespace BiomeGeneration
{
    class Climate
    {
        public string M_key { get; set; }
        public string M_climate {get; set; }

        // Climate objects comprise the list of potential climate values which can be assigned
        // to a point
        public Climate(string key, string value)
        {
            M_key = key;
            M_climate = value;
        }
    }
}