using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassesTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> baseCase = new List<int>() { 1, 2, 3 };
            //baseCase.Add(5);
            //baseCase.Add(6);
            NumbersInAnArray<int> TestingArrayClass = new NumbersInAnArray<int>(0, 0);
            TestingArrayClass.Add(1);
            TestingArrayClass.Add(2);
            TestingArrayClass.Add(3);
            //TestingArrayClass.RemoveAt(1);
            foreach (int numberInArray in TestingArrayClass)
            {
                Console.WriteLine(numberInArray);
                                       
            }
            NumbersInAnArray<int> newList = new NumbersInAnArray<int>(1, 3);
            NumbersInAnArray<int> newList2 = new NumbersInAnArray<int>(0, 0);
            TestingArrayClass.ToString();
            Console.WriteLine("{0} {1}", newList, newList2);
            Console.ReadLine();
        }


    }
}
