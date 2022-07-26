int rate, hours, hardware, software, external_consultant;
int client_software, client_hardware;
int ip;
int cost = 0;

Console.Write("Enter the rate per hour:");
rate=int.Parse(Console.ReadLine());
Console.Write("Enter the number of hours:");
hours=int.Parse(Console.ReadLine());
Console.Write("Enter the Cost of hardware:");
hardware =int.Parse(Console.ReadLine());
Console.Write("Enter the Cost of software:");
software = int.Parse(Console.ReadLine());
Console.Write("Enter the hours of external consultant:");
external_consultant =int.Parse(Console.ReadLine());
Console.Write("Vendor goes loss for hardware (yes/no || 1/0):");
client_hardware =int.Parse(Console.ReadLine());
Console.Write("Vendor goes loss for software (yes/no || 1/0):");
client_software =int.Parse(Console.ReadLine());

ip = (rate * hours) + hardware + software + (external_consultant * hours);

if (client_hardware == 0 && client_software == 0)
    cost = (rate * hours) + hardware + software + (external_consultant * hours);
else if (client_software == 0 && client_software == 1)
    cost = (rate * hours) + hardware*(3/10) + software + (external_consultant * hours);
else if (client_software == 1 && client_software == 0)
    cost = (rate * hours) + hardware + software/2 + (external_consultant * hours);
else if (client_software == 1 && client_software == 1)
    cost = (rate * hours) + hardware*(3/10) + software/2 + (external_consultant * hours);

Console.WriteLine($"Cost: {cost}");

if (cost > ip)
    Console.WriteLine("Loss");
else
    Console.WriteLine("Profit");