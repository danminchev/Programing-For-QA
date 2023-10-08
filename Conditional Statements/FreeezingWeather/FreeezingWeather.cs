using System.ComponentModel.Design;

namespace FreeezingWeather
{
    internal class FreeezingWeather
    {
        static void Main(string[] args)
        {
            double temperature = double.Parse(Console.ReadLine());

            if (temperature <= 0)
            {
                Console.WriteLine("Freezing weather!");
            }
        }    
    }
}