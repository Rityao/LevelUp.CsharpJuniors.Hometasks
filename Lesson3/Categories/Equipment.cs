using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lesson3.Models
{
    internal class Equipment : StoreItem
    {
        public override string Name => "Equipment";

        public override void PrintInfo()
        {
            Console.WriteLine($"ItemName: ", Name);
        }
    }
}
