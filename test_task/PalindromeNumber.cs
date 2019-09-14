using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_task
{
    class PalindromeNumber
    {
        //поиск числа-палиндрома
        public static void search()
        {
            //main
            Console.Write("Введите число N для последовательности от 0 до ");
            search_num(int.Parse(Console.ReadLine()));
        }
        static int ReverseInt(int num)
        {
            int result = 0;
            while (num > 0)
            {
                result = result * 10 + num % 10;
                num /= 10;
            }
            return result;
        }
        static void search_num(int count)
        {
            int num = 0, dig, rev;
            for (int i = 0; i < count; i++)
            {
                rev = 0;
                num = i;
                while (num > 0)
                {
                    dig = num % 10;
                    rev = rev * 10 + dig;
                    num = num / 10;
                }
                if (i == rev)
                    Console.WriteLine("Число {0} - палиндром", i);
            }
        }
    }
}
