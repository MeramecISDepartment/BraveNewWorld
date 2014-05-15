using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VectorLandMesh.Land
{
    public class Map
    {
        /// <summary>
        /// Multi Thread Support
        /// </summary>
        public static readonly object threadLocker = new object();
        /// <summary>
        /// The Random Seed of the map.
        /// </summary>
        private static Random seed = null;

        /// <summary>
        /// the bounding box of the map
        /// </summary>
        public static float[] Box { get; set; }

        /// <summary>
        /// The number of Vectors on each Contour
        /// </summary>
        public static int Detail { get; set; }
        public static void InitializeMap(int detail, float[] box)
        {
            Detail = detail;
            Box = box;
            seed= new Random();
        }
        public static void InitializeMap(int detail, float[] box, int seedValue)
        {
            InitializeMap(detail, box);
            seed = new Random(seedValue);
        }
        /// <summary>
        /// Initialize the Seed for generating random values
        /// </summary>
        public static void InitializeSeed()
        {
            //create a new seed.
            seed = new Random();
        }
        /// <summary>
        /// The Map seed used to generate new random values.
        /// </summary>
        public static Random MapSeed
        {
            get
            {
                return seed;
            }
        }



        
    }

}
