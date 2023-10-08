namespace TicketPrice
{
    internal class TicketPrice
    {
        static void Main(string[] args)
        {
            int sideA = int.Parse(Console.ReadLine());
            int sideB = int.Parse(Console.ReadLine());
            int sideC = int.Parse(Console.ReadLine());

            if (sideA + sideB > sideC && sideB + sideC > sideA && sideA + sideC > sideB)
            {
                Console.WriteLine("Valid Triangle");
            }
            else
                Console.WriteLine("Invalid Triangle");
        }
    }
}