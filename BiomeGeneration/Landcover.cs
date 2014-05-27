/********************************************************************************************
 * 
 * Class:       Biome
 * Project:     Brave New World
 * Author:      Keith Emery
 * Date:        4/11/14
 * Description: Objects of the Biome class are instantiated with an array of points and an
 *              integer number of rounds of generation representing the maximum number of
 *              intervals over which contour levels will be added to the map.
 *              
 *              For each point, a 10 digit key is generated based on its latitude, altitude,
 *              slope, substrate and aspect (all determined by its location on the map and
 *              within a contour).
 *              
 *              The key is then used by the BiomeLookup class to assign a climate to the
 *              point. Eventually a specific biome can be assigned to the point based on 
 *              its physical characteristics and climate.
 *              
 * ******************************************************************************************/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows;

//using System.Convert;

namespace BiomeGeneration
{
    public class Biome
    {
        // Constants
        const int SCREEN_HEIGHT = 486;
        const int CONTOUR_INTERVAL = 320;  // 520
        const int MAX_CONTOUR = 17;
        int equator = SCREEN_HEIGHT / 2;

        // Physical attributes received from mesh generator
        private int m_roundsOfGeneration;
        private System.Drawing.Point[] m_locations;
        private string[] m_keys = { "class level" };
        private string[] m_climates;
        private string m_customKey = "";
        private global::System.Drawing.Point[] myPoints;
        private int levels;


        // build key from: latitude, altitude, slope, substrate, aspect
        // use key to get climate from array in BiomeLookup
        // constructor
        public Biome(System.Drawing.Point[] locations, int rounds)
        {
            string altitude = "";
            string aspect = "";
            string latitude = "";
            string slope = "";
            string substrate = "";

            // Substrate(int latitude, int altitude, int slope)
            m_locations = locations;
            m_roundsOfGeneration = rounds;
            m_keys = new string[m_locations.Length];

            // iterate through the points in the array and determine each characteristic for them
            for(int i = 0; i < m_locations.Length; i++)
            {
                altitude = Altitude(m_locations[i]);
                aspect = Aspect(i);
                latitude = Latitude(m_locations[i]);
                slope = Slope(m_locations[i]);
                substrate = Substrate(Convert.ToInt16(latitude), Convert.ToInt16(altitude), Convert.ToInt16(slope));

                // SetCustomKey concatenates the physical characteristics into a 10 digit string value
                SetCustomKey(latitude, altitude, slope, substrate, aspect);

                // The m_keys array contains the keys that correspond to all the points on the contour
                m_keys[i] = GetCustomKey();

            }
            // The m_climates array contains the climates that correspond to the keys
            m_climates = Climates(m_keys);
        }

  /*      public Biome(global::System.Drawing.Point[] myPoints, int levels)
        {
            // TODO: Complete member initialization
            this.myPoints = myPoints;
            this.levels = levels;
        } */

        // Climates instantiates a BiomeLookup object which receives the array of keys and returns the
        // corresponding climate values
        public string[] Climates(string[] keys)
        {
            string[] climates = new string[keys.Length];
            for (int i = 0; i < keys.Length; i++)
            {
                BiomeLookup pointClimate = new BiomeLookup();
                climates[i] = pointClimate.ClimateLookup(keys[i]);
            }
                return climates;
        }


        // Create the key from the codes for the physical characteristics
        private void SetCustomKey(string latitude, string altitude, string slope, string substrate, string aspect)
        {
            m_customKey = latitude + altitude + slope + substrate + aspect;
        }
        public string GetCustomKey()
        {
            return m_customKey;
        }


        // Public accessor methods
        public string[] GetClimate()
        {
            return m_climates;
        }



        public string[] GetKeys()
        {
            return m_keys;
        }



        // Altitude is the Maximum number of rounds of generation, minus the round in which 
        // the countour is generated. The altitude is the number of rounds remaining.
        public string Altitude(System.Drawing.Point p)
        {
            return  (MAX_CONTOUR - m_roundsOfGeneration).ToString("D2");
        }



        // Assign the 8 major directions of the compass rose to a an integer representation of aspect.
        // Although 16 points are used for contour generation, only 8 are used to obtain aspects.
        // An additonal value "central" is used for interior points.
        public string Aspect(int locationIndex)
        {
            string aspect;
            switch(locationIndex)
            {
                case 0:
                case 1:
                case 15:
                    aspect = "01"; // East
                    break;
                case 2:
                    aspect = "02"; // NE
                    break;
                case 3:
                case 4:
                case 5:
                    aspect = "03"; // N
                    break;
                case 6:
                    aspect = "04"; // NW
                    break;
                case 7:
                case 8:
                case 9:
                    aspect = "05"; // W
                    break;
                case 10:
                    aspect = "06"; // SW
                    break;
                case 11:
                case 12:
                case 13:
                    aspect = "07"; // S
                    break;
                case 14:
                    aspect = "08"; // SE
                    break;
                default:
                    aspect = "09"; // Central
                    break;
            }
            return aspect;
        }


