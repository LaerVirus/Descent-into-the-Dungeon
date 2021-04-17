using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mods1
{
    class proverka
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение хп: ");
            Console.WriteLine("Введите значение брони : ");
            Console.WriteLine("Введите значение скорости : ");
            Console.WriteLine("Введите значение интеллекта : ");
            Console.WriteLine("Введите значение урона : ");            
            Items items1 = new Items(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            items1.Print();
            items1.itemsmenu();
            Console.ReadKey();
        }
    }
}
