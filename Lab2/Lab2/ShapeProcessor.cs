using Lab2.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public static class ShapeProcessor
    {
        public static void ProcessShapeAndDisplay(ShapeDataRecord dataRecord)
        {
            double area;
            double perimeter;

            switch (dataRecord.Type)
            {
                case "circle":
                    area = ShapeCalculator.GetCircleArea(dataRecord.Parameters[0]);
                    perimeter = ShapeCalculator.GetCirclePerimeter(dataRecord.Parameters[0]);
                    break;
                case "rectangle":
                    area = ShapeCalculator.GetRectangleArea(dataRecord.Parameters[0], dataRecord.Parameters[1]);
                    perimeter = ShapeCalculator.GetRectanglePerimeter(dataRecord.Parameters[0], dataRecord.Parameters[1]);
                    break;
                case "triangle":
                    area = ShapeCalculator.GetEquilateralTriangleArea(dataRecord.Parameters[0]);
                    perimeter = ShapeCalculator.GetEquilateralTrianglePerimeter(dataRecord.Parameters[0]);
                    break;
                default:
                    Console.WriteLine($"Невідомий тип фігури: {dataRecord.Type}");
                    return;
            }

            DisplayResults(dataRecord.Type, area, perimeter);
        }

        private static void DisplayResults(string type, double area, double perimeter)
        {
            Console.WriteLine($"Фігура: {type,-12} | Площа: {area,-10:F2} | Периметр: {perimeter,-10:F2}");
        }
    }
}
