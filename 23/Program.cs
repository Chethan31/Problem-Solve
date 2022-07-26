int i, j;
int n;

Console.Write("Enter N value:");
n=int.Parse(Console.ReadLine());

Console.WriteLine();
for (i = 0; i < n; i++)
{
    for (j = 0; j < 5; j++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (i = 0; i < n; i++)
{
    for (j = 0; j < 5; j++)
    {
        Console.Write($"{i+1} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (i = 0; i < n; i++)
{
    for (j = 0; j < 5; j++)
    {
        Console.Write($"{j + 1} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (i = 0; i < n; i++)
{
    for (j = 0; j <= i ; j++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}