int time1 = int.Parse(Console.ReadLine());
int time2 = int.Parse(Console.ReadLine());
int time3 = int.Parse(Console.ReadLine());

int totalMinutes = time1 + time2 + time3;
int minutes = totalMinutes / 60;
int seconds = totalMinutes % 60;

string leadingZero = "";

if (seconds < 10)
{
    leadingZero = "0";
}
Console.WriteLine($"{minutes}:{leadingZero}{seconds}");
