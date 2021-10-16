using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace directory
{
    class Program
    {
        static void Main(string[] args)
        {
            //Выберите любую папку на своем компьютере, имеющую вложенные директории.
            //Выведите на консоль ее содержимое и содержимое всех подкаталогов.

            string[] dirs = Directory.GetDirectories("G:\\Music");
            string[] files = Directory.GetFiles("G:\\Music");
            
            foreach (string s in dirs)
            {
                Console.WriteLine(s);
                string[] dirs2 = Directory.GetDirectories(s);
                foreach (string s2 in dirs2)
                {
                    Console.WriteLine("   {0}",s2);
                }
                string[] files2 = Directory.GetFiles(s);
                foreach (string s2 in files2)
                {
                    Console.WriteLine("   {0}",s2);
                }
            }
            Console.WriteLine();
            foreach (string s in files)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
