using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    internal class Program
    {
        static bool IsPalindrom(string text)
        {
            var s = text.Replace(" ", string.Empty);
            s = s.ToLower();
            int lastIndex = s.Length - 1;
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[lastIndex - i])
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите строку для проверки ==> ");
            var text = Console.ReadLine();
            var res = IsPalindrom(text) ? string.Empty : "не ";
            Console.WriteLine($"Строка ==> \"{text}\" {res}является палиндромом");
            Console.ReadLine();
        }
    }
}
