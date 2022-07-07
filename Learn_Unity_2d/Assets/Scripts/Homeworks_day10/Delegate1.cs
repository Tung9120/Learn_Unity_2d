using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text;

namespace Learn_Unity_2d
{
    public class Delegate1 : MonoBehaviour
    {
        delegate float myDelegate(float a, float b);

        // Start is called before the first frame update
        void Start()
        {
            myDelegate tinhTongDele = new myDelegate(TinhTong);
            myDelegate tinhHieuDele = new myDelegate(TinhHieu);
            myDelegate multiCastDele = tinhTongDele + tinhHieuDele;

            //float kq = multiCastDele(4, 7);
            //Debug.Log(kq);
            //Debug.Log("-----------------");

            //multiCastDele -= tinhTongDele;
            //multiCastDele(2, 6);
            Main(tinhTongDele);
        }

        void Main(myDelegate tinhTongDele)
        {
            int a = 5;
            int b = 8;
            tinhTongDele(a, b);
        }

        float TinhTong(float x, float y)
        {
            Debug.Log($"Ham tinh tong {x + y}");
            return x + y;
        }

        float TinhHieu(float x, float y)
        {
            Debug.Log($"Ham tinh hieu {x - y}");
            return x - y;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
