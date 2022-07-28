int item_code;
string description;
int quantity;
int price;
char choice;
int no_of_items=0;
int total_price=0;
double Grand_price;
char choice1;

do
{
    Console.Write("Enter the item code:");
    item_code = int.Parse(Console.ReadLine());

    Console.Write("Enter the Description:");
    description = Console.ReadLine();

    Console.Write("Enter the Quantity:");
    quantity = int.Parse(Console.ReadLine());

    Console.Write("Enter the Price:");
    price = int.Parse(Console.ReadLine());

    Console.WriteLine();

    Console.WriteLine($"Item code:{item_code}");
    Console.WriteLine($"Description:{description}");
    Console.WriteLine($"Quantity:{quantity}");
    Console.WriteLine($"Price:{price}");

    total_price = total_price + price;
    no_of_items++;

    Console.WriteLine($"No of Items:{no_of_items}");
    Console.WriteLine($"Total Price:{total_price}");
    Console.WriteLine();

    Console.Write("Enter y/n for add item:");
    choice = char.Parse(Console.ReadLine());
    Console.WriteLine();

} while(choice == 'y' || choice=='Y');

if (total_price > 10000)
{
    Console.WriteLine("Discount:10%");
    Grand_price = total_price - (total_price * 0.1);
    Console.WriteLine($"Grand Price: {Grand_price}");
}
else if(total_price < 1000)
{
    Console.Write("Enter y/n for pay by card:");
    choice1 = char.Parse(Console.ReadLine());
    if(choice1 == 'y' || choice1 == 'Y')
    {
        Console.WriteLine("Surcharge(Extra):2.5%");
        Grand_price = total_price + (total_price * 0.025);
        Console.WriteLine($"Grand Price: {Grand_price}");
    }
    else
        Console.WriteLine($"Grand Price: {total_price}");
}
else
    Console.WriteLine($"Grand Price: {total_price}");