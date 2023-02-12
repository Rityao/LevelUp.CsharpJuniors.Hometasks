namespace LevelUp.CsharpJuniors.Hometasks.Lesson2.Hometasks.Models
{
    internal class Store
    {
        public Store(string name, string address)
        {
            Name = name;
            Address = address;
        }
        public string Name { get; }
        public string Address { get; }
        internal void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}, Address: {Address}");
        }
    }
}