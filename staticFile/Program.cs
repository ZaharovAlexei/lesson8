using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace staticFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вручную подготовьте текстовый файл с фрагментом текста.
            //Напишите программу, которая выводит статистику по файлу - количество символов, строк и слов в тексте
            int nString = 0;
            int nWord = 0;
            int nSymbol = 0;
            string nextFile ="G:\\Рабочий стол\\Повышение квалификации\\BIM проектирование\\FileForStatic.txt";
            foreach (string line in File.ReadLines(nextFile))
            {
                Console.WriteLine(line);
                nString++;
                string[] arrayWord = line.Split();
                foreach (string word in arrayWord)
                {
                    nWord++;
                }
                char[] chars = line.ToCharArray();
                foreach(char symbol in chars)
                {
                    nSymbol++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Количество строк: {0}", nString);
            Console.WriteLine("Количество слов: {0}", nWord);
            Console.WriteLine("Количество символов: {0}", nSymbol);
            Console.ReadKey();
        }
    }
}
