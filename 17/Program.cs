int val;
int j = 1;
int k = 1;
int x = 1;
int flag;

Console.WriteLine("The 1st, 2nd, 3rd and 4th multiple of 7 which gives the reminder 1 when divided by 2,3,4,5 and 6 are:");
while(j<1000)
{
    while (x<=4) 
    {
        k = j * 7;
        flag = 0;
        for (int i = 2; i <= 6; i++)
        {
            val = k % i;
            if (val == 1)
            {
                flag = flag + 1;
                if (flag == 5)
                {
                    Console.WriteLine($"Number({x}):{k}");
                    x++;
                }
            }
        }
        j++;
    }
} 