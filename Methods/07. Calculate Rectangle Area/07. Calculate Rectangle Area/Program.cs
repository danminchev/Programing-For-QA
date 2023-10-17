static int CalculateRectangleArea(int width, int length)
{
    int area = width * length;
    return area;
}

int width = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine());

int area = CalculateRectangleArea(width, length);

Console.WriteLine(area);


