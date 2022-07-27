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

Console.WriteLine();
i = 1;
while (i <= n)
{
    val = Math.Pow(i, i);
    Console.Write($"{val} ");
    i++;
}
Console.WriteLine();

Console.WriteLine();
i = 4;
int value = 1;
int f1 = 3;
int f2 = 3;
int f3 = 5;
int temp;

Console.Write($"{value} ");//1
value = value + f1;
Console.Write($"{value} ");//4
value = value + f2;
Console.Write($"{value} ");//7
value = value + f3;
Console.Write($"{value} ");//12

while ( i <= n)
{
    temp = f3;//5
    value = value+ f1+ f2+ f3;
    Console.Write($"{value} ");//23
    f3 = f1 + f2 + f3;//11
    f1 = f2;//3
    f2 = temp;//5
    i++;
}
Console.WriteLine();

Console.WriteLine();
i = 1;
while (i <= n)
{
    if (i % 4 != 0)
    {
        val = Math.Pow(i, 2);
        Console.Write($"{val} ");
    }
    i++;
}
Console.WriteLine();

Console.WriteLine();
i = 1;
val = 1;
while (i <= n)
{
    
    if (i % 3 != 0)
    {
        Console.Write($"{val} ");
        val = val + i * 4;
    }
    i++;
}
Console.WriteLine();


