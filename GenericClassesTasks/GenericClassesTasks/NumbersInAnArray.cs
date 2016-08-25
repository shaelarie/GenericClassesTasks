using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GenericClassesTasks
{
    public class NumbersInAnArray<T> : IEnumerable<T> where T : struct
    {
        public T[] innerArray;
        T value;
        int indexNumber;
        string arrayString;
        public T real;
        public T imaginary;        
        public List<string> listString;

        public NumbersInAnArray(T List1, T List2)
        {
            real = List1;
            imaginary = List2;
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
            dynamic firstList = List1.innerArray;
            dynamic SecondList = List2.innerArray;
            return new NumbersInAnArray<T>(firstList.real + SecondList.real, firstList.imaginary + SecondList.imaginary);
            
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

}
            


        }
        