string munth = Console.ReadLine();
int night = int.Parse(Console.ReadLine());

double studioPrice = 0;
double apartmentPrice = 0;

switch (munth)
{
    case "May":
    case "October":
        studioPrice = 50;
        apartmentPrice = 65;
        break;
    case "June":
    case "September":
        studioPrice = 75.20;
        apartmentPrice = 68.70;
        break;
    default:
        studioPrice = 76;
        apartmentPrice = 77;
        break;
}
double studioTotal = studioPrice * night;
double apartmentTotal = apartmentPrice * night;
if (night > 14)
{
    if (munth == "May" || munth == "October")
    {
        studioTotal *= 0.70;
        apartmentTotal *= 0.9;
    }
    else if (munth == "June" || munth == "September")
    {
        studioTotal *= 0.8;
        apartmentTotal *= 0.9;
    }
}
else if (night < 7)
    if (munth == "May" || munth == "October")
    {
        studioTotal *= 0.95;
    }


Console.WriteLine($"Apartment: {apartmentTotal:f2} lv.");
Console.WriteLine($"Studio: {studioTotal:f2} lv.");
