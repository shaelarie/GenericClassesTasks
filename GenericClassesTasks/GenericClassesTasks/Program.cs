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
            NumbersInAnArray<int> TestingArrayClass = new NumbersInAnArray<int>();
            NumbersInAnArray<int> NewTestingArrayClass = new NumbersInAnArray<int>();
            NumbersInAnArray<int> NewList = new NumbersInAnArray<int>();
            
            TestingArrayClass.Add(1);
            TestingArrayClass.Add(2);
            TestingArrayClass.Add(3);
            foreach (int numberInArray in TestingArrayClass)
            {
                Console.WriteLine(numberInArray);
                                                 
            }
            Console.ReadLine();
            NewTestingArrayClass.Add(4);
            NewTestingArrayClass.Add(5);
            foreach (int numberInArray in NewTestingArrayClass)
            {
                Console.WriteLine(numberInArray);

            }
            TestingArrayClass.RemoveAt(1);
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
