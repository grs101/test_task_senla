using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_task
{
    class NumberCheck
    {
        //проверка числа
        public static void check_num ()
        {
            //main
            Console.Write("Введите число - ");
            double num = double.Parse(Console.ReadLine());
            if (isWhole(num))
            {
                Console.WriteLine("Число целое");
                check_even_num(num);
                isPrimeAndComposite(num);
            }
            else
            {
                Console.WriteLine("Ошибка! Число не целое");
            }
        }

        //проверка на простое/составное
        static bool isPrimeAndComposite (double n)
        {
            if (n == 1) // 1 - не простое число
                return false;
            // перебираем возможные делители от 2 до sqrt(n)
            for (int i = 2; i*i <= n; i++)
            {
                // если разделилось нацело, то составное
                if (n % i == 0)
                {
                    Console.WriteLine("Составное число");
                    return false;
                }
            }
            // если нет нетривиальных делителей, то простое
            Console.WriteLine("Простое число");
            return true;
        }

        //проверка на четность
        static void check_even_num (double num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine("Число четное");
            }
            else
                Console.WriteLine("Число нечетное");
        }

        //целое/нецелое
        public static bool isWhole (double num)
        {
            if (num % 1 != 0)
                return false;
            else
                return true;
        }
    }
}
