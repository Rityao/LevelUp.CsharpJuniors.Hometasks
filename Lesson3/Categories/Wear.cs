namespace Lesson3.Categories
{
    internal abstract class Wear : StoreItem
    {
        public override string? Name { get; set; }
        public override string? Description { get; set; }
        public override int Id { get; set; }
        public override int Nomenclature { get; set; }
    }
}
