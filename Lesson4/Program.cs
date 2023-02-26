using Lesson4.Models;

var sgc = new SimpleGenericCache<string>(); // создаём экземпляр класса и тип string будет использоваться этим классом
sgc.Store("1","Cache?"); // вызвали метод Store, третий параметр не задали, поэтому подтянется автоматически таймаут = 30
Console.WriteLine(sgc.Fetch("1")); // выводим информацию о записи кеша

//значение CreationTime задаётся раньше чем сравнивается в методе Fetch (при timeout = 0 -- CreationTime < DateTime.now и значение удаляется)
sgc.Store("2", "Cache2?", 0);
Console.WriteLine(sgc.Fetch("2"));


