using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text;

namespace Learn_Unity_2d
{
    public class HashTable1 : MonoBehaviour
    {
        private Hashtable hashtableDemo;
        private Hashtable hashtableDemo2;

        // Start is called before the first frame update
        void Start()
        {
            hashtableDemo = new Hashtable();

            // Add(key, value)
            hashtableDemo.Add("udev", 10);
            hashtableDemo.Add("siro", "ten cua siro");
            hashtableDemo.Add("tung", 12f);

            hashtableDemo2 = new Hashtable();
            hashtableDemo2.Add("c#", 1);
            hashtableDemo2.Add("unity", 2);
            hashtableDemo2.Add("ads", 3);

            // var keys = hashtableDemo.Keys;
            // var values = hashtableDemo.Values;

            // foreach(var value in values)
            // {
            //     Debug.Log($"{value}");
            // }

            // kiem tra kieu tra ve cua cac phan tu trong hashtable
            // foreach(var temp in hashtableDemo)
            // {   
            //     Debug.Log(temp.GetType()); // tra ve kieu DictionaryEntry
            // }

            // duyet mang trong hashtable nen su dung DictionaryEntry
            // foreach(DictionaryEntry temp in hashtableDemo)
            // {
            //     Debug.Log($"{temp.Key} {temp.Value}");
            // }

            // Debug.Log(hashtableDemo["tung"]);

            // Clear()
            // hashtableDemo.Clear();
            // foreach(DictionaryEntry temp in hashtableDemo)
            // {
            //     Debug.Log($"{temp.Key} {temp.Value}");
            // }

            // Clone()
            // var hashtableClone = (Hashtable)hashtableDemo.Clone();
            // Debug.Log(hashtableDemo.GetType()); 

            // foreach(DictionaryEntry temp in hashtableClone)
            // {
            //     Debug.Log($"{temp.Key} {temp.Value}");
            // }

            // ContainsKey(object Key)
            // Debug.Log(hashtableDemo.ContainsKey("tung"));

            // ContainsKey(object Value)
            // Debug.Log(hashtableDemo.ContainsValue(12f));

            // CoppyTo(Array array, int index)
            // DictionaryEntry[] tezt = new DictionaryEntry[hashtableDemo.Count];
            // hashtableDemo.CopyTo(tezt, 0);
            // foreach(DictionaryEntry temp in tezt)
            // {
            //     Debug.Log($"{temp.Key} {temp.Value}");
            // }

            // Remove(object key)
            hashtableDemo.Remove("tung");
            foreach(DictionaryEntry temp in hashtableDemo)
            {
                Debug.Log($"{temp.Key} {temp.Value}");
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
