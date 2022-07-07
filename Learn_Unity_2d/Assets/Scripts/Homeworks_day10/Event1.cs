using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text;

namespace Learn_Unity_2d
{
    public class Event1 : MonoBehaviour
    {
        public bool isCollisionWithTrap;
        public delegate void myDelegate();
        public event myDelegate explosionEvt;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if(explosionEvt != null && isCollisionWithTrap)
            {
                isCollisionWithTrap = false;
                explosionEvt();
            }
        }
    }
}

