using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public static class ShapeCalculator
    {
        public static double GetCircleArea(double r) => Math.PI * Math.Pow(r, 2);
        public static double GetCirclePerimeter(double r) => 2 * Math.PI * r;
        public static double GetRectangleArea(double a, double b) => a * b;
        public static double GetRectanglePerimeter(double a, double b) => 2 * (a + b);
        public static double GetEquilateralTriangleArea(double a) => (Math.Sqrt(3) / 4) * Math.Pow(a, 2);
        public static double GetEquilateralTrianglePerimeter(double a) => 3 * a;
    }
}
