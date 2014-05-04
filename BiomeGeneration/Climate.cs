﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiomeGeneration
{
    class Climate
    {
        public string key;
        public string climate;


        public static string ClimateLookup(string constructedKey)
        {
            List<Climate> climates = new List<Climate>
            {
                new Climate { key = "0101010209", climate = "tropical" },
                new Climate { key = "0101010201", climate = "tropical" },
                new Climate { key = "0101010203", climate = "tropical" },
                new Climate { key = "0101010204", climate = "tropical" },
                new Climate { key = "0101010205", climate = "tropical" },
                new Climate { key = "0101010207", climate = "tropical" },
                new Climate { key = "0101010309", climate = "tropical" },
                new Climate { key = "0101010301", climate = "tropical" },
                new Climate { key = "0101010303", climate = "tropical" },
                new Climate { key = "0101010304", climate = "tropical" },
                new Climate { key = "0101010305", climate = "tropical" },
                new Climate { key = "0101010307", climate = "tropical" },
                new Climate { key = "0101010409", climate = "tropical" },
                new Climate { key = "0101010401", climate = "tropical" },
                new Climate { key = "0101010403", climate = "tropical" },
                new Climate { key = "0101010404", climate = "tropical" },
                new Climate { key = "0101010405", climate = "tropical" },
                new Climate { key = "0101010407", climate = "tropical" },
                new Climate { key = "0101020209", climate = "tropical" },
                new Climate { key = "0101020201", climate = "tropical" },
                new Climate { key = "0101020203", climate = "tropical" },
                new Climate { key = "0101020204", climate = "tropical" },
                new Climate { key = "0101020205", climate = "tropical" },
                new Climate { key = "0101020207", climate = "tropical" },
                new Climate { key = "0101020309", climate = "tropical" },
                new Climate { key = "0101020301", climate = "tropical" },
                new Climate { key = "0101020303", climate = "tropical" },
                new Climate { key = "0101020304", climate = "tropical" },
                new Climate { key = "0101020305", climate = "tropical" },
                new Climate { key = "0101020307", climate = "tropical" },
                new Climate { key = "0101020409", climate = "tropical" },
                new Climate { key = "0101020401", climate = "tropical" },
                new Climate { key = "0101020403", climate = "tropical" },
                new Climate { key = "0101020404", climate = "tropical" },
                new Climate { key = "0101020405", climate = "tropical" },
                new Climate { key = "0101020407", climate = "tropical" },
                new Climate { key = "0201010205", climate = "tropical" },
                new Climate { key = "0201010207", climate = "tropical" },
                new Climate { key = "0201010309", climate = "tropical" },
                new Climate { key = "0201010301", climate = "tropical" },
                new Climate { key = "0201010303", climate = "tropical" },
                new Climate { key = "0201010304", climate = "tropical" },
                new Climate { key = "0201010305", climate = "tropical" },
                new Climate { key = "0201010307", climate = "tropical" },
                new Climate { key = "0201010409", climate = "tropical" },
                new Climate { key = "0201010401", climate = "tropical" },
                new Climate { key = "0201010403", climate = "tropical" },
                new Climate { key = "0201010404", climate = "tropical" },
                new Climate { key = "0201010405", climate = "tropical" },
                new Climate { key = "0201010407", climate = "tropical" },
                new Climate { key = "0201020209", climate = "tropical" },
                new Climate { key = "0201020201", climate = "tropical" },
                new Climate { key = "0201020203", climate = "tropical" },
                new Climate { key = "0201020204", climate = "tropical" },
                new Climate { key = "0201020205", climate = "tropical" },
                new Climate { key = "0201020207", climate = "tropical" },
                new Climate { key = "0201020309", climate = "tropical" },
                new Climate { key = "0201020301", climate = "tropical" },
                new Climate { key = "0201020303", climate = "tropical" },
                new Climate { key = "0201020304", climate = "tropical" },
                new Climate { key = "0201020305", climate = "tropical" },
                new Climate { key = "0201020307", climate = "tropical" },
                new Climate { key = "0201020409", climate = "tropical" },
                new Climate { key = "0201020401", climate = "tropical" },
                new Climate { key = "0201020403", climate = "tropical" },
                new Climate { key = "0201020404", climate = "tropical" },
                new Climate { key = "0201020405", climate = "tropical" },
                new Climate { key = "0201020407", climate = "tropical" },
                new Climate { key = "0102010209", climate = "tropical" },
                new Climate { key = "0102010201", climate = "tropical" },
                new Climate { key = "0102010203", climate = "tropical" },
                new Climate { key = "0102010204", climate = "tropical" },
                new Climate { key = "0102010205", climate = "tropical" },
                new Climate { key = "0102010207", climate = "tropical" },
                new Climate { key = "0102010309", climate = "tropical" },
                new Climate { key = "0102010301", climate = "tropical" },
                new Climate { key = "0102010303", climate = "tropical" },
                new Climate { key = "0102010304", climate = "tropical" },
                new Climate { key = "0102010305", climate = "tropical" },
                new Climate { key = "0102010307", climate = "tropical" },
                new Climate { key = "0102010409", climate = "tropical" },
                new Climate { key = "0102010401", climate = "tropical" },
                new Climate { key = "0102010403", climate = "tropical" },
                new Climate { key = "0102010404", climate = "tropical" },
                new Climate { key = "0102010405", climate = "tropical" },
                new Climate { key = "0102010407", climate = "tropical" },
                new Climate { key = "0102020209", climate = "tropical" },
                new Climate { key = "0102020201", climate = "tropical" },
                new Climate { key = "0102020203", climate = "tropical" },
                new Climate { key = "0102020204", climate = "tropical" },
                new Climate { key = "0102020205", climate = "tropical" },
                new Climate { key = "0102020207", climate = "tropical" },
                new Climate { key = "0102020309", climate = "tropical" },
                new Climate { key = "0102020301", climate = "tropical" },
                new Climate { key = "0102020303", climate = "tropical" },
                new Climate { key = "0102020304", climate = "tropical" },
                new Climate { key = "0102020305", climate = "tropical" },
                new Climate { key = "0102020307", climate = "tropical" },
                new Climate { key = "0102020409", climate = "tropical" },
                new Climate { key = "0102020401", climate = "tropical" },
                new Climate { key = "0102020403", climate = "tropical" },
                new Climate { key = "0102020404", climate = "tropical" },
                new Climate { key = "0102020405", climate = "tropical" },
                new Climate { key = "0102020407", climate = "tropical" },
                new Climate { key = "0202010205", climate = "tropical" },
                new Climate { key = "0202010207", climate = "tropical" },
                new Climate { key = "0202010309", climate = "tropical" },
                new Climate { key = "0202010301", climate = "tropical" },
                new Climate { key = "0202010303", climate = "tropical" },
                new Climate { key = "0202010304", climate = "tropical" },
                new Climate { key = "0202010305", climate = "tropical" },
                new Climate { key = "0202010307", climate = "tropical" },
                new Climate { key = "0202010409", climate = "tropical" },
                new Climate { key = "0202010401", climate = "tropical" },
                new Climate { key = "0202010403", climate = "tropical" },
                new Climate { key = "0202010404", climate = "tropical" },
                new Climate { key = "0202010405", climate = "tropical" },
                new Climate { key = "0202010407", climate = "tropical" },
                new Climate { key = "0202020209", climate = "tropical" },
                new Climate { key = "0202020201", climate = "tropical" },
                new Climate { key = "0202020203", climate = "tropical" },
                new Climate { key = "0202020204", climate = "tropical" },
                new Climate { key = "0202020205", climate = "tropical" },
                new Climate { key = "0202020207", climate = "tropical" },
                new Climate { key = "0202020309", climate = "tropical" },
                new Climate { key = "0202020301", climate = "tropical" },
                new Climate { key = "0202020303", climate = "tropical" },
                new Climate { key = "0202020304", climate = "tropical" },
                new Climate { key = "0202020305", climate = "tropical" },
                new Climate { key = "0202020307", climate = "tropical" },
                new Climate { key = "0202020409", climate = "tropical" },
                new Climate { key = "0202020401", climate = "tropical" },
                new Climate { key = "0202020403", climate = "tropical" },
                new Climate { key = "0202020404", climate = "tropical" },
                new Climate { key = "0202020405", climate = "tropical" },
                new Climate { key = "0202020407", climate = "tropical" },
                new Climate { key = "0000010100", climate = "arid" },
                new Climate { key = "0000010200", climate = "arid" },
                new Climate { key = "0000020100", climate = "arid" },
                new Climate { key = "0000020200", climate = "arid" },
                new Climate { key = "0301010100", climate = "dry temperate" },
                new Climate { key = "0301010200", climate = "dry temperate" },
                new Climate { key = "0301020100", climate = "humid temperate" },
                new Climate { key = "0301020200", climate = "humid temperate" },
                new Climate { key = "0301020300", climate = "humid temperate" },
                new Climate { key = "0301020400", climate = "humid temperate" },
                new Climate { key = "0302020101", climate = "cool temperate" },
                new Climate { key = "0302020102", climate = "cool temperate" },
                new Climate { key = "0302020103", climate = "cool temperate" },
                new Climate { key = "0302020201", climate = "cool temperate" },
                new Climate { key = "0302020202", climate = "cool temperate" },
                new Climate { key = "0302020203", climate = "cool temperate" },
                new Climate { key = "0302020301", climate = "cool temperate" },
                new Climate { key = "0302020302", climate = "cool temperate" },
                new Climate { key = "0302020303", climate = "cool temperate" },
                new Climate { key = "0302020401", climate = "cool temperate" },
                new Climate { key = "0302020402", climate = "cool temperate" },
                new Climate { key = "0302020403", climate = "cool temperate" },
                new Climate { key = "0303020101", climate = "cool temperate" },
                new Climate { key = "0303020102", climate = "cool temperate" },
                new Climate { key = "0303020103", climate = "cool temperate" },
                new Climate { key = "0303020108", climate = "cool temperate" },
                new Climate { key = "0303020201", climate = "cool temperate" },
                new Climate { key = "0303020202", climate = "cool temperate" },
                new Climate { key = "0303020203", climate = "cool temperate" },
                new Climate { key = "0303020208", climate = "cool temperate" },
                new Climate { key = "0303020301", climate = "cool temperate" },
                new Climate { key = "0303020302", climate = "cool temperate" },
                new Climate { key = "0303020303", climate = "cool temperate" },
                new Climate { key = "0303020308", climate = "cool temperate" },
                new Climate { key = "0303020401", climate = "cool temperate" },
                new Climate { key = "0303020402", climate = "cool temperate" },
                new Climate { key = "0303020403", climate = "cool temperate" },
                new Climate { key = "0303020408", climate = "cool temperate" },
                new Climate { key = "0003030100", climate = "alpine" },
                new Climate { key = "0003030300", climate = "alpine" },
                new Climate { key = "0003030400", climate = "alpine" },
                new Climate { key = "0401000000", climate = "polar" } };

       //     Lookup<string, string> lookup = (Lookup<string, string>)climates.ToLookup(p => p.key, p => p.climate);
            Lookup<string, string> lookup = (Lookup<string, string>)climates.ToLookup(p => constructedKey, p => p.climate);


    //        ILookup<char, string> namesByInitial = names.ToLookup((n) => n[0]);

            // count the names
    //        Console.WriteLine("J's: {0}", namesByInitial['J'].Count());


            // Iterate through each IGrouping in the Lookup and output the contents.
            foreach (IGrouping<string, string> climateGroup in lookup)
            {
                // Print the key value of the IGrouping.
                Console.WriteLine(climateGroup.Key);
                // Iterate through each value in the IGrouping and print its value.
                foreach (string str in climateGroup)
                    Console.WriteLine("    {0}", str);
            }


            // Get the number of key-collection pairs in the Lookup.
            int count = lookup.Count;

            // Select a collection of Packages by indexing directly into the Lookup.
            IEnumerable<string> cgroup = lookup["c"];



            // Output the results.
            Console.WriteLine("\nPackages that have a key of 'C':");
            foreach (string str in cgroup)
                Console.WriteLine(str);

            // This code produces the following output:
            //
            // Packages that have a key of 'C'
            // Coho Vineyard 89453312
            // Contoso Pharmaceuticals 670053128

            // Determine if there is a key with the value 'G' in the Lookup.
            bool hasG = lookup.Contains(constructedKey);


            return lookup.ToString();
        }


    }

}