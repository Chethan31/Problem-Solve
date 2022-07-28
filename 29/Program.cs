int n, m;
Console.Write("Enter number of rows:");
m = int.Parse(Console.ReadLine());
Console.Write("Enter number of columns:");
n = int.Parse(Console.ReadLine());


int[,] array = new int[m, n];
Console.WriteLine($"Enter matrix elements for {m}*{n}:");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = int.Parse(Console.ReadLine());
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

Console.WriteLine();
if (m == n)
{
	int flag = 0;
	for (int i = 0; i < m; i++)
	{
		for (int j = 0; j < n; j++)
		{
			if (i == j && array[i, j] != 1)
			{
				flag = -1;
				break;
			}
			else if (i != j && array[i, j] != 0)
			{
				flag = -1;
				break;
			}
		}
	}

	if (flag == 0)
	{
		Console.WriteLine("It is an Identity matrix\n");
	}
	else
	{
		Console.WriteLine("It is not an Identity matrix\n");
	}
}
else
{
	Console.WriteLine("It is not an Identity matrix\n");
}