using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListLib;

namespace WorkWithListLib
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = new MyList<int>();
            myList.Add(1);
            myList.Add(12);
            myList.Add(123);
            foreach (var example in myList)
            {
                Console.WriteLine(example);
            }
            Console.ReadKey();
        }
    }
}
