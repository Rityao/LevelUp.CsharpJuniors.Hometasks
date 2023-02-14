using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    public abstract class StoreItem
    {
        public abstract string Name { get; }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Item name:", Name);
        }
    }
}
