int N;
int sum = 0;

Console.Write("Enter N Value:");
N = int.Parse(Console.ReadLine());

for (int i = 1; i <= N; i++)
{
    if ((i % 2) != 0)
        sum = sum + i;
}

Console.WriteLine($"Sum of all odd Numbers from 1 to {N} is: {sum}");