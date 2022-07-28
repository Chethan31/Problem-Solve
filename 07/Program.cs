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
double net_annual_salary;
char saving_investment;
double tax;

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
Console.Write("Enter Your Saving Investment(Y/N):");
saving_investment = char.Parse(Console.ReadLine());

monthly_salary = basic + special_allowances;
annual_salary = monthly_salary * 12;
bonus = (annual_salary * percentage) / 100;
gross_annual_salary = annual_salary + bonus;

Console.WriteLine();
Console.WriteLine($"Name:{name}");
Console.WriteLine($"Employee ID:{empid}");
Console.WriteLine($"Basic Salary:{basic}");
Console.WriteLine($"Special Allowances:{special_allowances}");
Console.WriteLine($"Bonus Percentage:{percentage}");
Console.WriteLine($"Saving Investment:{saving_investment}");
Console.WriteLine($"Monthly Salary:{monthly_salary}");
Console.WriteLine($"Annual Salary:{annual_salary}");
Console.WriteLine($"Bonus for {percentage}% for annual:{bonus}");
Console.WriteLine($"Gross Annual Salary:{gross_annual_salary}");

if (saving_investment == 'y' || saving_investment == 'Y')
{
    if (annual_salary <= 200000)
    {
        monthly_tax = 0;
        net_annual_salary = gross_annual_salary;
        tax = gross_annual_salary - net_annual_salary;
        Console.WriteLine($"Net Annual Salary:{net_annual_salary}");
        Console.WriteLine($"Tax Payable({monthly_tax}%):{tax}");
    }
    else
    {
        monthly_tax = 20;
        net_annual_salary = gross_annual_salary - (annual_salary * 20) / 100;
        tax = gross_annual_salary - net_annual_salary;
        Console.WriteLine($"Tax Payable({monthly_tax}%):{tax}");
        Console.WriteLine($"Net Annual Salary:{net_annual_salary}");
        
    }
}
else
{
    if (annual_salary <= 100000)
    {
        monthly_tax = 0;
        net_annual_salary = gross_annual_salary;
        tax = gross_annual_salary - net_annual_salary;
        Console.WriteLine($"Tax Payable({monthly_tax}%):{tax}");
        Console.WriteLine($"Net Annual Salary:{net_annual_salary}");
        
    }
    else if (annual_salary > 100000 && annual_salary < 150000)
    {
        monthly_tax = 20;
        net_annual_salary = gross_annual_salary - (annual_salary * 20) / 100;
        tax = gross_annual_salary - net_annual_salary;
        Console.WriteLine($"Tax Payable({monthly_tax}%):{tax}");
        Console.WriteLine($"Net Annual Salary:{net_annual_salary}");
    }
    else if (annual_salary > 150000)
    {
        monthly_tax = 30;
        net_annual_salary = gross_annual_salary - (annual_salary * 30) / 100;
        tax = gross_annual_salary - net_annual_salary;
        Console.WriteLine($"Tax Payable({monthly_tax}%):{tax}");
        Console.WriteLine($"Net Annual Salary:{net_annual_salary}");
    }
}






