using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lesson3.Categories
{
    internal class Equipment : StoreItem
    {
        public override string? Name { get; set; }
        public override string? Description { get; set; }
        public override int IdNumber { get; set; }
        public override int Nomenclature { get; set; }

    }
}
