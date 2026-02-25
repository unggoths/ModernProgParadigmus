using Lab2.Helper;

namespace Lab2
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;


            var shapes = ShapeCsvReader.ReadShapes(CsvFilePath.FilePath);

            foreach (var shape in shapes)
            {
                ShapeProcessor.ProcessShapeAndDisplay(shape);
            }
        }
    }
}
