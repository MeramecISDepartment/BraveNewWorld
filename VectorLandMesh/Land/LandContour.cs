using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using VectorLandMesh.Data;
namespace VectorLandMesh.Land
{

    public class LandContour
    {
        /// <summary>
        /// The Center Point of The Mesh
        /// </summary>
        public Point Center{get;set;}

        
        /// <summary>
        /// The Height Level the Contour.
        /// </summary>
        public double Height { get; set; }
        
        public LandContour()
        {

        }

        /// <summary>
        /// List of values that the Contour's Vectors are scaled off of.
        /// </summary>
        public List<double> VectorScaleList { private set; get; }

        /// <summary>
        /// A list of all the points on the Contour
        /// </summary>
        public List<Point> Points
        {
            get
            {
                //the angle or Delta of the vector
                double delta = 0D;

                //x and y point of the new point.
                double x = 0;
                double y = 0;
                List<Point> points = new List<Point>();

                //create a new point for the amount of detail on the contour.
                for (int i = Map.Detail; i > 0; i--)
                {
                    // Calculating Delta of an Vector based on the current chunk the vector is drawn on.
                    delta = Math.PI * (i / (Map.Detail / 2.0));

                    //Calculates the X and Y of the new point Offset by the center of the Contour, and scaled by a value on The List of Scaler values.
                    x = Center.X + (Math.Cos(delta) * VectorScaleList[i - 1]);
                    y = Center.Y + (Math.Sin(delta) * VectorScaleList[i - 1]);
                    points.Add(new Point(x, y));

                }
                return points;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="center"></param>
        /// <param name="scale"></param>
        /// <param name="height"></param>
        /// <param name="previousScale"></param>
        public LandContour(Point center, Point scale, double height, List<double> previousScale = null)
        {
            //
            this.VectorScaleList = new List<double>();

            //Center Point of the Contour
            this.Center = center;

            //if there is no Previous Scale Values create a new one
            if (previousScale == null)
            {
                previousScale = new List<double> { 0D };
            }

            //min and max values and offset used to calculate scaler values.
            double min = 0;
            double max = 0;
            double offset = 0;

            for (int i = Map.Detail; i > 0; i--)
            {
                offset = ListHandler<double>.getFromTrimedIndex(previousScale, i - 1);
                min = scale.X + offset;
                max = scale.Y + offset;
                int scaleValue = Map.MapSeed.Next((int)min, (int)max);
                this.VectorScaleList.Add(scaleValue);
            }
            Height = height;
        }
    }
}
