using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparison_OOP
{
    public class Length : IDetermineLength
    {

        private LinkedList<CartesianPoints> CartesianPointsList;
        //private Dictionary<float, CartesianPoints> PointsMap;
        private int x_point2;
        private int x_point1;
        private int y_point2;
        private int y_point1;
        private float length;

        public Length()
        {
            this.CartesianPointsList = new LinkedList<CartesianPoints>();
            //this.PointsMap = new Dictionary<float, CartesianPoints>();
        }
        public void addCartesianPoints(int x_point1, int x_point2, int y_point1, int y_point2)
        {
            CartesianPoints cartesianPoints = new CartesianPoints(x_point1, x_point2, y_point1, y_point2);
            // this.length = 0;
            this.CartesianPointsList.AddLast(cartesianPoints);
            //this.PointsMap.Add(length, cartesianPoints);
        }

        public void addCartesianPoints(int x_point1, int x_point2, int y_point1, int y_point2, float length)
        {
            throw new NotImplementedException();
        }

        public void computeLength()
        {
            foreach (var cartesianPoints in this.CartesianPointsList)
            {
                cartesianPoints.setCartesianPoints(this.computeLength(cartesianPoints));
                Console.WriteLine(cartesianPoints);
            }
        }

        private int computeLength(CartesianPoints cartesianPoints)
        {
            //variables
            float length;
            length = (float)Math.Sqrt(((x_point2 - x_point1) * (x_point2 - x_point1)) + ((y_point2 - y_point1) * (y_point2 - y_point1)));
            Console.WriteLine("The Distance between two points are:" + length);
        }
    }
}
