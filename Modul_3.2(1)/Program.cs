using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_3._2_1_
{
    internal class Class1
    {
        public static void Main(string[] args)
        {
            const string MyNeme = "Макс";
            byte age = 28;
            bool pet = false;
            double size = 42.5;
            Console.WriteLine("My neme is {0}", MyNeme);
            Console.WriteLine("My age is {0}", age);
            Console.WriteLine("Do I have pet? {0}", pet);
            Console.WriteLine("My shoe size is {0}", size);

            Console.WriteLine("\u0023 \u0001");

            Console.ReadKey();
        }
    }
}
