using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    public abstract class StoreItem
    {
        public abstract string? Name { get; set; }
        public abstract string? Description { get; set; }
        public abstract int Nomenclature { get; set; }
        public abstract int IdNumber { get; set; }

    }
}
