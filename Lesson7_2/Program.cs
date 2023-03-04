﻿using System.IO;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

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
            foreach (var fi in di.GetFiles())
            {
                using FileStream fstream = new(fullPath, FileMode.Append);  // запись в файл. если файл существует, то текст добавляется в конец файл. Если файла нет, то он создается
                await string? text = File.ReadAllText(path + "\\" + fi.Name);
                //using FileStream fstreamR = new(path + "\\" + fi.Name, FileMode.Open);
                //byte[] buffer = new byte[fstreamR.Length]; // выделяем массив для считывания данных из файла
                //await fstreamR.ReadAsync(buffer); // считываем данные
                byte[] buffer = Encoding.Default.GetBytes(text + "\n");
                await fstream.WriteAsync(buffer);                       // запись массива байтов в файл
                 
                Console.WriteLine($"Текст из файла {path + "\\" + fi.Name} записан");
            }
            
            using (FileStream fstream = File.OpenRead(fullPath)) // чтение из файла
            {
                byte[] buffer = new byte[fstream.Length];                     // выделяем массив для считывания данных из файла
                await fstream.ReadAsync(buffer);                              // считываем данные
                string textFromFile = Encoding.Default.GetString(buffer);     // декодируем байты в строку
                Console.WriteLine($"Текст из файла {fullPath}:\n{textFromFile}");
            }
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine($"The directory was not found. Please, restart this program.");
        }
    }
}