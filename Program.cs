using System;

namespace SampleSonarApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, SonarQube!");
            int a = 10;
            int b = 0;

            try
            {
                int result = Divide(a, b);
                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        static int Divide(int x, int y)
        {
            return x / y;
        }
    }
}
