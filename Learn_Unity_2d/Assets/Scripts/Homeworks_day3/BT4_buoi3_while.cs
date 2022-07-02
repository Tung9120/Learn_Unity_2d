using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Learn_Unity_2d
{
    public class BT4_buoi3_while : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            // Bai 3: Tim so nguyen to trong day so su dung vong while
            TimSoNguyenTo_While(9);
            // _TimSoNguyenTo_While(9);
        }

        // Ham tim so nguyen to khong tra ve gia tri su dung vong while
        void TimSoNguyenTo_While(int n)
        {
            int i = 2;
            while (i < n)
            {
                int kt = 0;
                int j = 2;

                while (j <= i / 2)
                {
                    if (i % j == 0)
                    {
                        kt++;
                        break;
                    }
                    j++;
                }

                if (kt == 0)
                {
                    Debug.Log($"So nguyen to la {i}");
                }
                i++;
            }
        }

        // Ham tim so nguyen to tra ve gia tri su dung vong while
        int[] _TimSoNguyenTo_While(int n)
        {
            int[] newArr = new int[1];
            int indexx = 0;

            int i = 2;
            while (i < n)
            {
                int kt = 0;
                int j = 2;

                while (j <= i / 2)
                {
                    if (i % j == 0)
                    {
                        kt++;
                        break;
                    }
                    j++;
                }

                if (kt == 0)
                {
                    Array.Resize(ref newArr, indexx + 1);
                    newArr[indexx] = i;
                    indexx++;
                }
                i++;
            }

            var _i = 0;
            while(_i < newArr.Length)
            {
                Debug.Log($"{newArr[_i]} la so nguyen to");
                _i++;
            }

            return newArr;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
