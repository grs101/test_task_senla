using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_task
{
    class WordSearch
    {
        //подсчет кол-ва употреления вводимого слова в вводимом тексте
        public static void search()
        {
            //main
            string text, word;
            Console.WriteLine("Введите текст:");
            text = Console.ReadLine();
            Console.WriteLine("Введите искомое слово в тексте:");
            word = Console.ReadLine();
            comparison(text, word);
        }
        static void comparison(string text, string word)
        {
            string temp = text;
            int num = 0;
            Regex rgx = new Regex("[^a-zA-Z0-9а-яА-Я ]");
            temp = rgx.Replace(temp, "").ToLower();
            string[] strings = temp.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for(int i = 0; i < strings.Length; i++)
            {
                if (strings[i] == word.ToLower())
                    num++;
            }
            Console.WriteLine(num);
        }
    }
}
