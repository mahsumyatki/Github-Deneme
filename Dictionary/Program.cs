using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "A");
            myDictionary.Add(2, "B");
            myDictionary.Add(3, "C");
            myDictionary.Add(4, "D");
            myDictionary.Add(5, "E");
            myDictionary.Add(6, "F");
            myDictionary.Add(7, "G");
            myDictionary.Add(8, "H");
            myDictionary.Add(9, "I");
            myDictionary.Add(10, "J");

            myDictionary.List();                         //ikisinin bir arada listelenmesi

            foreach (var item in myDictionary.Keys)      // Sadece keylerin listelenmesi
            {
                Console.WriteLine(item); 
            }

            foreach (var item in myDictionary.Values)    // sadece değerlerin listelenmesi
            {
                Console.WriteLine(item);
            }
        }
    }
}
