using Lesson3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3.Models
{
    internal class Food : StoreItem, IHasShelfLife, ExpirationDate
    {
        public override string Name => "Food";

        public DateTime Created { get; set; }
        public DateTime Expired { get; set; }

        public bool HasShelf()
        {
            return true;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"ItemName: ", Name);
        }

        public Food(DateTime created, DateTime expired)
        {
            Created = created;
            Expired = expired;
        }
    }
}
