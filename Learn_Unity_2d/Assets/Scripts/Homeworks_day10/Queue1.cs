using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text;

namespace Learn_Unity_2d
{
    public class Queue1 : MonoBehaviour
    {
        Queue queueDemo;
        Queue queueDemo2;
        ArrayList arrayListDemo;

        // Start is called before the first frame update
        void Start()
        {
            queueDemo = new Queue();
            // queueDemo = new Queue(1);
            // queueDemo = new Queue(queueDemo2);
            // queueDemo = new Queue(hashtableDemo);

            // Enqueue(object value)
            queueDemo.Enqueue(1);
            queueDemo.Enqueue(2);
            queueDemo.Enqueue(3);

            // Dequeue()
            // Debug.Log(queueDemo.Dequeue());
            // queueDemo.Dequeue();

            // Peek()
            // Debug.Log(queueDemo.Peek());

            // Clear()
            // queueDemo.Clear();

            // Clone()
            // var queueClone = (Queue)queueDemo.Clone();
            
            // foreach (var item in queueClone)
            // {
            //     Debug.Log(item);
            // }

            // Contains(object value)
            // Debug.Log(queueDemo.Contains("udev"));

            // CopyTo(Array array, int index)
            // int[] tezt = new int[queueDemo.Count];
            // queueDemo.CopyTo(tezt, 0);

            // foreach(var temp in tezt)
            // {
            //     Debug.Log(temp);
            // }

            // ToArray()
            // var queueArray = queueDemo.ToArray();

            // foreach (var item in queueArray)
            // {
            //     Debug.Log(item);
            // }
            
            foreach(var temp in queueDemo)
            {
                Debug.Log(temp);
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
