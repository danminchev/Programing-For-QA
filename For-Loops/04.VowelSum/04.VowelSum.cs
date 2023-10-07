int countCharacters = int.Parse(Console.ReadLine());

double result = 0;

//for (int i = 0; i < countCharacters; i++)
//{
//    char vawel = char.Parse(Console.ReadLine());
//    double value = 0;

//    switch (vawel)
//    {
//        case 'a': value = 1; break;
//        case 'e': value = 2; break;
//        case 'i': value = 3; break;
//        case 'o': value = 4; break;
//        case 'u': value = 5; break;
//    }
//    result += value;
//}
while (countCharacters > 0)
{
    char vawel = char.Parse(Console.ReadLine());
    double value = 0;

    switch (vawel)
    {
        case 'a': value = 1; break;
        case 'e': value = 2; break;
        case 'i': value = 3; break;
        case 'o': value = 4; break;
        case 'u': value = 5; break;
    }
    result += value;
    countCharacters--;
}

Console.WriteLine(result);
