List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

string command = Console.ReadLine();

while (command != "end")
{
    string[] commandParts = command.Split(" ");
    string commandName = commandParts[0];
    int num = int.Parse(commandParts[1]);

    if (commandName == "Add")
    {
        numbers.Add(num);
    }
    else if (commandName == "Remove")
    {
        numbers.Remove(num);
    }
    else if (commandName == "Insert")
    {
        int index = int.Parse(commandParts[2]);
        numbers.Insert(index, num);
    }
    else
    {
        int index = int.Parse(commandParts[1]);
        numbers.RemoveAt(index);
    }
    command = Console.ReadLine();
}
Console.WriteLine(string.Join(" ", numbers));

//List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

//string command = Console.ReadLine();

//while (command != "end")
//{
//    if (command.StartsWith("Add"))
//    {
//        int numberToAdd = int.Parse(command.Split(" ")[1]);
//        numbers.Add(numberToAdd);
//    }
//    else if (command.StartsWith("RemoveAt"))
//    {
//        int indexToRemove = int.Parse(command.Split(" ")[1]);
//        numbers.RemoveAt(indexToRemove);
//    }
//    else if (command.StartsWith("Remove"))
//    {
//        int numberToRemove = int.Parse (command.Split(" ")[1]);
//        numbers.Remove(numberToRemove);
//    }
//    else if (command.StartsWith("Insert"))
//    {
//        int numberToInsert = int.Parse(command.Split(" ")[1]);
//        int indexToInsert = int.Parse(command.Split(" ")[2]);
//        numbers.Insert(indexToInsert, numberToInsert);
//    }

// command = Console.ReadLine();
//}
//Console.WriteLine(string.Join(" ", numbers));

