using System.Threading.Channels;

namespace _06.Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stepsGoal = 10_000;
            int stepsToDay = 0;
            string input;
            bool finished = false;

            while (!finished && stepsToDay < stepsGoal)
            {
                input = Console.ReadLine();
                if (input == "Going home")
                {
                    finished = true;
                    input = Console.ReadLine();
                }
                stepsToDay += int.Parse(input);
            }
            if (stepsToDay < stepsGoal)
            {
                Console.WriteLine($"{stepsGoal-stepsToDay} more steps to reach goal.");
            }
            else
            {
                Console.WriteLine($"Goal reached! Good job!");
                Console.Write($"{stepsToDay - stepsGoal} steps over the goal!");
            }

        }
    }
}