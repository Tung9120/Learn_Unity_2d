using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text;

namespace Learn_Unity_2d
{
    public class Bomb : MonoBehaviour
    {
        Event1 event1;
        private void Awake()
        {
            if(event1)
                event1 = FindObjectOfType<Event1>();
        }
        // Start is called before the first frame update
        void Start()
        {
            if (event1)
                event1.explosionEvt += Explosion;
        }

        void Explosion()
        {
            Debug.Log("Da cham vao bay!. Bomb No!");
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
