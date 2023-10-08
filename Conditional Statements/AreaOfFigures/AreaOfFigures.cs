namespace AreaOfFigures
{
    internal class AreaOfFigures
    {
        static void Main(string[] args)
        {
            string figureArea = Console.ReadLine();
            //double size = double.Parse(Console.ReadLine());
            //double length = double.Parse(Console.ReadLine());
            //double width = double.Parse(Console.ReadLine());
            //double radius = double.Parse(Console.ReadLine());

            double area = 0;

            if (figureArea == "square")
            {
                double size = double.Parse(Console.ReadLine());
                area = size * size;
                Console.WriteLine($"{area:f2}");
            }
            else if (figureArea == "rectangle")
            {
                double length = double.Parse(Console.ReadLine());
                double width = double.Parse(Console.ReadLine());

                area = length * width;
                Console.WriteLine($"{area:f2}");
            }
            else if (figureArea == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                area = Math.PI * Math.Pow(radius, 2);
                Console.WriteLine($"{area:f2}");
            }
            else
                Console.WriteLine("Invalid figure.");
        }
    }
}