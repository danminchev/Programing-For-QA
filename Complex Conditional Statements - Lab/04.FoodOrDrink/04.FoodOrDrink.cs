﻿string product = Console.ReadLine();

//switch (product)
{
    //case "curry":
    //case "noodles":
    //case "sushi":
    //case "spaghetti":
    //case "bread":
    //    Console.WriteLine("food");
    ////    break;
    //case "tea":
    //case "water":
    //case "coffee":
    //case "juice":
    //    Console.WriteLine("drink");
    //    break;
    //default:
    //    Console.WriteLine("unknown");
    //    break;

    if (product == "curry" 
        || product == "noodles" 
        || product == "sushi" 
        || product == "spaghetti" 
        || product == "bread")
        Console.WriteLine("food");
    else if (product == "tea" 
        || product == "water" 
        ||product == "coffee" 
        || product == "juice")
        Console.WriteLine("drink");
    else
        Console.WriteLine("unknown");



}








