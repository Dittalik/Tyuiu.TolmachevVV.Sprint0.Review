using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TolmachevVV.Sprint0.Review.Lib;

namespace Tyuiu.TolmachevVV.Sprint0.Review
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую переменную: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите вторую переменную: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите третью переменную: ");
            int z = int.Parse(Console.ReadLine());

            Console.WriteLine("Результат выражения (x + y + z) * 5 равен = " + DataService.Calc(x, y, z));
            Console.ReadKey();
        }
    }
}
