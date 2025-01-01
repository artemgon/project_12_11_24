namespace project_12_11_24
{
    public class Program
    {
        static void Main()
        {
            try
            {
                int number = validNumber();
                Console.WriteLine("Enter two digit places: ");
                int first = int.Parse(Console.ReadLine() ?? "");
                int second = int.Parse(Console.ReadLine() ?? "");
                if (first < 1 || first > 6 || second < 1 || second > 6)
                {
                    throw new Exception("Invalid digit places");
                }
                char[] digits = number.ToString().ToCharArray();
                char temp = digits[first - 1];
                digits[first - 1] = digits[second - 1];
                digits[second - 1] = temp;
                string newNumber = new string(digits);
                Console.WriteLine($"Modified number: {newNumber}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error... " + ex.Message);
            }
        }
        static int validNumber()
        {
            int n = int.Parse(Console.ReadLine() ?? "");
            if(n < 100000 || n >= 1000000)
            {
                throw new Exception("Number isn't valid");
            }
            return n;
        }
    }
}
