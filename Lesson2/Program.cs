using LevelUp.CsharpJuniors.Hometasks.Lesson2.Hometasks.Models;

// First task
Console.WriteLine("Hello! Please, write your name and the address of your favourite store:");
Console.WriteLine("The name:");
var name = Console.ReadLine() ?? string.Empty;

Console.WriteLine("The address:");
var address = Console.ReadLine() ?? string.Empty;

var store = new Store(name, address);
store.PrintInfo();

// Second task
Console.WriteLine("");
Console.WriteLine("Now, write some information about you:");
Console.WriteLine("Your name:");
var customer_name = Console.ReadLine() ?? string.Empty;
while (string.IsNullOrEmpty(customer_name))
{
    Console.WriteLine("Please, enter your name");
    customer_name = Console.ReadLine() ?? string.Empty;
}
Console.WriteLine("Your surname:");
var surname = Console.ReadLine() ?? string.Empty;
while (string.IsNullOrEmpty(surname))
{
    Console.WriteLine("Please, enter your surname");
    surname = Console.ReadLine() ?? string.Empty;
}

Console.WriteLine("Your age:");
int age;
int proverka = 0;
do
{
    var string_age = Console.ReadLine() ?? string.Empty;
    while (!int.TryParse(string_age, out age))
    {
        if (string.IsNullOrEmpty(string_age))
        {
            Console.WriteLine("Please, enter your age");
        }
        else
        {
            Console.WriteLine("Please, enter the valid age.It should be a number.Try again:");
        }
        string_age = Console.ReadLine() ?? string.Empty;
    }
    if (age <= 0 || age > 150)
    {
        Console.WriteLine("Please, enter the valid age between 1 and 150");
    }
    else
    {
        proverka++;
    }
}
while (proverka == 0);

Console.WriteLine("Some words about your hobby:");
var hobby = Console.ReadLine() ?? string.Empty;
while (string.IsNullOrEmpty(hobby))
{
    Console.WriteLine("Please, enter some words");
    hobby = Console.ReadLine() ?? string.Empty;
}

var customer = new Customer(customer_name, surname, age, hobby);
customer.PrintInfo();
