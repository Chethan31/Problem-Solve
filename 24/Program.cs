int i, j;
int n;
int l;

Console.Write("Enter N value:");
n = int.Parse(Console.ReadLine());

Console.WriteLine();
for (i = 0; i < n; i++)
{
    for (j = 0; j <= i; j++)
    {
        Console.Write($"{j+1} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (i = 0; i < n; i++)
{
    for (j = 0; j <= i; j++)
    {
        Console.Write($"{i + 1} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
l = 0;
for (i = 0; i < n; i++)
{
    for (j = 0; j <= i; j++)
    {
        l++;
        Console.Write($"{l} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
int sum=1;
int first=0,second=1;
for (i = 0; i < n; i++)
{
    for (j = 0; j <= i; j++)
    {
        if (sum <= 10)
        {
            Console.Write($"{sum} ");
            sum = first + second;
            first = second;
            second = sum;
        }
    }
    Console.WriteLine();
}