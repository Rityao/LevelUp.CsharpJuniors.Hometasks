using Lesson7_1;

Console.WriteLine("Please, write M");
var mString = Console.ReadLine() ?? string.Empty;
var m = int.Parse(mString);

Console.WriteLine("Please, write N");
var nString = Console.ReadLine() ?? string.Empty;
var n = int.Parse(nString);

while (n < m)
{
    Console.WriteLine("Please, enter N bigger than M");
    nString = Console.ReadLine() ?? string.Empty;
    n = int.Parse(nString);
}

List<int> numbers = new();

for (int i = m; i <= n; i++)
    {
        numbers.Add(i);
    }

 _ = new Calculator<int>(numbers);
