namespace _04.ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxPoorGrades = int.Parse(Console.ReadLine());
            string lastProblem = "";
            double gradeTotal = 0;
            int numberPoorGrades = 0;
            int gredesNum = 0;

            while (numberPoorGrades < maxPoorGrades)
            {
                string problemName = Console.ReadLine();
                if (problemName == "Enough")
                    break;

                lastProblem = problemName;
                int curentGrede = int.Parse(Console.ReadLine());
                gradeTotal += curentGrede;
                gredesNum++;
                if (curentGrede <= 4)
                 numberPoorGrades++;           
            }
            if (numberPoorGrades == maxPoorGrades)
            {
                Console.WriteLine($"You need a break, {numberPoorGrades} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {gradeTotal/gredesNum:f2}");
                Console.WriteLine($"Number of problems: {gredesNum}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }        
    }
}