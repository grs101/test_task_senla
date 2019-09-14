using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_task
{
    class WordsInStr
    {
        //подсчет слов в предложении, сортировка, озаглавливание

        static string[] words; 
        public static void search()
        {
            //main
            Console.WriteLine("Введите предложение:");
            Console.WriteLine(word_count(Console.ReadLine()));
            word_sort(words);
            UpperCase(words);
        }
        static int word_count(string str)
        {
            string[] strings = str.Split(new char[] { '\n', '\r', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            words = strings;
            return strings.Length;
        }

        static string [] word_sort(string [] mass)
        {
            Array.Sort(mass);
            foreach (string c in mass)
                Console.Write(c + " ");
            Console.WriteLine();
            return mass;
        }
        static string [] UpperCase(string[] mass)
        {
            string temp = "";
            for (int i = 0; i < mass.Length; i++)
            {
                temp = char.ToUpper(mass[i][0]) + mass[i].Substring(1);
                mass[i] = temp;
                Console.Write(mass[i] + " ");
            }
            words = mass;
            return mass;
        }
    }
}
