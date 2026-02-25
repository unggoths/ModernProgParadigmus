using Lab2.Helper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public static class ShapeCsvReader
    {
        public static List<ShapeDataRecord> ReadShapes(string filePath)
        {
            var shapes = new List<ShapeDataRecord>();
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Файл не знайдено.");
                return shapes;
            }

            var lines = File.ReadAllLines(filePath).Skip(1);
            foreach (var line in lines)
            {
                try
                {
                    var parts = line.Split(',');
                    string type = parts[0].Trim().ToLower();
                    double[] values = parts.Skip(1)
                        .Select(p => double.Parse(p.Trim(), CultureInfo.InvariantCulture))
                        .ToArray();

                    shapes.Add(new ShapeDataRecord(type, values));
                }
                catch (Exception ex)
                {
                    Console.WriteLine($" Помилка в рядку \"{line}\": {ex.Message}");
                }
            }
            return shapes;
        }
    }
}
