string a;
string b;
int flag = 0;

Console.Write("Enter the String: ");
a = Console.ReadLine();

int len = a.Length-1;

for (int i = 0; i < a.Length/2; i++)
{
    if(a[i] != a[len])
    {
        flag = 1;
        Console.Write($"{a} is not a palindrome.");
        break;
    }
    len--;
}
if (flag==0)
    Console.Write($"{a} is a palindrome.");
