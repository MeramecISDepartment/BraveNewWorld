using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using VectorLandMesh.Data;

namespace VectorLandMesh.Land
{
    /// <summary>
    /// Land Mesh Class 
    /// </summary>
    public class LandMesh
    {

        #region Properties
        /// <summary>
        /// A List of Points to define a min and max range between each level in a Mesh.
        /// Point x = min
        /// Point y = max
        /// </summary>
        public List<Point> MinMaxVectorLength { get; private set; }

        /// <summary>
        /// A list of decimal values defining the height between each level, from top to bottom.
        /// </summary>
        public List<double> HeightScaling { get; set; }

        /// <summary>
        /// The number of levels on a mesh.
        /// </summary>
        public int NumberOfLevel { get; private set; }

        /// <summary>
        /// The Height Level of the Mesh
        /// </summary>
        public double HeightLevel
        {
            get
            {
                double height = 0;
                for(int i=NumberOfLevel;i>0;i--)
                {
                    height += (HeightScaling.Count > i) ? HeightScaling[i] : HeightScaling[HeightScaling.Count - 1];
                }
                //return the height level of the first contour.
                return height;
            }
        }

        /// <summary>
        /// A List of Contours for each level of the map.
        /// </summary>
        public List<LandContour> LandVectorData { get; private set; }

        /// <summary>
        /// Central point of Mesh on the XZ Plane.
        /// </summary>
        public Point CenterPoint { get; set; }

        /// <summary>
        /// Raw point data of the mesh.
        /// </summary>
        public List<List<Point>> RawPoints
        {
            get
            {
                //set new list to be returned
                List<List<Point>> rawPoints = new List<List<Point>>();
                //add the raw points of each contor in the mesh to the new list.
                foreach (LandContour contor in LandVectorData)
                {
                    rawPoints.Add(contor.RawPoints);
                }
                //return raw points.
                return rawPoints;
            }
        }
        #endregion
            
        #region Public Methods

        /// <summary>
        /// Initilization of New Land Mesh.
        /// </summary>
        /// <param name="minMaxWidths"></param>
        /// <param name="heightScaling"></param>
        /// <param name="levels"></param>
        /// <param name="centerPoint"></param>
        private void Initialize(List<Point> minMaxWidths, List<double> heightScaling, int levels, Point centerPoint = default(Point))
        {
            //set default properties
            MinMaxVectorLength = minMaxWidths;
            NumberOfLevel = levels;
            HeightScaling = heightScaling;
            LandVectorData = new List<LandContour>();

            // if the map has not been Initialized yet Initialize it.
            if (Map.MapSeed==null)
            {
                Map.InitializeSeed();
            }
            //if no center point is set or if the center point is not within the range set a new one.
            if (centerPoint != default(Point) && centerPoint.X <= Map.Box[2] && centerPoint.Y <= Map.Box[3])
            {
                //set the center point
                this.CenterPoint = centerPoint;
            }
            else
            {
                //set a new center point based on Map bounding box.
                this.CenterPoint = new Point(Map.MapSeed.Next((int)Map.Box[0], (int)Map.Box[2]), Map.MapSeed.Next((int)Map.Box[1], (int)Map.Box[3]));
            }

            //add first Contour
            this.addNewContour();    
        }

        /// <summary>
        /// Genarate New Land Mesh Based on a Random seed with only one Contour
        /// </summary>
        /// <param name="minMaxVectorLength">A list of points (X:Min,Y:Max), or one singal point for min and max of every level.</param>
        /// <param name="heightScaling">A list of decimals , or one singal decimals for the hight of each level.</param>
        /// <param name="levels">The number of levels on a mesh.</param>
        public LandMesh(Point minMaxVectorLength, double heightScaling, int levels)
        {
            this.Initialize(new List<Point> { minMaxVectorLength }, new List<double> { heightScaling }, levels);
        }

        public LandMesh(List<Point> minMaxVectorLength, List<double> heightScaling, int levels=0)
        {
            if (levels == 0)
            {
                levels = Math.Max(minMaxVectorLength.Count, heightScaling.Count);
            }
            this.Initialize(minMaxVectorLength, heightScaling, levels);
        }

        public LandMesh(List<Point> minMaxVectorLength, double heightScaling, int levels=0)
        {
            if (levels == 0)
            {
                levels = minMaxVectorLength.Count;
            }
            this.Initialize(minMaxVectorLength, new List<double> { heightScaling }, levels);
        }

        public LandMesh(Point minMaxVectorLength, List<double> heightScaling, int levels=0)
        {
            if (levels == 0)
            {
                levels = heightScaling.Count;
            }
            this.Initialize(new List<Point> { minMaxVectorLength }, heightScaling, levels);
        }

        /// <summary>
        /// Adds a new Contour to the Mesh
        /// </summary>
        public void addNewContour()
        {
            //sets the "current height" to 0 and set
            double currentHeight = 0;

            //grabs the "last contour" created on the mesh and grabs the "last contour's scale", if it dosnt exist set it to null;
            LandContour lastContour = ListHandler<LandContour>.getNullIfOutOfRange(LandVectorData, LandVectorData.Count - 1);
            List<double> lastContourScale = (lastContour != null) ? lastContour.Scales : null;

            // the "Min and Max scale" of the new contor (X:min, Y:max), used with the "last contour's scale" when creating  a new Contour
            Point scaleMaxMin = ListHandler<Point>.getFromTrimedIndex(MinMaxVectorLength, LandVectorData.Count);

            //if this is not the fist contour on the mesh subtract the diffrence in height from the previous Contour's height level to get the new height level, else (this is the first Contour) so set it to the Mesh's "Height Level"
            currentHeight = (LandVectorData.Count > 0) ? LandVectorData[LandVectorData.Count - 1].Height - ListHandler<double>.getFromTrimedIndex(HeightScaling, LandVectorData.Count) : HeightLevel;

            // add a new Contour to the end of the list
            LandVectorData.Add(new LandContour(CenterPoint,scaleMaxMin, currentHeight, lastContourScale));
        }
        #endregion
            
    }
}