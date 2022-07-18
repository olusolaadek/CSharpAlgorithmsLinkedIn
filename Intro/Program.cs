// Intro
static int findMax(int a, int b, int c)
{
    int max = a;
    if (b > max)
    {
        max = b;
    }
    if (c > max)
    {
        max = c;
    }
    return max;
}

Console.WriteLine(findMax(4, 1, 21));
Console.WriteLine(findMax(4, 2, 11));
Console.WriteLine(findMax(-4, 3, 33));