namespace project_12_11_24
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the temperature: ");
            float temperature = float.Parse(Console.ReadLine() ?? "");
            Console.WriteLine("Choose the scale you want to convert to. ");
            Console.WriteLine("True for Fahrenheit, False for Celsius: ");
            bool scale = bool.Parse(Console.ReadLine() ?? "");
            if (scale)
            {
                //conversion to fahrenheit
                float temp1 = temperature * 9 / 5 + 32;
                Console.WriteLine("The temperature in Fahrenheit is: " + temp1);
            }
            else
            {
                //conversion to celsius
                float temp2 = (temperature - 32) * 5 / 9;
                Console.WriteLine("The temperature in Celsius is: " + temp2);
            }
        }

    }
}
