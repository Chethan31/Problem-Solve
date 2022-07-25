int num;
int fact = 1;

Console.Write("Enter a Number: ");
num = int.Parse(Console.ReadLine());

if (num >= 0)
{
    for (int i = 1; i <= num; i++)
        fact = fact * i;
    Console.WriteLine($"The factorial of {num} is: {fact}");
}
else
{
    Console.WriteLine("Factorial of a negative number is not possible.");
}