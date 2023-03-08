using System.Text;
internal class Program
{
    private static async Task Main(string[] args) 
    {
        Console.WriteLine("Please, write the path of the directory");
        var path = Console.ReadLine() ?? string.Empty;
        string fileName = @"\Lesson7_2__"+ DateTime.Now.ToString("dd_MM_yyyy__HH_mm_ss") +".txt";
        string fullPath = path + fileName;
        try 
        {
            DirectoryInfo di = new(path);
            int i = 0;
            foreach (var fi in di.GetFiles())
            {   
                string fiName = Path.Combine(path,fi.Name); 
                using FileStream fstream = new(fullPath, FileMode.Append);  // запись в файл. если файл существует, то текст добавляется в конец файл. Если файла нет, то он создается
                using FileStream fstreamR = new(fiName, FileMode.Open); //экземпляр для чтения из файла
                byte[] newline = Encoding.ASCII.GetBytes(Environment.NewLine);
                byte[] buffer = new byte[fstreamR.Length]; // выделяем массив для считывания данных из файла
                await fstreamR.ReadAsync(buffer); // считываем данные
                if (i != 0)
                {
                    await fstream.WriteAsync(newline); // нужно разделить данные от файлов
                }
                await fstream.WriteAsync(buffer); // запись массива байтов в файл
                Console.WriteLine($"Текст из файла {fiName} записан");
                i++;
            }
            
            using (FileStream fstream = File.OpenRead(fullPath)) // чтение из файла
            {
                byte[] buffer = new byte[fstream.Length];                     // выделяем массив для считывания данных из файла
                await fstream.ReadAsync(buffer);                              // считываем данные
                string textFromFile = Encoding.Default.GetString(buffer);     // декодируем байты в строку
                Console.WriteLine($"Текст из нового файла {fullPath}:\n{textFromFile}");
            }
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine($"The directory was not found. Please, restart the program.");
        }
    }
}