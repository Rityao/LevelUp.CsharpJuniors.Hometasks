using System.Collections;
using System.Security.Cryptography.X509Certificates;
using System.Linq;
using System;

namespace Lesson7_1
{
    class Calculator<T>
    {
        private int[]? array;
        public List<int> Numbers { get; }

        public Calculator(List<int> numbers)
        {
            Numbers = numbers;
        }

        public void Calculate(List<int> numbers)
        {
            array = numbers.Cast<int>().ToArray();

            static int Square(int n) => n * n;
            var squares = from n in array.AsParallel().AsOrdered()
                          where n > 0
                          select Square(n);

            foreach (var f in squares)
                Console.WriteLine("number " + Math.Sqrt(f) + ", square root = " + f);
            
        }    
    }
}