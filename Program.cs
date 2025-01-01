using System.Diagnostics;

namespace project_12_11_24
{
    public class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Length:");
                int length = Positive();
                Console.WriteLine("Symbol:");
                char symbol = char.Parse(Console.ReadLine() ?? "");
                Console.WriteLine("Enter the direction (true - horizontal, false - vertical):");
                bool direction = bool.Parse(Console.ReadLine() ?? "");
                if (direction)
                {
                    for (int i = 0; i < length; i++)
                    {
                        Console.Write(symbol);
                    }
                }
                else
                {
                    for (int i = 0; i < length; i++)
                    {
                        Console.WriteLine(symbol);
                    }
                }
            }
            catch (ArgumentException ex)
            {
               Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error... {ex.Message}");
            }
        }
        static int Positive()
        {
            int number = int.Parse(Console.ReadLine() ?? "");
            if (number < 0)
            {
                throw new ArgumentException("The number must be non-negative.");
            }
            return number;
        }
    }
}
