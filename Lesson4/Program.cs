using Lesson4.Models;

var sgc = new SimpleGenericCache<string>();
sgc.Store("1","Cache?");
Console.WriteLine(sgc.Fetch("1"));

//значение CreationTime задаётся раньше чем сравнивается в методе Fetch (при timeout = 0 -- CreationTime < DateTime.now и значение удаляется)
sgc.Store("2", "Cache2?", 0);
Console.WriteLine(sgc.Fetch("2"));


