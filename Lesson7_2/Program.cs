using System.Text;
internal class Program
{
    private static async Task Main(string[] args) 
    {
        Console.WriteLine("Please, write the path of the directory");
        var path = Console.ReadLine() ?? string.Empty;
        try
        {
            var isDirectory = File.GetAttributes(path).HasFlag(FileAttributes.Directory); // проверка, что введён путь директории
            string fileName = @"\Lesson7_2__" + DateTime.Now.ToString("dd_MM_yyyy__HH_mm_ss") + ".txt";
            string fullPath = path + fileName;
            DirectoryInfo di = new(path);
            int i = 0;
            foreach (var fi in di.GetFiles())
            {   
                string fiName = Path.Combine(path,fi.Name); 
                using FileStream fWriteStream = new(fullPath, FileMode.Append);  // запись в файл. если файл существует, то текст добавляется в конец файл. Если файла нет, то он создается
                using FileStream fReadStream = new(fiName, FileMode.Open); //экземпляр для чтения из файла
                byte[] newline = Encoding.UTF8.GetBytes(Environment.NewLine);
                byte[] buffer = new byte[fReadStream.Length]; // выделяем массив для считывания данных из файла
                await fReadStream.ReadAsync(buffer); // считываем данные
                if (i != 0)
                {
                    await fWriteStream.WriteAsync(newline); // нужно разделить данные от файлов
                }
                await fWriteStream.WriteAsync(buffer); // запись массива байтов в файл
                Console.WriteLine($"Текст из файла {fiName} записан");
                i++;
            }

            if (i != 0) // проверка, что в папке были файлы, которые конкатенировались
            {
                using (FileStream fstream = File.OpenRead(fullPath)) // чтение из файла
                {
                    byte[] buffer = new byte[fstream.Length];                     // выделяем массив для считывания данных из файла
                    await fstream.ReadAsync(buffer);                              // считываем данные
                    string textFromFile = Encoding.UTF8.GetString(buffer);     // декодируем байты в строку
                    Console.WriteLine($"Текст из нового файла {fullPath}:\n{textFromFile}");
                }
            }
            else Console.WriteLine($"This directory is empty!)");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine($"The directory was not found. Please, restart the program.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"It`s not a directory!) Please, restart the program.");
        }
    }
}