using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3_2
{
    class Program
    {
        /*Дано список та словник. 
         Створити новий словник, в якому ключами будуть значення списку, 
         а значеннями ключів — елементи словника*/
        static List<int> listofint = new List<int>();
        static Dictionary<int, string> dict = new Dictionary<int, string>();
        static void Main(string[] args)
        {
            Random rnd = new Random();
            for (int i = 0; i < 6; i++)
            {
                listofint.Add(i + rnd.Next(0,15));
            }
            Console.WriteLine("Write your number of words");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write your words:");
            for (int i = 0; i < n; i++)
            {
                dict.Add(i+rnd.Next(15,20), Console.ReadLine());
            }
            Console.WriteLine(new string('-',30));
            Console.WriteLine("List:");
            foreach (int  i in listofint)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Dict:");
            foreach (var d in dict)
            {
                Console.WriteLine($"key: {d.Key} value: {d.Value}");
            }
            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
            List<string> strs = new List<string>();
            foreach (string d in dict.Values)
            {
                strs.Add(d);
            }
            for (int i = 0; i < Math.Min(listofint.Count,dict.Count); i++)
            {
                keyValuePairs.Add(listofint[i], strs[i]);
            }
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("NewDict:");
            foreach (var d in keyValuePairs)
            {
                Console.WriteLine($"key: {d.Key} value: {d.Value}");
            }
        }
    }
}
