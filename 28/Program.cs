int n,m;
Console.Write("Enter number of rows:");
m = int.Parse(Console.ReadLine());
Console.Write("Enter number of columns:");
n = int.Parse(Console.ReadLine());


int[,] array = new int[m,n];
Console.WriteLine($"Enter matrix elements for {m}*{n}:");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i,j] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine("Martix elements are:");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}

Console.WriteLine("Transpose martix elements are:");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"{array[j, i]} ");
    }
    Console.WriteLine();
}