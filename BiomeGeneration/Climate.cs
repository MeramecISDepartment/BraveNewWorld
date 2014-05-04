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


/*       private string keyValue = "";
        private string climateTyp = "";

        public string Key { get; set; }

        public string ClimateType { get; set; }

        // four-argument constructor
        public Climate(string key, string climate)
        {
            KeyValue = key;
            ClimateType = climate;
        } // end constructor      */
        /*
        public static string ClimateLookup(string constructedKey)
        {
          //  string tempClimate;

            Climate[] climates = { 
                new Climate ("0101010209", "tropical"),
                new Climate ("0101010201", "tropical"),
                new Climate ("0101010203", "tropical"),
                new Climate ("0101010204", "tropical"),
                new Climate ("0101010205", "tropical"),
                new Climate ("0101010207", "tropical"),
                new Climate ("0101010309", "tropical"),
                new Climate ("0101010301", "tropical"),
                new Climate ("0101010303", "tropical"),
                new Climate ("0101010304", "tropical"),
                new Climate ("0101010305", "tropical"),
                new Climate ("0101010307", "tropical"),
                new Climate ("0101010409", "tropical"),
                new Climate ("0101010401", "tropical"),
                new Climate ("0101010403", "tropical"),
                new Climate ("0101010404", "tropical"),
                new Climate ("0101010405", "tropical"),
                new Climate ("0101010407", "tropical"),
                new Climate ("0101020209", "tropical"),
                new Climate ("0101020201", "tropical"),
                new Climate ("0101020203", "tropical"),
                new Climate ("0101020204", "tropical"),
                new Climate ("0101020205", "tropical"),
                new Climate ("0101020207", "tropical"),
                new Climate ("0101020309", "tropical"),
                new Climate ("0101020301", "tropical"),
                new Climate ("0101020303", "tropical"),
                new Climate ("0101020304", "tropical"),
                new Climate ("0101020305", "tropical"),
                new Climate ("0101020307", "tropical"),
                new Climate ("0101020409", "tropical"),
                new Climate ("0101020401", "tropical"),
                new Climate ("0101020403", "tropical"),
                new Climate ("0101020404", "tropical"),
                new Climate ("0101020405", "tropical"),
                new Climate ("0101020407", "tropical"),
                new Climate ("0201010205", "tropical"),
                new Climate ("0201010207", "tropical"),
                new Climate ("0201010309", "tropical"),
                new Climate ("0201010301", "tropical"),
                new Climate ("0201010303", "tropical"),
                new Climate ("0201010304", "tropical"),
                new Climate ("0201010305", "tropical"),
                new Climate ("0201010307", "tropical"),
                new Climate ("0201010409", "tropical"),
                new Climate ("0201010401", "tropical"),
                new Climate ("0201010403", "tropical"),
                new Climate ("0201010404", "tropical"),
                new Climate ("0201010405", "tropical"),
                new Climate ("0201010407", "tropical"),
                new Climate ("0201020209", "tropical"),
                new Climate ("0201020201", "tropical"),
                new Climate ("0201020203", "tropical"),
                new Climate ("0201020204", "tropical"),
                new Climate ("0201020205", "tropical"),
                new Climate ("0201020207", "tropical"),
                new Climate ("0201020309", "tropical"),
                new Climate ("0201020301", "tropical"),
                new Climate ("0201020303", "tropical"),
                new Climate ("0201020304", "tropical"),
                new Climate ("0201020305", "tropical"),
                new Climate ("0201020307", "tropical"),
                new Climate ("0201020409", "tropical"),
                new Climate ("0201020401", "tropical"),
                new Climate ("0201020403", "tropical"),
                new Climate ("0201020404", "tropical"),
                new Climate ("0201020405", "tropical"),
                new Climate ("0201020407", "tropical"),
                new Climate ("0102010209", "tropical"),
                new Climate ("0102010201", "tropical"),
                new Climate ("0102010203", "tropical"),
                new Climate ("0102010204", "tropical"),
                new Climate ("0102010205", "tropical"),
                new Climate ("0102010207", "tropical"),
                new Climate ("0102010309", "tropical"),
                new Climate ("0102010301", "tropical"),
                new Climate ("0102010303", "tropical"),
                new Climate ("0102010304", "tropical"),
                new Climate ("0102010305", "tropical"),
                new Climate ("0102010307", "tropical"),
                new Climate ("0102010409", "tropical"),
                new Climate ("0102010401", "tropical"),
                new Climate ("0102010403", "tropical"),
                new Climate ("0102010404", "tropical"),
                new Climate ("0102010405", "tropical"),
                new Climate ("0102010407", "tropical"),
                new Climate ("0102020209", "tropical"),
                new Climate ("0102020201", "tropical"),
                new Climate ("0102020203", "tropical"),
                new Climate ("0102020204", "tropical"),
                new Climate ("0102020205", "tropical"),
                new Climate ("0102020207", "tropical"),
                new Climate ("0102020309", "tropical"),
                new Climate ("0102020301", "tropical"),
                new Climate ("0102020303", "tropical"),
                new Climate ("0102020304", "tropical"),
                new Climate ("0102020305", "tropical"),
                new Climate ("0102020307", "tropical"),
                new Climate ("0102020409", "tropical"),
                new Climate ("0102020401", "tropical"),
                new Climate ("0102020403", "tropical"),
                new Climate ("0102020404", "tropical"),
                new Climate ("0102020405", "tropical"),
                new Climate ("0102020407", "tropical"),
                new Climate ("0202010205", "tropical"),
                new Climate ("0202010207", "tropical"),
                new Climate ("0202010309", "tropical"),
                new Climate ("0202010301", "tropical"),
                new Climate ("0202010303", "tropical"),
                new Climate ("0202010304", "tropical"),
                new Climate ("0202010305", "tropical"),
                new Climate ("0202010307", "tropical"),
                new Climate ("0202010409", "tropical"),
                new Climate ("0202010401", "tropical"),
                new Climate ("0202010403", "tropical"),
                new Climate ("0202010404", "tropical"),
                new Climate ("0202010405", "tropical"),
                new Climate ("0202010407", "tropical"),
                new Climate ("0202020209", "tropical"),
                new Climate ("0202020201", "tropical"),
                new Climate ("0202020203", "tropical"),
                new Climate ("0202020204", "tropical"),
                new Climate ("0202020205", "tropical"),
                new Climate ("0202020207", "tropical"),
                new Climate ("0202020309", "tropical"),
                new Climate ("0202020301", "tropical"),
                new Climate ("0202020303", "tropical"),
                new Climate ("0202020304", "tropical"),
                new Climate ("0202020305", "tropical"),
                new Climate ("0202020307", "tropical"),
                new Climate ("0202020409", "tropical"),
                new Climate ("0202020401", "tropical"),
                new Climate ("0202020403", "tropical"),
                new Climate ("0202020404", "tropical"),
                new Climate ("0202020405", "tropical"),
                new Climate ("0202020407", "tropical"),
                new Climate ("0000010100", "arid"),
                new Climate ("0000010200", "arid"),
                new Climate ("0000020100", "arid"),
                new Climate ("0000020200", "arid"),
                new Climate ("0301010100", "dry temperate"),
                new Climate ("0301010200", "dry temperate"),
                new Climate ("0301020100", "humid temperate"),
                new Climate ("0301020200", "humid temperate"),
                new Climate ("0301020300", "humid temperate"),
                new Climate ("0301020400", "humid temperate"),
                new Climate ("0302020101", "cool temperate"),
                new Climate ("0302020102", "cool temperate"),
                new Climate ("0302020103", "cool temperate"),
                new Climate ("0302020201", "cool temperate"),
                new Climate ("0302020202", "cool temperate"),
                new Climate ("0302020203", "cool temperate"),
                new Climate ("0302020301", "cool temperate"),
                new Climate ("0302020302", "cool temperate"),
                new Climate ("0302020303", "cool temperate"),
                new Climate ("0302020401", "cool temperate"),
                new Climate ("0302020402", "cool temperate"),
                new Climate ("0302020403", "cool temperate"),
                new Climate ("0303020101", "cool temperate"),
                new Climate ("0303020102", "cool temperate"),
                new Climate ("0303020103", "cool temperate"),
                new Climate ("0303020108", "cool temperate"),
                new Climate ("0303020201", "cool temperate"),
                new Climate ("0303020202", "cool temperate"),
                new Climate ("0303020203", "cool temperate"),
                new Climate ("0303020208", "cool temperate"),
                new Climate ("0303020301", "cool temperate"),
                new Climate ("0303020302", "cool temperate"),
                new Climate ("0303020303", "cool temperate"),
                new Climate ("0303020308", "cool temperate"),
                new Climate ("0303020401", "cool temperate"),
                new Climate ("0303020402", "cool temperate"),
                new Climate ("0303020403", "cool temperate"),
                new Climate ("0303020408", "cool temperate"),
                new Climate ("0003030100", "alpine"),
                new Climate ("0003030300", "alpine"),
                new Climate ("0003030400", "alpine"),
                new Climate ("0401000000", "polar") };

            var climateToReturn =
            from i in climates
            where i.m_key == constructedKey
            select i;

            Console.WriteLine("Climate");
            if (climateToReturn.Any())
                foreach (var element in climateToReturn)
                {
                    Console.WriteLine(element.m_climate);
                    tempClimate = element.m_climate;
                }
            else
            {
                Console.WriteLine("No value matches this key");
                tempClimate = "no value";
            }
            return tempClimate;   */
            /*
                        //     Lookup<string, string> lookup = (Lookup<string, string>)climates.ToLookup(p => p.key, p => p.climate);
                        Lookup<string, string> lookup = (Lookup<string, string>)climates.ToLookup(p => p.key == constructedKey, p => p.climate);


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
                    } */
    

        

    }
}