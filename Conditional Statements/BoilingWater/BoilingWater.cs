namespace BoilingWater
{
    internal class BoilingWater
    {
        static void Main(string[] args)
        {
            int waterTemperature = int.Parse(Console.ReadLine());

            if (waterTemperature > 100)
                Console.WriteLine("The water is boiling");
            else
                Console.WriteLine("The water is not hot enough");

        }
    }
}