using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace sumInFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Программно создайте текстовый файл и запишите в него 10 случайных чисел.
            //Затем программно откройте созданный файл, рассчитайте сумму чисел в нем, ответ выведите на консоль.
            string newFile = "G:\\Рабочий стол\\Повышение квалификации\\BIM проектирование\\sumInFile.txt";
            if (!File.Exists(newFile))
            {
                File.Create(newFile);
            }
            Random random = new Random();
            int s = 0;
            using (StreamWriter stream = new StreamWriter(newFile))
            {
                int[] array = new int[10];
                for (int i = 0; i < 10; i++)
                {
                    array[i] = random.Next(0, 999);
                    stream.WriteLine("{0}",array[i]);                    
                }
            }
            using (StreamReader sr = new StreamReader(newFile, Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    s += Convert.ToInt32(line);
                }
            }
            Console.WriteLine("Сумма чисел равна = {0}",s);
            Console.ReadKey();
        }
    }
}
