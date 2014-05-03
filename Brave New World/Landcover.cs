/********************************************************************************************
 * 
 * Class:       Focus
 * Project:     Brave New World
 * Author:      Keith Emery
 * Date:        4/11/14
 * Description: The Focus class comprises an arraylist containing a focus (a point on the map)
 *              and all of the attendant contours (and the physical attributes) that make up 
 *              a feature on the map.
 *              
 * ******************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Net;
using Newtonsoft.Json;

//using System.Convert;

namespace Brave_New_World
{
    class Biome
    {
        // Constants
        const int SCREEN_HEIGHT = 486;
        int equator = SCREEN_HEIGHT / 2;
        const int CONTOUR_INTERVAL = 20;
        const int MAX_CONTOUR = 20;

        // Physical attributes received from mesh generator
        private int roundsOfGeneration;
        Point[] m_locations;
        public string[] m_key;
        string m_customKey = "";
        string path = "C:\\Users\\Keith\\Projects\\brave-new-world\\biome_data.json";
        string json = System.IO.File.ReadAllText(@"C:\Users\Keith\Projects\brave-new-world\biome_data.json");
  //      JsonTextReader reader = new JsonTextReader(new StringReader(json));
  //      JObject rss = JObject.Parse(json);

        private static T _download_serialized_json_data<T>(string path) where T : new()
        {
            using (var w = new WebClient())
            {
                var json_data = string.Empty;
                // attempt to download JSON data as a string
                try
                {
                    json_data = w.DownloadString(path);
                }
                catch (Exception) { }
                // if string with JSON data is not empty, deserialize it to class and return its instance 
                return !string.IsNullOrEmpty(json_data) ? JsonConvert.DeserializeObject<T>(json_data) : new T();
            }
        }


        // build key from: latitude, altitude, slope, substrate, aspect
        // use key to get climate from table
        // constructor
        public Biome(Point[] locations, int rounds)
        {
            string altitude = "";
            string aspect = "";
            string latitude = "";
            string slope = "";
            string substrate = "";

            // Substrate(int latitude, int altitude, int slope)
            System.IO.File.WriteAllText(@"C:\Users\Keith\Projects\WriteText.txt", json);
            m_locations = locations;
            roundsOfGeneration = rounds;

            string[] keys = new string[m_locations.Length];
                m_key = new string[m_locations.Length];

            for(int i = 0; i < m_locations.Length; i++)
            {
                altitude = Altitude(m_locations[i]);
                aspect = Aspect(i);
                latitude = Latitude(m_locations[i]);
                slope = Slope(m_locations[i]);
                substrate = Substrate(Convert.ToInt16(latitude), Convert.ToInt16(altitude), Convert.ToInt16(slope));


                SetCustomKey(latitude, altitude, slope, substrate, aspect);

         //       m_customKey = GetCustomKey();
         //       keys[i] = m_customKey;

                m_key[i] = GetCustomKey(); // keys[i];
            }

        }



        public string FetchBiome(string key)
        {
            string testString = "0104030101";
            if (key.Equals(testString, StringComparison.Ordinal))
            {
                var color = _download_serialized_json_data<Rainforest>(path);
                return color.ToString(); // "green";
            }
            else
                return "nothing to see here";
            
        }



        private void SetCustomKey(string latitude, string altitude, string slope, string substrate, string aspect)
        {
            m_customKey = latitude + altitude + slope + substrate + aspect;
        }
        public string GetCustomKey()
        {
            return m_customKey;
        }

        // member functions
 /*       public int RoundsOfGeneration
        {
            get { return roundsOfGeneration; }
            set
            {
                roundsOfGeneration = value;
            }
        } */



        // Altitude is the Maximum number of rounds of generation, minus the round in which 
        // the countour is generated. The altitude is the number of rounds remaining.
        public string Altitude(Point p)
        {
            return  (MAX_CONTOUR - roundsOfGeneration).ToString("D2");
        }



        // Assign the 16 directions of the compass rose to a an integer representation of aspect.
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



        public string Latitude(Point p)
        {
            int y = p.Y;
            int calculatedLatitude;
            int latitude = 0;
            if (y < equator) // if our location is north of the equator
            {
                calculatedLatitude = (90 - (y * 180) / SCREEN_HEIGHT);
            }
            else            // if our location is south of the equator
            {
                calculatedLatitude = (((y * 180) / SCREEN_HEIGHT) - 90);
            }
            if(Math.Abs(calculatedLatitude) >= 67)
                latitude = 4;
            else if((Math.Abs(calculatedLatitude) >= 37) && (Math.Abs(calculatedLatitude) <= 66))
                latitude = 3;
            else if((Math.Abs(calculatedLatitude) >=23) && (Math.Abs(calculatedLatitude) <= 36))
                latitude = 2;
            else
                latitude = 1;
            return latitude.ToString("D2");
        }


        
        public string Slope(Point p)
        {
            string slope;
            int x = p.X;
            int y = p.Y;
            if (x == 0)
                throw new System.DivideByZeroException();
            else
            {
                if (y / x >= 10)
                    slope = "03";
                else if ((y / x < 10) && (y / x >= 5))
                    slope = "02";
                else if (y / x < 5)
                    slope = "01";
                else
                    slope = "00";
            return (slope); // This should work because each point in our point array represents the change
                                // from the prior point (in other words, the difference between point 1 and point 2.
            }

        }

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
