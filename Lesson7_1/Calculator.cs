using System.Collections;
using System.Security.Cryptography.X509Certificates;
using System.Linq;
namespace Lesson7_1
{
    internal class Calculator<T>
    {
        public Calculator(List<int> numbers)
        {
            int Square(int n) => n * n;
            var array = numbers.Cast<int>().ToArray();
            var squares = from n in array.AsParallel().AsOrdered()
                          where n > 0
                          select Square(n);

            foreach (var f in squares)
                Console.WriteLine("number " + Math.Sqrt(f) + ", square root = " + f);
        }
    }
}