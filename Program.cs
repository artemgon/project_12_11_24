namespace project_12_11_24
{
    public class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter two positive numbers: ");
                int A = PositiveNumber(), B = PositiveNumber();
                for (int i = A; i <= B; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write(i + " ");
                    }
                    Console.WriteLine();
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        }
        static int PositiveNumber()
        {
            int n = int.Parse(Console.ReadLine() ?? "");
            if (n <= 0)
            {
                throw new ArgumentException("The number must be positive");
            }
            else
                return n;
        }
    }
}
