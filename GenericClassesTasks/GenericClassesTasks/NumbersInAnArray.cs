﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GenericClassesTasks
{
    public class NumbersInAnArray<T> : IEnumerable<T>
    {
        public T[] innerArray;
        int indexNumber;
        public T real;
        public T imaginary;        
        public List<string> listString;

        public NumbersInAnArray()
        {
            indexNumber = 0;
            innerArray = new T[indexNumber];
        }
        public void Add(T addToArray)
        {
            T[] newArray = new T[indexNumber + 1];
            for (int i = 0; i < indexNumber; i++)
            {
                newArray[i] = innerArray[i];
                
            }
            newArray[indexNumber] = addToArray;
            innerArray = newArray;
            indexNumber++;
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            for (int i = 0; i < innerArray.Length; i++)
            {
                yield return innerArray[i];
            }
             
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)innerArray).GetEnumerator();
            
        }
        public void RemoveAt(int removeFromArray)
        {
            for (int i = removeFromArray; i < innerArray.Length - 1; i++)
            {
                innerArray[i] = innerArray[i + 1];
            }
            Array.Resize(ref innerArray, innerArray.Length - 1);

        }
       
        public override string ToString()
        {

            string arrayString = "";
            foreach (T item in innerArray)
            {
                arrayString += " " + item.ToString();
            }

            Console.Write(arrayString);
            return arrayString;
        }
        

        public static NumbersInAnArray<T> operator +(NumbersInAnArray<T> List1, NumbersInAnArray<T> List2)    
        {
            NumbersInAnArray<T> List3 = new NumbersInAnArray<T>();
            
            foreach(T Item in List1.innerArray)
            {
                List3.Add(Item);
            }
            foreach (T item1 in List2.innerArray)
            {
                List3.Add(item1);
                
            }
            return List3;
        }

        public static NumbersInAnArray<T> operator -(NumbersInAnArray<T> List1, NumbersInAnArray<T> List2)
        {

            int i = 0;

            NumbersInAnArray<T> List3 = List1 + List2;
            
                foreach (T item in List2.innerArray)
                {
                    List3.RemoveAt(i + List1.innerArray.Length + 1);
                }
        
            return List3;
        }


        public void ZipLists(NumbersInAnArray<T> List1, NumbersInAnArray<T> List2)
        {
              
            
            
                
                
            if (List1.innerArray.Length > List2.innerArray.Length)
            {
                for (int i = 0; i < List2.innerArray.Length; i++)
                {
                    Console.WriteLine("{0}    {1}", List1.innerArray[i], List2.innerArray[i]);

                }
                for (int i = List2.innerArray.Length; i < List1.innerArray.Length; i++)
                {
                    Console.WriteLine("     {0}", List1.innerArray[i]);

                }

            }
            else if (List1.innerArray.Length < List2.innerArray.Length)
            {
                for (int i = 0; i < List1.innerArray.Length; i++)
                {
                    Console.WriteLine("{0}    {1}", List1.innerArray[i], List2.innerArray[i]);

                }
                for (int i = List1.innerArray.Length; i < List2.innerArray.Length; i++)
                {
                    Console.WriteLine("     {0}",  List2.innerArray[i]);

                }

            }
        }

        public int Count
        {
            get
            {
                return indexNumber;
            }
            private set
            {
            }
            
        }

        public void Sort()
        {
            T[] newList = new T[innerArray.Length];
            for(int i = 0; i < innerArray.Length; i++)
            {
                newList[i] = innerArray[i];
            }
            Array.Sort(newList);
            foreach(T item in newList)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
        
    }
 }
        