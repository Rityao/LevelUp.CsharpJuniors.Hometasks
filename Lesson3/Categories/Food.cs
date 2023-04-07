using Lesson3.Interfaces;

namespace Lesson3.Categories
{
    public abstract class Food : StoreItem, IHasShelfLife
    {
        protected Food(DateTime expirationDate, string name, string description, int nomenclature, int idNumber)
        {
            ExpirationDate = expirationDate;
            Name = name;
            Description = description;
            Nomenclature = nomenclature;
            Id = idNumber;
        }
        public DateTime ExpirationDate { get; set; }
        public abstract bool Expired(DateTime expirationDate);
        public abstract bool HasShelf();
    }
}