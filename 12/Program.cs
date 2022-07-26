int n;
double val;
int i,j;
Console.Write("Enter N value:");
n = int.Parse(Console.ReadLine());

Console.WriteLine();
i = 1;
j = 2;
while (i <= n)
{
    val = Math.Pow(j, 2);
    Console.Write($"{val} ");
    j = j + 2;
    i++;
    
}
Console.WriteLine();

Console.WriteLine();
i = 1;
while (i <= n)
{
    if(i%2==0)
        Console.Write($"-{i} ");
    else
        Console.Write($"{i} ");
    i = i + 1;
}
Console.WriteLine();

/*Console.WriteLine();
i = 1;
while (i <= n)
{
    val = Math.Pow(i, i);
    Console.Write($"{val} ");
    i++;
}
Console.WriteLine();*/


