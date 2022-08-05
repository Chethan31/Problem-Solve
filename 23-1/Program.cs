int count = 0;
int N;
int value=800;
int sum = 0;
int temp;
int flag;
List<int> list1 = new List<int>();
List<int> list2 = new List<int>();

Console.WriteLine("Enter N Value:");
N=int.Parse(Console.ReadLine());
Console.WriteLine("The series is:");
for(int i=0; value<N; i++)
{   
    value = value + (2*i);
    if (value < N)
    {
        list1.Add(value);
        temp = value;
        sum = 0;
        flag = 0;
        while (temp != 0)
        {
            sum = sum + temp % 10;
            temp = temp / 10;
        }
        list2.Add(sum);
        while (sum != 0)
        {
            if (sum % 10 == 1)
            {  
                if(flag==0)
                    count++;
                flag= 1;
            }
            sum = sum / 10;  
        } 
    }
}
//int[] arr = list.ToArray();

foreach(int i in list1)
{
    Console.Write($"{i} ");
}
Console.WriteLine();
foreach (int i in list2)
{
    Console.Write($"{i} ");
}
Console.WriteLine();
Console.WriteLine($"The count of the sum numbers which have the digit 1:{count}");


