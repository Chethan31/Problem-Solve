int sub1, sub2, sub3;
string name;
int avg, total;

Console.Write("Enter your Name:");
name = Console.ReadLine();
Console.Write("First subject Marks:");
sub1 = int.Parse(Console.ReadLine());
Console.Write("Second subject Marks:");
sub2 = int.Parse(Console.ReadLine());
Console.Write("Third subject Marks:");
sub3 = int.Parse(Console.ReadLine());

total = sub1 + sub2 + sub3;
avg = total / 3;

Console.WriteLine($"Total Score:{total}");
Console.WriteLine($"Average of 3 subject:{avg}");

if (avg >= 60)
    Console.WriteLine($"{name} is 1st class.");
else if (avg >= 50)
    Console.WriteLine($"{name} is 2nd class.");
else if (avg >= 35)
    Console.WriteLine($"{name} is Pass class.");
else
    Console.WriteLine($"{name} is Fail.");


