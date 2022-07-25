int a, b;
Console.Write("Enter first number: ");
a = int.Parse(Console.ReadLine());
Console.Write("Enter Second number: ");
b = int.Parse(Console.ReadLine());

Console.WriteLine($"A:{a}::B:{b}");
a = a + b;
b = a - b;
a = a - b;
Console.WriteLine($"A:{a}::B:{b}");

