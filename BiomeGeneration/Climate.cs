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

        public Climate(string key, string value)
        {
            M_key = key;
            M_climate = value;
        }
    }
}