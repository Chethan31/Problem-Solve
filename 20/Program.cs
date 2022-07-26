int x, n;
int temp,pow=1;

Console.WriteLine("Enter the base and power:");
x = int.Parse(Console.ReadLine());
n = int.Parse(Console.ReadLine());

temp = n;
while (temp != 0)
{
    pow = pow * x;
    temp--;
}

Console.WriteLine($"{x} to the power of {n} is: {pow}");