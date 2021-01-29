using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyGenericDictionary<TKey, TValue>
    {
        //Ana arrayler
        TKey[] keyArray;
        TValue[] valueArray;

        //Geçici arrayler
        TKey[] tempKeyArray;
        TValue[] tempValueArray;

        public MyGenericDictionary()
        {
            keyArray = new TKey[0];
            valueArray = new TValue[0];

        }

        public void Add(TKey key, TValue value)
        {
            tempKeyArray = keyArray;
            tempValueArray = valueArray;

            keyArray = new TKey[keyArray.Length + 1];
            valueArray = new TValue[valueArray.Length + 1];

            for (int i = 0; i < tempKeyArray.Length; i++)
            {
                keyArray[i] = tempKeyArray[i];
                valueArray[i] = tempValueArray[i];
            }

            keyArray[keyArray.Length - 1] = key;
            valueArray[valueArray.Length - 1] = value;
        }

        public void Items()
        {
            for (int i = 0; i < keyArray.Length; i++)
            {
                Console.WriteLine("Öğrenci No: " + keyArray[i] + " Adı-Soyadı: " + valueArray[i]);
                Console.WriteLine("------------------------------------------------");
            }
        }


    }
}
