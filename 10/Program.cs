int Num;
int reverse_value = 0;
int temp;

Console.Write("Enter a Number:");
Num = int.Parse(Console.ReadLine());

temp = Num;
while (temp != 0)
{
    reverse_value = (reverse_value * 10) + (temp % 10);
    temp = temp / 10;
}

Console.WriteLine($"The Reverse of {Num} is: {reverse_value}");