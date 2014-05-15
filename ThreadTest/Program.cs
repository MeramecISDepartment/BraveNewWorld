using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using VectorLandMesh.Land;
using VectorLandMesh.Data;
namespace ThreadTest
{
    class Program
    {
        static void Main()
        {
            #region Map Initialization
            //Clear drawing area.
            //drawing.Clear(Color.Blue);

            //Initialize the map if there is a seed use it.
            if (useSeed)
                //Map.InitializeMap(Detail, new float[] { drawing.VisibleClipBounds.X, drawing.VisibleClipBounds.Y, drawing.VisibleClipBounds.Width, drawing.VisibleClipBounds.Height }, SeedValue);
                Map.InitializeMap(Detail, new float[] { 0, 0, 340, 340 }, SeedValue);
            else
                Map.InitializeMap(Detail, new float[] { 0, 0, 340, 340 });
            //Map.InitializeMap(Detail, new float[] { drawing.VisibleClipBounds.X, drawing.VisibleClipBounds.Y, drawing.VisibleClipBounds.Width, drawing.VisibleClipBounds.Height });
            #endregion
            #region Terrain Generation Variables
            //number of current meshes on each level.
            int meshOnLevel = 0;
            List<LandMesh> mapMeshData = new List<LandMesh>();
            #endregion
            int avarage = 0;
            int NUMBER_OF_THREDS = 10;
            List<int> RandomSeedValues = new List<int>();
            List<int> meshOnLevels = new List<int>();
            List<List<int>> meshsOnThreads = new List<List<int>>();

            List<Thread> Threads = new List<Thread>();
            #region Thread Separation
            //grabs a first random number from an odds map... but not zero.

            for (int x = Levels; x > 0; x--)
            {
                RandomSeedValues.Add(Map.MapSeed.Next());
                if (x == Levels)
                {
                    while (meshOnLevel == 0)
                    {
                        meshOnLevel = OddsMap[Map.MapSeed.Next(0, OddsMap.Length - 1)]; 
                    }
                }
                else
                {
                    meshOnLevel=(OddsMap[Map.MapSeed.Next(0, OddsMap.Length - 1)]);
                }
                meshOnLevels.Add(meshOnLevel);
            }
            List<int> copy = new List<int>(meshOnLevels);
            int counter = 1;
            var ContoursOnLevelsQ = from a in meshOnLevels
                                    let n=a * counter++
                                    orderby n descending 
                                    select n;
            List<int> ContoursOnLevels = ContoursOnLevelsQ.ToList<int>();

            avarage = (ContoursOnLevels.Sum() / NUMBER_OF_THREDS);
            int heightOffset = 0;
            while (meshsOnThreads.Count != NUMBER_OF_THREDS)
            {
                
                int threadNumber = meshsOnThreads.Count;
                counter = -1;
                int chunkCount = 0;
                var results =
                    from n in ContoursOnLevels
                    where (counter++ != null && checkIt(ref chunkCount, n, avarage, ref counter) && counter < meshOnLevels.Count)
                    select meshOnLevels[counter];

                List<int> curentlist = results.ToList<int>();
                //curentlist.Reverse();
                meshsOnThreads.Add(curentlist);
                if (curentlist.Count != 0)
                {
                    meshOnLevels.RemoveRange(0, curentlist.Count());
                    ContoursOnLevels.RemoveRange(0, curentlist.Count());


                    int h = heightOffset;
                    int i = RandomSeedValues.Count - 1;
                    Threads.Add(new Thread(() => ThreadMesh(ref mapMeshData, meshsOnThreads[threadNumber], RandomSeedValues, h)));
                    heightOffset += curentlist.Count();
                }
                
            }
            //meshsOnThreads.Reverse();
            /*
            for (int x = NUMBER_OF_THREDS; x > 0; x--)
            {
                ContourCount=0;
                meshsOnThreads.Add(new List<int>());
                RandomSeedValues.Add(new List<int>());
                while (ContourCount <= avarage && i < Levels)
                {
                    meshsOnThreads[meshsOnThreads.Count - 1].Add(meshOnLevels[i]);
                    RandomSeedValues[RandomSeedValues.Count - 1].Add(Map.MapSeed.Next());
                    ContourCount += meshOnLevels[i] * (Levels-i);
                    i += 1;
                }
                
                
            }
             */
            #endregion

            #region Terrain Generation
            for (int x = Threads.Count(); x > 0; x--)
            {
                Threads[x-1].Start();
            }
            #endregion
            int thredsAlive = 1;


            while (thredsAlive > 0) 
            {
                thredsAlive = Threads.Count(n => n.IsAlive); 
            }
            
            var SortedByHeigght =
                from mesh in mapMeshData
                orderby mesh.HeightLevel descending
                orderby mesh.CenterPoint.X descending
                orderby mesh.CenterPoint.Y descending
                select mesh;
            mapMeshData=SortedByHeigght.ToList();
            Console.ReadKey();
        }


        private static bool checkIt(ref int chunkCount, int n, int avarage, ref int counter)
        {
            
            bool result = (chunkCount) <= avarage;
            chunkCount += n;
            return result;
        }
        static void ThreadMesh(ref List<LandMesh> mapMeshData, List<int> MeshesOnLevel, List<int> RandomSeedValues, int heightOffset)
        {
            List<LandMesh> mapMeshChunk=new List<LandMesh>();
            //temp Variable for one landMesh
            LandMesh land;
            int CurrentLevel=0;
            for (int x = MeshesOnLevel.Count; x > 0; x--)
            {
                CurrentLevel=MeshesOnLevel.Count - x;
                Random Seed = new Random(RandomSeedValues[CurrentLevel + heightOffset]);
                //adds new Contour for each existing mesh.                
                foreach (LandMesh mesh in mapMeshChunk)
                {
                    mesh.addNewContour();
                }

                //add new land mesh(s)
                for (int y = MeshesOnLevel[CurrentLevel]; y > 0; y--)
                {
                    land = new LandMesh(Program.VectorLengths, 1D,Seed.Next(), x + heightOffset);
                    mapMeshChunk.Add(land);
                }
            }
            lock (Map.threadLocker)
            {
                mapMeshData.AddRange(mapMeshChunk);
            }
        }

 
        #region User Interactive Properties
        /// <summary>
        /// The Default number of levels
        /// </summary>
        public static int DefaultLevels { get { return 32; } }



        /// <summary>
        /// odds map will be generated by settings.
        /// </summary>
        public static int[] OddsMap = { 0, 0, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4 };

        /// <summary>
        /// Number of points on each Contour | Number of levels on a map.
        /// </summary>
        public static int Detail = 16, Levels = DefaultLevels;

        /// <summary>
        /// test for map data. will be set in to class List
        /// </summary>

        public static List<System.Windows.Point> VectorLengths = new List<System.Windows.Point>() { new System.Windows.Point(10, 20), new System.Windows.Point(5, 20) };

        /// <summary>
        /// Value of the seed if it is used
        /// </summary>
        public static int SeedValue=123;

        /// <summary>
        /// If The SeedValue is being used to seed the Random Object
        /// </summary>
        public static bool useSeed = true;
        #endregion

    }
}
