using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_task
{
    class NOD_NOK
    {
        //main
        //поиск НОД и НОК 2-ух чисел
        public static void search_nod_nok ()
        {
            long x, y;
            Console.Write("Введите первое число: ");
            x = long.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            y = long.Parse(Console.ReadLine());
            Console.WriteLine("Наибольший общий делитель чисел {0} и {1} = {2}", x, y, nod(x, y));
            Console.WriteLine("Наименьшее общее кратное чисел {0} и {1} = {2}", x, y, nok(x, y));
        }
        static long nod(long x, long y)
        {
            while (y != 0)
            {
                long temp = y;
                y = x % y;
                x = temp;
            }
            return x;
        }
        static long nok(long x, long y)
        {
            return (x * y) / nod(x, y);
        }

    }
}
