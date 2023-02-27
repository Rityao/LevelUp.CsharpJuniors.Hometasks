namespace Lesson3.Categories
{
    internal abstract class Souvenirs : StoreItem
    {
        public override string? Name { get; set; }
        public override string? Description { get; set; }
        public override int IdNumber { get; set; }
        public override int Nomenclature { get; set; }
    }
}
