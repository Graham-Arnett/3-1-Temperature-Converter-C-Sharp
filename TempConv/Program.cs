namespace TempConv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the temperature converter app");
            String choice;
            do
            {
                Console.Write("Enter a temperature in fahrenheit degrees: ");

                double fahrenheit = double.Parse(Console.ReadLine());

                double celsius = (fahrenheit - 32) * 5 / 9;

                double kelvin = celsius + 273.15;

                //to limit the decimal places to two
                double roundedCelsius = Math.Round(celsius, 2);
                double roundedKelvin = Math.Round(kelvin, 2);

                Console.WriteLine($"Your temperature in celsius: {roundedCelsius}");
                Console.WriteLine($"Your temperature in kelvin: {roundedKelvin}");

                Console.Write("Would you like to go again? (y/n): ");
                choice = Console.ReadLine().ToLower().Trim();
            }while(choice == "y");

        }
    }
}
