using System;
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
        T value;
        int indexNumber;
        string arrayString;
        public int real;
        public int imaginary;
        public string listString;

        public NumbersInAnArray(int real, int imaginary)
        {
            indexNumber = 0;
            innerArray = new T[indexNumber];
            this.real = real;
            this.imaginary = imaginary;

            
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

            foreach (T number in innerArray)
            {
                
                arrayString = string.Format("{0}", number);
                Console.Write(arrayString);
                
                
            }
            Console.ReadLine();
            //listString = string.Format("{0}{1}", real, imaginary);
            Console.Write(string.Format("{0}{1}", real, imaginary));
            Console.ReadLine();
            return arrayString;

            
        }
            
         public static NumbersInAnArray<T> operator +( NumbersInAnArray<T> List1, NumbersInAnArray<T> List2)
        {
            return new NumbersInAnArray<T>(List1.real + List2.real, List1.imaginary + List2.imaginary);
        } 

        

        }
            


        }
        //public void Add(T addToArray)
        //{
        //    T[] newArray = new T[indexNumber + 1];
        //    for (int i = 0; i < indexNumber; i++)
        //    {
        //        newArray[i] = innerArray[i];

        //    }
        //    newArray[indexNumber] = addToArray;
        //    innerArray = newArray;
        //    indexNumber++;


        //}


    

