using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3
{
    class Program
    {/*Дано список з чисел та індекс елемента в списку k. 
        Видаліть зі списку елемент з індексом k, 
        зсунувши вгору всі елементи, що стоять нижче елемента з індексом k*/
        static List<int> listofint = new List<int>();
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                listofint.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("Enter index of your number: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = n; i >=0; i--)
            {
                if (i == 0) { }

                else
                {
                    int t = listofint[i];
                    listofint[i] = listofint[i-1];
                    listofint[i-1] = t;
                }
            }
            foreach (var i in listofint)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(new string('-',30));
            listofint.RemoveAt(0);
            foreach (var i in listofint)
            {
                Console.WriteLine(i);
            }
        }
    }
}
/*
 45
 56
 67
 78
 23
 45
 25
 48*/