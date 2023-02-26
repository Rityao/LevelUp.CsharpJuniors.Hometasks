﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3.Categories.Subcategories
{
    sealed internal class Water : Food 
    {
        public Water(DateTime expirationDate, string name, string description, int nomenclature, int idNumber) :
            base(expirationDate, name, description, nomenclature, idNumber)
        {

        }

        public override bool HasShelf()
        {
           return true;
        }
    }
}
