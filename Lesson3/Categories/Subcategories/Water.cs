namespace Lesson3.Categories.Subcategories
{
    sealed internal class Water : Food 
    {
        public Water(DateTime expirationDate, string name, string description, int nomenclature, int idNumber) :
            base(expirationDate, name, description, nomenclature, idNumber)
        {
            IdNumber = 789;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Название бутыли с водой: {Name} , Идентификатор продукта: {IdNumber}");
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