int i, j, k, l;
int n;


Console.Write("Enter N value:");
n = int.Parse(Console.ReadLine());

Console.WriteLine();
l = 0;
for (i = 0; i < n; i++)
{
    for (j = 0; j <= i; j++) 
    { 
        l++;
        if(l%2 == 0)
            Console.Write("-");
        Console.Write($"{Math.Pow(l,2)} ");
    }
Console.WriteLine();
}

Console.WriteLine();
l = 0;
int fact;
for (i = 0; i < n; i++)
{
    for (j = 0; j <= i; j++)
    {
        fact = 1;
        for (k = 1; k <= l; k++)
            fact = fact * k;
        Console.Write($"{fact} ");
        l++;
    }
    Console.WriteLine();
}

Console.WriteLine();
for (i = 0; i < n; i++)
{
    for (k = 0; k < n-i-1; k++)
    {
        Console.Write("  ");
    }
    for (j = 0; j <= i; j++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}

Console.WriteLine();
for (i = 0; i < n; i++)
{
    for (k = 0; k < n - i - 1; k++)
    {
        Console.Write("  ");
    }
    for (j = 0; j <= i; j++)
    {
        Console.Write("* ");
    }
    for (l = 0; l < i; l++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}
