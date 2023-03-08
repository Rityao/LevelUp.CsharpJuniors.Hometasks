namespace Lesson3.Categories.Subcategories
{
    sealed internal class Water : Food 
    {
        public Water(DateTime expirationDate, string name, string description, int nomenclature, int id) :
            base(expirationDate, name, description, nomenclature, id)
        {
            Id = 789;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Название бутыли с водой: {Name} , Идентификатор продукта: {Id}");
        }
    }
}