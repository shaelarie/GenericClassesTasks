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
            NumbersInAnArray<int> TestingArrayClass = new NumbersInAnArray<int>();
            NumbersInAnArray<int> NewTestingArrayClass = new NumbersInAnArray<int>();
            NumbersInAnArray<int> NewList = new NumbersInAnArray<int>();
            
            TestingArrayClass.Add(1);
            TestingArrayClass.Add(2);
            TestingArrayClass.Add(3);
            NewTestingArrayClass.Add(4);
            NewTestingArrayClass.Add(5);
            TestingArrayClass.RemoveAt(1);
            foreach (int numberInArray in TestingArrayClass)
            {
                Console.WriteLine(numberInArray);
                                                 
            }
            foreach (int numberInArray in NewTestingArrayClass)
            {
                Console.WriteLine(numberInArray);

            }
            TestingArrayClass.ToString();
            NewTestingArrayClass.ToString();
            Console.ReadLine();
            NewList = TestingArrayClass + NewTestingArrayClass;
            
            foreach (int items in NewList)
            {
                Console.WriteLine(items);
                
            }
            Console.ReadLine();
            NewList = TestingArrayClass - NewTestingArrayClass;
            foreach (int items in NewList)
            {
                Console.WriteLine(items);

            }
            Console.ReadLine();
            NewList.ZipLists(TestingArrayClass, NewTestingArrayClass);
            

            Console.ReadLine();
            
        }




    }
}
