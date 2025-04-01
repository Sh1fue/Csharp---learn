using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prikol
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Введите число вклада");
            int Vklad = Convert.ToInt32(Console.ReadLine());

            if (Vklad < 100)
            {
                Console.WriteLine($" Ваш вклад {Vklad} + С бонусами {Vklad + Vklad * 0.05}");
            }
            else if (Vklad >= 100 && Vklad <= 200)
            {
                Console.WriteLine($"Ваш вклад {Vklad} + С бонусами {Vklad + Vklad * 0.07}");
            }
            else if (Vklad > 200)
            {
                Console.WriteLine($"Ваш вклад {Vklad} + С бонусами {Vklad + Vklad * 0.1}");
            }

        }
    }
}
