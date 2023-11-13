using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку...");

            var output = Console.ReadLine();
            while (output == string.Empty) 
            {
                Console.WriteLine("Вы ничего не ввели.");
                output = Console.ReadLine();
            }

            Console.WriteLine("Слова, начинающиеся с гласной буквы:");
            DisplayWordsStartingWithVowel(output);

            Console.ReadKey();
        }

        public static void DisplayWordsStartingWithVowel(string output)
        {
            var vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            var words = output.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                var firstLetter = words[i].FirstOrDefault();
                var lowerLetter = char.ToLower(firstLetter);

                if (vowels.Contains(lowerLetter))
                {
                    Console.WriteLine(words[i]);
                }
            }
        }
    }
}
