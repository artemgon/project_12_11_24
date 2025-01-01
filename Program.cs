namespace project_12_11_24
{
    public class Program
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter the lower bound of the range: ");
                int lowerBound = positiveFunc();
                Console.Write("Enter the upper bound of the range: ");
                int upperBound = positiveFunc();
                if (upperBound < lowerBound)
                {
                    throw new ArgumentException("The upper bound must be greater than or equal to the lower bound.");
                }
                int a = 0, b = 1;
                while (a <= upperBound)
                {
                    if (a >= lowerBound)
                    {
                        Console.Write(a + " ");
                    }

                    int temp = a;
                    a = b;
                    b = temp + b;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error...The number must be an integer.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error... {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error...{ex.Message}");
            }
        }
        static int positiveFunc()
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
