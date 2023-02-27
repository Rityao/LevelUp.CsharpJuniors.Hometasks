namespace Lesson7_1
{
    internal class Calculator<T>
    {   
        public Calculator(List<int> numbers) 
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                double sroot;
                sroot = Math.Sqrt(numbers[i]);
                Console.WriteLine("number " + numbers[i] + ", square root = " + sroot);
            }
        }
    }
}