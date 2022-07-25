double num;

Console.Write("Enter a Number:");
num = double.Parse(Console.ReadLine());

int n1;
n1 = (int)num;
double n2;
n2 = num - n1;

Console.WriteLine($"First Value:{n1} and Fractional Value:{n2}");



