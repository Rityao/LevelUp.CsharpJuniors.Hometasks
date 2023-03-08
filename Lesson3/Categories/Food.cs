using Lesson3.Interfaces;

namespace Lesson3.Categories
{
    public abstract class Food : StoreItem, IHasShelfLife
    {
        protected Food(DateTime expirationDate, string name, string description, int nomenclature, int id)
        {
            ExpirationDate = expirationDate;
            Name = name;
            Description = description;
            Nomenclature = nomenclature;
            Id = id;
        }
        public override string? Name { get; set; }
        public override string? Description { get; set; }
        public override int Nomenclature { get; set; }
        public override int Id { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool Expired(DateTime expirationDate)
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