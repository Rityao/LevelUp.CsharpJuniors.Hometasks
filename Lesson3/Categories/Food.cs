using Lesson3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3.Models
{
    internal class Food : StoreItem, IHasShelfLife
    {
        public override string Name => "Food";

        public bool HasShelf()
        {
            return true;
        }
    }
}
