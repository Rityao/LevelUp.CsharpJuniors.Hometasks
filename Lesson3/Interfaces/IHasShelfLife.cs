namespace Lesson3.Interfaces
{
    internal interface IHasShelfLife
    {
        bool HasShelf();
        public DateTime ExpirationDate { get; set; }  
        bool Expired(DateTime expirationDate);
    }
}