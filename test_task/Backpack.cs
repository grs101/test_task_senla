using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_task
{
    class Backpack
    {
        //для данной задачи я выбрал метод решения динамическим программированием

        public static int[] weights; //массив с весами вещей
        public static int[] costs; //массив со стоимостью вещей
        public static void begin()
        {
            //main
            int w = 0; //вес рюкзака
            int count = 0; //количество предметов, помещаемых в рюкзак
            Console.Write("Set backpack carrying capacity - ");
            w = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many items?");
            count = Convert.ToInt32(Console.ReadLine());
            weights = new int[count + 1];
            costs = new int[count + 1];
            for (int i = 1; i <= count; i++)
            {
                Console.Write("\n№{0}\nEnter the weight of {0} item - ", i);
                weights[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the cost of {0} item - ", i);
                costs[i] = Convert.ToInt32(Console.ReadLine());
            }
            knapsack(weights, costs, w, count);
        }
        
        public static void knapsack(int[] weights, int[] costs, int w, int n)
        {
            //расчет по алгоритму Беллмана
            int y = 0;
            int[,] f1 = new int[n+1, w+1];
            int[,] f2 = new int[n+1, w+1];
            for (int i = 1; i <= n; i++)
            {
                for (y = 0; y <= w; y++)
                {
                    f1[i,y] = 0;
                }
            }
            for (int k = 1; k <= n; k++)
            {
                for (y = w; y >= 0; y--)
                {
                    if (weights[k] <= y && f1[k-1, y] < f1[k-1, y - weights[k]] + costs[k])
                    {
                        f1[k, y] = f1[k-1, y - weights[k]] + costs[k];
                        f2[k, y] = 1;
                    }
                    else
                        f2[k, y] = 0;
                }
            }
            //part1-end-------------
            y = w;
            int item_value = 0;
            for (int k = n; k >= 0; k--)
            {
                if (f2[k, y] == 1)
                {
                    y = y - weights[k];
                    item_value += costs[k];
                    Console.WriteLine("Item {0} taken", k);
                }
            }
            Console.WriteLine("Total value - {0}", item_value);
        }
        //---------
    }
}
