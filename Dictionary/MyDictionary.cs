using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class MyDictionary<TKey,UValue>
    {
        TKey[] keys;
        UValue[] values;

        public MyDictionary()
        {
            keys = new TKey[0];
            values = new UValue[0];
        }

        public void Add(TKey index ,UValue item)
        {
            TKey[] tempArrayKeys = keys;
            keys = new TKey[keys.Length + 1];

            UValue[] tempArrayValues = values;
            values = new UValue[values.Length + 1];

            for (int i = 0; i < tempArrayKeys.Length; i++)
            {
                keys[i] = tempArrayKeys[i];
            }

            for (int i = 0; i < tempArrayValues.Length; i++)
            {
                values[i] = tempArrayValues[i];
            }

            keys[keys.Length - 1] = index;
            values[values.Length - 1] = item;
        }



        

        public int Count
        {
            get { return keys.Length; }
           
        }


    }
}
