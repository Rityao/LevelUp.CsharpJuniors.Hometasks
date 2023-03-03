namespace Lesson3.Categories.Subcategories
{
    sealed internal class Protein : Food
    {
        public Protein(DateTime expirationDate, string name, string description, int nomenclature, int idNumber) : 
            base(expirationDate, name, description, nomenclature, idNumber)
        {
            // Name = "БАТОНЧИК!";
            IdNumber = 123; // перезапишет IdNumber из Program.cs
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Название батончика: {Name} , Идентификатор продукта: {IdNumber}");
        }
        public override bool HasShelf()
        {
            return true;
        }
        public override bool Expired(DateTime expirationDate)
        {
            DateTime today = DateTime.Today;
            if (today > expirationDate)
            {
                Console.WriteLine("Срок годности вышел");
                return true;
            }
            else
                Console.WriteLine("Срок годности не вышел");
                return false;
        }
    }
}