        // Reversing non-zero latitude values (zero didn't change) for demonstration. Need to re-figure logic.
        // Latitude is based on a points location on the map. The y-coordinate is all that matters with respect
        // to latitude.
        public string Latitude(System.Drawing.Point p)
        {
            double y = p.Y;
            double calculatedLatitude;
            int latitude = 0;
            if (y < equator) // if our location is north of the equator
            {
                calculatedLatitude = (90 - (y * 180) / SCREEN_HEIGHT);
            }
            else            // if our location is south of the equator
            {
                calculatedLatitude = (((y * 180) / SCREEN_HEIGHT) - 90);
            }

            if(Math.Abs(calculatedLatitude) >= 67) // 67 represents the polar circles
                latitude = 1;
                // 37 to 66 degrees is the temperate zone
            else if((Math.Abs(calculatedLatitude) >= 37) && (Math.Abs(calculatedLatitude) <= 66))
                latitude = 2;
                // 23 to 36 degrees is the subtropical zone
            else if((Math.Abs(calculatedLatitude) >=23) && (Math.Abs(calculatedLatitude) <= 36))
                latitude = 3;
            else
                // latitudes below 23 degrees are tropical
                latitude = 4;
            return latitude.ToString("D2");
        }


        // Slope is the the difference between the current point and the previous point, becaus of the way points
        // are generated for the contours, each point represents and extension along the same line and represents
        // the magnitude of the difference--no subtraction is necessary. Slope will eventually be used
        // to model hydrology.
        public string Slope(System.Drawing.Point p)
        {
            string slope;
            double x = p.X;
            double y = p.Y;
            if (x == 0) // prevent divide by zero errors
                slope = "00";
            //throw new System.DivideByZeroException();
            else
            {
                // To simplify the process, slopes are classfied (in one of four gradients representing steep to shallow)
                if (y / x >= 10)
                    slope = "03";
                else if ((y / x < 10) && (y / x >= 5))
                    slope = "02";
                else if (y / x < 5)
                    slope = "01";
                else
                    slope = "00";
            }
                return (slope); // This should work because each point in our point array represents the change
                // from the prior point (in other words, the difference between point 1 and point 2.

        }


        // Substrate is the surface material (rock, soil, water, etc.) where the point resides. Substrate is
        // assigned based on on latitude, altitude and slope.
        public string Substrate(int latitude, int altitude, int slope)
        {
            int substrate = 0;
            // the random numbers are a punt as I could not easily pass an array of ints
            // they will require that I prepend a '0' before each returned int.
            Random r = new Random();
            
            // conditionals for tropical substrates
            if((latitude == 1 || (latitude == 2) || (latitude == 3)) && (altitude == 1 || altitude == 2) && (slope == 1 || slope ==2))
            {
                int randomSubstrate = r.Next(2, 4);
                substrate = randomSubstrate;
            }
            // conditionals for arid substrates
            else if((latitude == 0) && (altitude == 0) && (slope == 1 || (slope == 2)))
            {
                int randomSubstrate = r.Next(1, 2);
                substrate = randomSubstrate;
            }
            // conditionals for dry temperate substrates
            else if((latitude == 3) && (altitude == 1) && (slope == 1))
            {
                int randomSubstrate = r.Next(1,2);
                substrate = randomSubstrate;
            }
            // conditionals for humid temperate substrates
            else if((latitude == 3) && (altitude == 1) && (slope == 2))
            {
                int randomSubstrate = r.Next(1, 4);
                substrate = randomSubstrate;
            }
            // conditionals for cool temperate substrates
            else if((latitude == 3) && (altitude == 2 || altitude == 3) && (slope == 2))
            {
                int randomSubstrate = r.Next(1, 4);
                substrate = randomSubstrate;
            }
            // conditionals for alpine substrates
            else if((latitude == 0) && (altitude == 3) && (slope == 3))
            {
                int randomSubstrate = r.Next(1, 3);
                if (randomSubstrate == 2)
                    randomSubstrate = 4;
                substrate = randomSubstrate;
            }
            // conditional for polar substrates
            else if((latitude == 4) && (altitude == 1) && (slope == 0))
            {
                substrate = 0;
            }
            // default substrate is rock if all other conditions fail.
            else
            {
                substrate = 1;
            }
            return substrate.ToString("D2");
        }
    }
}
