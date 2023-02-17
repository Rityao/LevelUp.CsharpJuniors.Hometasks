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
        public Protein(DateTime expirationDate, string name, string description, int nomenclature, int idNumber) : 
            base(expirationDate, name, description, nomenclature, idNumber)
        {
        }

        public override bool HasShelf()
        {
            return true;
        }
    }
}
