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
            /*const string MyNeme = "Макс";
            byte age = 28;
            bool pet = false;
            double size = 42.5;
            Console.WriteLine("My neme is {0}", MyNeme);
            Console.WriteLine("My age is " + age);
            Console.WriteLine("Do I have pet? {0}", pet);
            Console.WriteLine($"My shoe size is {size}");
            Console.WriteLine("Byte max = {0}", byte.MaxValue);*/

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            byte age = checked((byte) int.Parse(Console.ReadLine()));
            Console.WriteLine("Your name is {0} and age is {1}", name, age);
            Console.Write("What is your favorite day of week ");
            DayOfWeek day = (DayOfWeek) int.Parse(Console.ReadLine());
            Console.WriteLine("Your faworite day is {0}", day);          
            
            
            Console.WriteLine("\u0023 \u0001");

            Console.ReadKey();
        }
    }
}

enum semafor
{
    Red = 100,
    Green = 200,
    Blue = 300
}
enum DayOfWeek
{
    Mondey = 1,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturedey,
    Sundey
}