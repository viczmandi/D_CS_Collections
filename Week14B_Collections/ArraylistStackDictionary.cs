using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week14B_Collections
{
    class ArraylistStackDictionary
    {
        //static void Main(string[] args)
        //{
        //    ArrayListUse();
        //    StackUse();
        //    DictionaryUse();

        //    Console.ReadKey();
        //}

        public static void ArrayListUse()
        {
            ArrayList al = new ArrayList();
            Console.Write("Please give a sentence: ");
            string str = Console.ReadLine();
            foreach (var s in str.Split())
            {
                al.Add(s);
            }
            al.Sort();
            Console.WriteLine("Your sentence with words in alphabetical order: ");
            foreach (var s in al)
            {
                Console.Write(s + " ");
            }
        }

        public static void StackUse()
        {
            Stack stack = new Stack();
            Console.WriteLine("Please give 5 integers: ");
            for (int i = 0; i < 5; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                stack.Push(number);
            }
            Console.WriteLine("In reversed order: ");
            while (stack.Count > 0)
            {
                object obj = stack.Pop();
                Console.WriteLine(obj);
            }
        }

        public static void DictionaryUse()
        {
            Dictionary<string, int> numberDict = new Dictionary<string, int>();
            numberDict.Add("zero", 0);
            numberDict.Add("one", 1);
            numberDict.Add("two", 2);
            numberDict.Add("three", 3);
            numberDict.Add("four", 4);
            numberDict.Add("five", 5);
            numberDict.Add("six", 6);
            numberDict.Add("seven", 7);
            numberDict.Add("eight", 8);
            numberDict.Add("nine", 9);

            Console.WriteLine("Please give some text: ");
            string text = Console.ReadLine();

            foreach (var str in text.Split())
            {
                if (numberDict.ContainsKey(str))
                {
                    Console.Write(numberDict[str] + " ");
                }
                else
                {
                    Console.Write(str + " ");
                }
            }
            
        }
    }
}
