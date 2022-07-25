int binary_Number;
int temp, rem, i = 0;
long decimal_number = 0;


Console.Write("Enter Decimal Number: ");
binary_Number = int.Parse(Console.ReadLine());

temp = binary_Number;
while (temp != 0)
{
    rem = temp % 10;
    temp = temp / 10;
    decimal_number = decimal_number + rem * (int)Math.Pow(2, i);
    i++;
}

Console.WriteLine($"Decimal Number of {binary_Number} is: {decimal_number}");
