int a, b, c;
int first_largest;
int second_largest;
int temp;
Console.Write("Enter first number: ");
a = int.Parse(Console.ReadLine());
Console.Write("Enter Second number: ");
b = int.Parse(Console.ReadLine());
Console.Write("Enter Third number: ");
c = int.Parse(Console.ReadLine());

first_largest = a;
second_largest = b;

if (first_largest < second_largest)
{
    temp = first_largest;
    first_largest = second_largest;
    second_largest = temp;
}
if (first_largest < c)
{
    second_largest = first_largest;
    first_largest = c;
}
else if (second_largest < c)
{
    second_largest = c;
}

Console.WriteLine($"First Largest:{first_largest} \nSecond Largest:{second_largest}");