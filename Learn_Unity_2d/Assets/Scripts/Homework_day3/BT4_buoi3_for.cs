using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Learn_Unity_2d
{
    public class BT4_buoi3_for : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            // Bai 3: Tim so nguyen to trong day so su dung vong for
            // TimSoNguyenTo_For(9);
            _TimSoNguyenTo_For(9);
        }

        // Ham tim so nguyen to khong tra ve gia tri su dung vong for

        void TimSoNguyenTo_For(int n)
        {
            for (int i = 2; i <= n; i++)
            {
                int kt = 0;

                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        kt++;
                        break;
                    }
                }
                if (kt == 0)
                {
                    Debug.Log($"So nguyen to la {i}");
                }
            }
        }

        // Ham tim so nguyen to tra ve gia tri su dung vong for

        int[] _TimSoNguyenTo_For(int n)
        {
            int[] newArr = new int[1];
            int indexx = 0;

            for (int i = 2; i <= n; i++)
            {
                int kt = 0;

                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        kt++;
                        break;
                    }
                }
                if (kt == 0)
                {
                    Array.Resize(ref newArr, indexx + 1);
                    newArr[indexx] = i;
                    indexx++;
                }
            }

            for(int i = 0; i < newArr.Length; i++)
            {
                Debug.Log($"{newArr[i]} la so nguyen to");
            }

            return newArr;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

