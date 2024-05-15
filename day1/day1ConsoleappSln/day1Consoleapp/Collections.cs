using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1Consoleapp
{
    public class Collections
    {

        static public void CreateList()
        {
        List<int> list1 = new List<int>();

            for(int i = 0; i < 10; i++)
            {
                list1.Add(i);
            }

            
            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }
            for (int i = 0;i < 5; i++)
            {
                list1.Remove(i);
            }
            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(list1.Count());
            Console.WriteLine(list1.Contains(1));
            Console.WriteLine(list1.Average());
            Console.WriteLine(list1);
        }

        static public void CreateDict()
        {
            Dictionary<int, string> dict1 = new Dictionary<int, string>();

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter string");
                string a = Console.ReadLine();
                dict1.Add(i+1, a);
            }
            foreach (var item in dict1)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
                Console.WriteLine(item);

            }
            Console.WriteLine(dict1.ElementAt(2));

            Console.WriteLine (dict1.Remove(2));
            dict1.Clear();
            foreach (var item in dict1)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }

            Console.WriteLine(dict1.ContainsKey(3));
            Console.WriteLine(dict1.ContainsValue("mv"));
            Console.WriteLine(dict1[1]);
            Console.WriteLine(dict1.Count);
            Console.WriteLine(dict1.FirstOrDefault());
        }

        public static void Ilist()
        {
        ICollection<int> list2 = new List<int>();
            for(int i = 0; i < 10; i++)
            {
                list2.Add(i);
            }

            list2.Min();

        }




        public static void Main(string[] args)
        {
            //CreateList();
            //CreateDict();
        }
        
    }
}
