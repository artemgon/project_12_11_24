namespace project_12_11_24
{
    public class Program
    {
        static void Main()
        {
            try
            {
                int number = goodNumber();
                if (number % 3 == 0 && number % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (number % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (number % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(number);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static int goodNumber()
        {
            int n = int.Parse(Console.ReadLine() ?? "");
            if(n < 1 || n >100)
            {
                throw new Exception("Number is not in the range 1-100");
            }
            return n;
        }
    }
}
