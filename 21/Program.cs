string a;
string b;

Console.Write("Enter the String: ");
a=Console.ReadLine();

b = string.Empty;
int len=a.Length;

for (int i = len - 1; i >= 0; i--)
{
    b=b+a[i];
}
Console.Write($"Reverse String of ({a}) is : {b} ");

