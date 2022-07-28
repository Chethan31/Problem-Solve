int n;
Console.Write("Enter N value:");
n = int.Parse(Console.ReadLine());

Console.WriteLine();
double val = 1;
for(int i = 0; i < n; i++)
{
    val = val + Math.Pow(i, 2);
    if(i%2==0)
        Console.Write($"{val} ");
    else
        Console.Write($"-{val} ");
}
Console.WriteLine();

Console.WriteLine();
int first = 0, second = 1;
int temp;
for (int i = 0; i < n; i++)
{
    Console.Write($"{second} ");
    temp = second;
    second = first + second;
    first = temp;
}
Console.WriteLine();

Console.WriteLine();
first = 1;
second = 2;
for (int i = 0; i < n; i++)
{
    if (i % 2 == 0)
    {
        Console.Write($"{first} ");
        first=first+3;
    }
    else
    {
        Console.Write($"-{second} ");
        second=second+4;
    }
}
Console.WriteLine();

Console.WriteLine();
first = 1;
second= 5;
int third = 8;
Console.Write($"{first} ");
for (int i = 0; i < n; i++)
{
    temp = third;
    Console.Write($"{second} ");
    third=first+second+third;
    first = second;
    second = temp;
}
Console.WriteLine();