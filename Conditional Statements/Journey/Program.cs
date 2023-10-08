double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();
string destination = "";
string holidayType = "";

if (budget <= 100)
{
    destination = "Bulgaria";
    if (season == "summer")
    {
        holidayType = "Camp";
        budget *= 0.3;
    }
    else
    {
        holidayType = "Hotel";
        budget *= 0.7;
    }
}
else if (budget <= 1000)
{
    destination = "Balkans";
    if (season == "summer")
    {
        holidayType = "Camp";
        budget *= 0.4;
    }
    else
    {
        holidayType = "Hotel";
        budget *= 0.8;
    }
}
else
{
    destination = "Europe";
    {

        holidayType = "Hotel";
        budget *= 0.9;
    }
}
Console.WriteLine($"Somewhere in {destination}");
Console.WriteLine($"{holidayType} - {budget:f2}");
