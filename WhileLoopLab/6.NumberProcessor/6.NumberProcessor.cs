int num = int.Parse(Console.ReadLine());
string comand = Console.ReadLine();

while (true)
{
    if (comand == "End")
    {
        break;        
    }
    else if (comand == "Inc")
    {
        comand = Console.ReadLine();
        num++;
    }
    else if (comand == "Dec")
    {   
        comand = Console.ReadLine();
        num--;
    }   
}
Console.WriteLine(num);



