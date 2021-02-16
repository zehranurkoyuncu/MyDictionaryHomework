using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryHomework
{
    class MyDictionary<T, V>
    {
        T[] key;
        V[] value;

        public MyDictionary()
        {
            key = new T[0];
            value = new V[0];

        }
        public void Add(T t, V v)
        {
            T[] tempArrayKey = key;
            V[] tempArrayValue = value;
            key = new T[key.Length + 1];
            value = new V[value.Length + 1];

            for (int i = 0; i < tempArrayKey.Length; i++)
            {
                key[i] = tempArrayKey[i];
            }

            for (int i = 0; i < tempArrayValue.Length; i++)
            {
                value[i] = tempArrayValue[i];
            }

            key[key.Length - 1] = t;
            value[value.Length - 1] = v;

            Console.WriteLine("Kitap Yazarı : " + t + " | " + "Kitap Adı : " + v);
        }

        public T[] itemkey
        {
            get { return key; }
        }

        public V[] itemvalue
        {
            get { return value; }
        }

        public int Lenght
        {
            get { return key.Length; }
        }
    }
}
