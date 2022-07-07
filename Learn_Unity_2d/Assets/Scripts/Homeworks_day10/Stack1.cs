using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text;

namespace Learn_Unity_2d
{
    public class Stack1 : MonoBehaviour
    {
        Stack stackDemo;
        Stack stackDemo2;
        ArrayList arrayListDemo;

        // Start is called before the first frame update
        void Start()
        {
            stackDemo = new Stack();
            // stackDemo = new Stack(3);
            // stackDemo = new Stack(stackDemo2);
            // stackDemo = new Stack(arrayListDemo);

            // .Push();
            stackDemo.Push(1);
            stackDemo.Push(2);
            stackDemo.Push(3);

            // .Pop();
            // stackDemo.Pop();
            // Debug.Log(stackDemo.Pop());

            // .Peek();
            // stackDemo.Peek();
            // Debug.Log(stackDemo.Peek());

            // .Clear();
            // stackDemo.Clear();

            // .Clone();
            // var stackClone = (Stack)stackDemo.Clone();

            // foreach (var item in stackClone)
            // {
            //     Debug.Log(item);
            // }

            // Contains(object Value)
            // Debug.Log(stackDemo.Contains(2f));

            // CopyTo(Array array, int index)
            // int[] tezt = new int[stackDemo.Count];
            // stackDemo.CopyTo(tezt, 0);

            // foreach(var item in tezt)
            // {
            //     Debug.Log(item);
            // }

            // ToArray()
            // var stackArr = stackDemo.ToArray();

            // foreach(var item in stackArr)
            // {
            //     Debug.Log(item);
            // }

            foreach(var temp in stackDemo)
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
