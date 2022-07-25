int decimal_number;
int temp, rem, binary_Number = 0, f = 1;

Console.Write("Enter Decimal Number: ");
decimal_number = int.Parse(Console.ReadLine());

temp = decimal_number;
while (temp != 0)
{
    rem = temp % 2;
    binary_Number = binary_Number + rem * f;
    f = f * 10;
    temp = temp / 2;
}

Console.WriteLine($"Binary Number of {decimal_number} is: {binary_Number}");
