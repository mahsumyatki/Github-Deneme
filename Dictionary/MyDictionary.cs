using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<T,V>
    {
        T[] keys;
        V[] values;

        public MyDictionary()
        {
            keys = new T[0];
            values = new V[0];
        }
        public void Add(T key, V value)
        {
            T[] tempKeys = keys;
            V[] tempValues = values;

            keys = new T[keys.Length + 1];
            values = new V[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }

        public void List()//ikisinin bir arada listelenmesi
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine(keys[i] +" : "+values[i]);
            }
        }

        public T[] Keys // Sadece keylerin listelenmesi
        {
            get
            {
                return keys;
            }
        }

        public V[] Values // sadece değerlerin listelenmesi
        {
            get
            {
                return values;
            }
        }
    }
}
