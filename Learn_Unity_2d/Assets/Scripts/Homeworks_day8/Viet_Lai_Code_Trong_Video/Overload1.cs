using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Learn_Unity_2d_4
{
    public class Overload1 : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }

    public class Enemy
    {
        public void Move()
        {

        }

        public void Move(int speed)
        {

        }

        public void Move(float speed)
        {
            
        }
    }
}
