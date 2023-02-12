namespace LevelUp.CsharpJuniors.Hometasks.Lesson2.Hometasks.Models
{
    internal class Customer
    {
        public Customer(string customer_name, string surname, int age, string hobby)
        {
            CustomerName = customer_name;
            Surname = surname;
            Age = age;
            Hobby = hobby;
        }
        public string CustomerName { get; }
        public string Surname { get; }
        public int Age { get; }
        public string Hobby { get; }
        internal void PrintInfo()
        {
            Console.WriteLine("");
            Console.WriteLine($"Name: {CustomerName}");
            Console.WriteLine($"Surname: {Surname}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Hobby: {Hobby}");
        }
    }
}