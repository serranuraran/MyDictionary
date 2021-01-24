using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T1,T2>
    {
        T1[] keys;
        T2[] values;

        public MyDictionary()
        {
            keys = new T1[0];
            values = new T2[0];
        }

        public void Add(T1 key, T2 value)
        {
            T1[] tempKeys = keys;
            T2[] tempValues = values;
            keys = new T1[keys.Length + 1];
            values = new T2[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }
        public (T1, T2)[] Items
        {
            get
            {
                List<(T1, T2)> items = new List<(T1, T2)>();
                for (int i = 0; i < values.Length; i++)
                {
                    items.Add((keys[i], values[i]));
                }
                return items.ToArray();
            }
        }
    }
}
