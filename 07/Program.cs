string name;
string empid;
int basic;
int special_allowances;
int percentage;
int monthly_tax;
int monthly_salary;
int annual_salary;
int gross_annual_salary;
int bonus;
int annual_net_salary;

Console.Write("Enter Your Name:");
name = Console.ReadLine();
Console.Write("Enter Your Employee ID:");
empid = Console.ReadLine();
Console.Write("Enter Your Basic Salary:");
basic = int.Parse(Console.ReadLine());
Console.Write("Enter Your Special Allowances:");
special_allowances = int.Parse(Console.ReadLine());
Console.Write("Enter Your Percentage of bonus:");
percentage = int.Parse(Console.ReadLine());
Console.Write("Enter Your Monthly Tax:");
monthly_tax = int.Parse(Console.ReadLine());

monthly_salary = basic + special_allowances;
Console.WriteLine($"Month Salary:{monthly_salary}");
annual_salary = monthly_salary * 12;
Console.WriteLine($"Annual Salary:{annual_salary}");
bonus = (annual_salary * percentage) / 100;
Console.WriteLine($"Bonus for {percentage}% for annual:{bonus}");
gross_annual_salary = annual_salary + bonus;
Console.WriteLine($"Gross Annual Salary:{gross_annual_salary}");






