﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3.Categories.Subcategories
{
    sealed internal class Protein : Food
    {
        public Protein(DateTime expirationDate, string name, string description, int nomenclature, int idNumber) : 
            base(expirationDate, name, description, nomenclature, idNumber)
        {
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Название батончика: {Name}");
        }

        public override bool HasShelf()
        {
            return true;
        }
    }
}
