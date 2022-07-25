int Num;
int temp;
int rev = 0;
int flag = 0;

Console.Write("Enter a Number: ");
Num = int.Parse(Console.ReadLine());

temp = Num;
while (temp != 0)
{
    if (temp % 10 == 0)
    {
        flag = flag + 1;
    }
    rev = (rev * 10) + (temp % 10);
    temp = temp / 10;
}

Console.Write($"{Num} in words:");
while (rev != 0)
{
    temp = rev % 10;
    switch (temp)
    {
        case 0:
            Console.Write(" Zero");
            break;
        case 1:
            Console.Write(" One");
            break;
        case 2:
            Console.Write(" Two");
            break;
        case 3:
            Console.Write(" Three");
            break;
        case 4:
            Console.Write(" Four");
            break;
        case 5:
            Console.Write(" Five");
            break;
        case 6:
            Console.Write(" Six");
            break;
        case 7:
            Console.Write(" Seven");
            break;
        case 8:
            Console.Write(" Eight");
            break;
        case 9:
            Console.Write(" Nine");
            break;
    }
    rev = rev / 10;
}
if (flag != 0)
{
    while (flag != 0)
    {
        Console.Write(" Zero");
        flag--;
    }
}