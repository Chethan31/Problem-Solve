int n;
Console.Write("Enter a Number:");
n = int.Parse(Console.ReadLine());

int[] array = new int[n];
Console.WriteLine($"Enter {n} Number:");
for (int i = 0; i < n; i++)
{
    array[i]= int.Parse(Console.ReadLine());
}
Console.WriteLine("The array elements are:");
for (int i = 0; i < n; i++)
{
    Console.Write($"{array[i]} ");
}
Console.WriteLine();

int k;
int flag = 0;
Console.Write("Enter a number to be searched:");
k = int.Parse(Console.ReadLine());

for(int i = 0; i < n; i++)
{
    if (array[i] == k)
    {
        flag = 1;
        break;
    }
}

if (flag == 1)
    Console.WriteLine($"{k} is found.");
else
    Console.WriteLine($"{k} is not found.");