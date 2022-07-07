using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text;

namespace Learn_Unity_2d
{
    public class Dictionary1 : MonoBehaviour
    {
        Dictionary<string, int> dicDemo;
        Dictionary<string, int> dicDemo2;
        int dicDemoValue;

        // Start is called before the first frame update
        void Start()
        {
            dicDemo = new Dictionary<string, int>();
            // dicDemo = new Dictionary<string, int>(3);
            // dicDemo = new Dictionary<string, int>(dicDemo2);

            // Add()
            dicDemo.Add("udev", 1);
            dicDemo.Add("hocsinh", 5);
            dicDemo.Add("giaovien", 3);

            // var keys = dicDemo.Keys;
            // var values = dicDemo.Values;

            // Clear()
            // dicDemo.Clear();

            // ContainsKey(T Key);
            // Debug.Log(dicDemo.ContainsKey("udev"));

            // ContainsValue(T Value);
            // Debug.Log(dicDemo.ContainsValue(1));

            // Remove()
            // dicDemo.Remove("hocsinh");

            // TryGetValue(TKey Key, TValue Value)
            Debug.Log(dicDemo.TryGetValue("udev", out dicDemoValue));
            Debug.Log(dicDemoValue);

            foreach(var item in dicDemo)
            {
                Debug.Log($"{item.Key} {item.Value}");
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
