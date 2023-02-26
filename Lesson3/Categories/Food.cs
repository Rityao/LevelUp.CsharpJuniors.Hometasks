using Lesson3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            IdNumber = idNumber;
        }

        public override string? Name { get; set; }
        public override string? Description { get; set; }
        public override int Nomenclature { get; set; }
        public override int IdNumber { get; set; }
        public DateTime ExpirationDate { get; set; }

        public abstract bool HasShelf();
    }
}
