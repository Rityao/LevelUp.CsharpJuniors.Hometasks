namespace Lesson3.Interfaces
{
    internal interface IHasShelfLife
    {
        public DateTime ExpirationDate { get; set; }  
        bool Expired(DateTime expirationDate);
    }
}