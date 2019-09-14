using System;
using System.Text.RegularExpressions;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_task
{
    class Program
    {
        static void Main(string[] args)
        {
            //launch main
            Console.OutputEncoding = Encoding.GetEncoding(866);
            Console.WriteLine("Welcome!");
            try
            {
                begin();
            }
            catch (FormatException)
            {
                Console.WriteLine("Data format error!");
            }
            catch
            {
                Console.WriteLine("Error!");
            }
        }
        static void func_cases(int num)
        {
            switch(num)
            {
                case 1:
                    NumberCheck.check_num();
                    begin();
                    break;
                case 2:
                    NOD_NOK.search_nod_nok();
                    begin();
                    break;
                case 3:
                    WordsInStr.search();
                    begin();
                    break;
                case 4:
                    WordSearch.search();
                    begin();
                    break;
                case 5:
                    PalindromeNumber.search();
                    begin();
                    break;
                case 6:
                    Backpack.begin();
                    begin();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Environment.Exit(0);
                    break;
            }
        }
        static void begin()
        {
            Console.WriteLine("\nВведите номер задачи, которую вы хотели бы запустить");
            Console.WriteLine("1. Проверка числа");
            Console.WriteLine("2. НОК (наименьшее общее кратное) и НОД (наибольший общий делитель) двух целых чисел");
            Console.WriteLine("3. Работа со словами в предложении");
            Console.WriteLine("4. Работа со словами в предложении");
            Console.WriteLine("5. Числа-палиндромы");
            Console.WriteLine("6. Задача о рюкзаке");
            Console.WriteLine("\n0. Выход");
            func_cases(Convert.ToInt32(Console.ReadLine()));
        }
    }
}
