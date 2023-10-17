static string ReapeatString(string text, int count)
{
    string outpud = "";
    for (int i = 0; i < count; i++)
    {
        outpud += text;
    }
    return outpud;
}

string text = Console.ReadLine();
int count = int.Parse(Console.ReadLine());

string result = ReapeatString(text, count);

Console.WriteLine(result);

