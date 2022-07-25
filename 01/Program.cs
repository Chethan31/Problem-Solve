int principle, rate_of_interset;
int time;
int SI;

Console.Write("Enter Principle: ");
principle = int.Parse(Console.ReadLine());
Console.Write("Enter Time: ");
time = int.Parse(Console.ReadLine());
Console.Write("Enter Rate of Interest: ");
rate_of_interset = int.Parse(Console.ReadLine());

//Console.WriteLine($"Principle: {principle} Time:{time} Rate of interest: {rate_of_interset}");
SI = (principle * time * rate_of_interset) / 100;

Console.WriteLine($"Simple Interest: {SI}");