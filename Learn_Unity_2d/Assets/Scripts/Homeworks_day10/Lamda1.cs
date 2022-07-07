using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text;

namespace Learn_Unity_2d
{
    public class Lamda1 : MonoBehaviour
    {
        public delegate void myDelegate();
        public delegate void myDelegate2(float a);
        public event myDelegate explosionEvt;

        // Start is called before the first frame update
        void Start()
        {
            myDelegate dele = () =>
                Debug.Log("day la ham nac danh");

            dele();

            myDelegate2 dele2 = (float a) =>
            {
                Debug.Log($"day la ham nac danh co tham so {a}");
            };

            myDelegate2 dele3 = (float a) => Hellow(9);

             dele = () => Hellow2();

            explosionEvt += () => { };
            explosionEvt += () => Hellow2();
        }

        void Hellow(float a)
        {
            Debug.Log(a);
        }

        void Hellow2()
        {
            Debug.Log("heloo 2");
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
