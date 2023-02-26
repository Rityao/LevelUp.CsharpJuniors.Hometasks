// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;

namespace Lesson5
{
    public static class StringExtension
    {
        public static string Clear(this string str)
        {
            str = Regex.Replace(str, "\r\n|\n|\r|\t|\0|\a|\b|\v|\f", ""); // убирает управляющие символы
            str = Regex.Replace(str, @"[^0-9a-zA-Z]", " "); //заменяет на пробел всё, кроме цифр и букв в обоих регистрах
            str = Regex.Replace(str, "\\s+", " "); // заменяет несколько подряд пробелов на один
            
            return str.Trim(); // убирает пробелы в начале и в конце строки
        }
    }
}