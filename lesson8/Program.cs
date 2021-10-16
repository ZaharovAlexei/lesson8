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

            string[] dirs = Directory.GetDirectories("G:\\");
            foreach (string s in dirs)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
