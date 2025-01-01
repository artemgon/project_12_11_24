namespace project_12_11_24
{
    public class Program
    {
        static void Main()
        {
            try
            {
                int a = positive(), b = positive(), c = positive(), f = positive();
                int number = a * 1000 + b * 100 + c * 10 + f;
                Console.WriteLine(number);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static int positive()
        {
            int n = int.Parse(Console.ReadLine() ?? "");
            if(n <= 0)
            {
                throw new Exception("Number must be positive");
            }
            return n;
        }
    }
}
