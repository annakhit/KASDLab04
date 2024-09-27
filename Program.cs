using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KASDLab04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyArrayList<int> myList = new MyArrayList<int>(5);

            myList.Print();

            myList.AddElement(5);

            myList.Print();

            myList.AddAll(1, 2, 3, 4, 5, 6);

            myList.Print();

            Console.ReadKey();
        }
    }
}
