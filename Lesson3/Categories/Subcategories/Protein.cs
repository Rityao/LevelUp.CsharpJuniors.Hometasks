using Lesson3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3.Categories.Subcategories
{
    internal class Protein : Food
    {
        public new string Name { get; set; }
        public string Description { get; set; }
        public string Size { get; set; }
        public Protein(string name, string descr, string size) {
            Name = name;
            Description = descr;
            Size = size;
        }
    }
}
