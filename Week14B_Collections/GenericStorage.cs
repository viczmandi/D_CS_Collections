using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Week14B_Collections
{
    class GenericStorage
    {
        //static void Main(string[] args)
        //{
        //    GenericListUse();
        //    Console.ReadKey();
        //}
        
        public static void GenericListUse()
        {
            List<string> gl = new List<string>();
            Console.Write("Please give a sentence: ");
            string str = Console.ReadLine();
            foreach (var s in str.Split())
            {
                gl.Add(s);
            }
            gl.Sort();
            Console.WriteLine("Your sentence with words in alphabetical order: ");
            foreach (var s in gl)
            {
                Console.Write(s + " ");
            }
        }
    }
}
