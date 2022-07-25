int n, m, l = 0;
int sum = 0;
int flag;

Console.WriteLine("Enter the range of prime numbers:");
n = int.Parse(Console.ReadLine());
m = int.Parse(Console.ReadLine());

Console.Write("Prime Numbers are: ");
for (int j = n; j <= m; j++)
{
    flag = 0;
    l = j / 2;
    for (int i = 2; i <= l; i++)
    {
        if ((j % i) == 0)
        {
            flag = 1;
            break;
        }
    }
    if (flag == 0)
    {
        Console.Write($"{j} ");
        sum = sum + j;
    }
}
Console.Write($"\nThe Sum of all the Prime Numbers in the range {n} to {m} is: {sum} ");



