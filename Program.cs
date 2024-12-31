namespace project_12_11_24
{
    public class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine() ?? "");
            Console.WriteLine($"Reverse of {number} is {ReverseNumber(number)}");
        }

        static int ReverseNumber(int number)
        {
            int reversed = 0;
            while (number != 0)
            {
                int digit = number % 10;
                reversed = reversed * 10 + digit;
                number /= 10;
            }
            return reversed;
        }
    }
}
