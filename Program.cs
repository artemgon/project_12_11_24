using System.Collections.Specialized;

namespace project_12_11_24
{
    public class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            try
            {
                double max = 0, min = 0, sum = 0, product = 1;
                double[] arr = new double[5];
                Console.WriteLine("Enter 5 numbers: ");
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = double.Parse(Console.ReadLine() ?? "");
                }
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > max)
                    {
                        max = arr[i];
                    }
                    if (arr[i] < min)
                    {
                        min = arr[i];
                    }
                    sum += arr[i];
                    product *= arr[i];
                }
                Console.WriteLine("Max: " + max);
                Console.WriteLine("Min: " + min);
                Console.WriteLine("Sum: " + sum);
                Console.WriteLine("Product: " + product);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
