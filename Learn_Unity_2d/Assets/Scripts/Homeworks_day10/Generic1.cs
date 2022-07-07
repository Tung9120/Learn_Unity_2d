using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text;

namespace Learn_Unity_2d
{
    public class Generic1 : MonoBehaviour
    {
        int a, b;
        Queue queueDemo;
        Queue<int> queueDemoInt;
        // Start is called before the first frame update
        void Start()
        {
            // Swap<int>(ref a, ref b);
            // GenericDemo<int> genericDemo = new GenericDemo<int>();

            queueDemo = new Queue();
            queueDemo.Enqueue(1);
            queueDemo.Enqueue("udev");

            queueDemoInt = new Queue<int>();
            queueDemoInt.Enqueue(1);
            queueDemoInt.Enqueue(2);
        }

        public void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

    public class GenericDemo<T>
    {
        public T propertyDemo;

        public GenericDemo()
        {
            Debug.Log(propertyDemo.GetType());
        }
    }
}
