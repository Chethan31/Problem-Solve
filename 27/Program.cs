int n;
Console.Write("Enter a Number:");
n = int.Parse(Console.ReadLine());

int[] array = new int[n];
Console.WriteLine($"Enter {n} Number:");
for (int i = 0; i < n; i++)
{
    array[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("The array elements are:");
for (int i = 0; i < n; i++)
{
    Console.Write($"{array[i]} ");
}
Console.WriteLine();

int temp;
for (int i = 0; i < n; i++)
{
    for (int j = i+1; j < n; j++)
    {
        if (array[i] > array[j])
        {
            temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
Console.WriteLine("The array elements after sorting:");
for (int i = 0; i < n; i++)
{
    Console.Write($"{array[i]} ");
}
Console.WriteLine();

int k;
int flag = 0;
Console.Write("Enter a number to be searched:");
k = int.Parse(Console.ReadLine());

int min = 0;
int max = n - 1;
while(min <= max)
{
    int mid = (min + max) / 2;
    if (k == array[mid])
    {
        flag = 1;
        break;
    }
    else if (array[mid] < k)
        min = mid + 1;
    else
        max = mid - 1;
}

if (flag == 1)
    Console.WriteLine($"{k} is found.");
else
    Console.WriteLine($"{k} is not found.");
