using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparison_OOP
{
    public interface IDetermineLength
    {
        void addCartesianPoints(int x_point1, int x_point2, int y_point1, int y_point2, float length);
        void computeLength();
    }
}