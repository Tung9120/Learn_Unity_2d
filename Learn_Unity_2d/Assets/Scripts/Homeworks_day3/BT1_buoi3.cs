using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Learn_Unity_2d
{
    public class BT1_buoi3 : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            // Bai 1: Xay dung ham tinh toan
            // TinhToan(4, 5, 3);
            TinhToanTraVe(3, 5, 3);
        }

        // Ham tinh toan khong tra ve gia tri
        void TinhToan(int a = 0, int b = 0, int pheptinh = 1)
        {
            float ketqua = 0;
            switch(pheptinh)
            {
                case 1:
                    ketqua = a + b;
                    Debug.Log(ketqua);
                    break;
                case 2:
                    ketqua = a - b;
                    Debug.Log(ketqua);
                    break;
                case 3:
                    ketqua = (float)a / b;
                    Debug.Log(ketqua);
                    break;
                case 4:
                    ketqua = a * b;
                    Debug.Log(ketqua);
                    break;
                default:
                    Debug.Log("Vui long nhap tu 1 - 4");
                    break;
            }
        }

        // Ham tinh toan tra ve gia tri
        float TinhToanTraVe(int a = 0, int b = 0, int pheptinh = 1)
        {
            float ketqua = 0;
            switch(pheptinh)
            {
                case 1:
                    ketqua = a + b;
                    break;
                case 2:
                    ketqua = a - b;
                    break;
                case 3:
                    ketqua = (float)a / b;
                    break;
                case 4:
                    ketqua = a * b;
                    break;
                default:
                    Debug.Log("Vui long nhap tu 1 - 4");
                    break;
            }

            Debug.Log(ketqua);
            return ketqua;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
