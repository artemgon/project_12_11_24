namespace project_12_11_24
{
    public class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter two numbers: ");
                Console.WriteLine("Start: ");
                int start = int.Parse(Console.ReadLine() ?? "");
                Console.WriteLine("End: ");
                int end = int.Parse(Console.ReadLine() ?? "");
                if (start > end)
                {
                    int temp = start;
                    start = end;
                    end = temp;
                }
                if (start == end)
                {
                    Console.WriteLine("No numbers");
                    return;
                }
                for (int i = start; i <= end; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
