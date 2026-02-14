namespace MpP
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter a:");
                    var a = double.Parse(Console.ReadLine()!);

                    Console.WriteLine("Enter b:");
                    var b = double.Parse(Console.ReadLine()!);

                    var result = LinearResolve.SolveLinear(a, b);
                    Console.WriteLine(result);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter valid values.");
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
