namespace Lesson3.Categories.Subcategories
{
    sealed internal class Protein : Food
    {
        public Protein(DateTime expirationDate, string name, string description, int nomenclature, int id) : 
            base(expirationDate, name, description, nomenclature, id)
        {
            // Name = "БАТОНЧИК!";
            Id = 123; // перезапишет IdNumber из Program.cs
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Название батончика: {Name} , Идентификатор продукта: {Id}");
        }
    }
}