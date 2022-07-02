using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Learn_Unity_2d
{
    public class BT4_buoi3_do_while : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            // Bai 3: Tim so nguyen to trong day so su dung vong do while
            // TimSoNguyenTo_DoWhile(9);
            _TimSoNguyenTo_DoWhile(9);
        }

        // Ham tim so nguyen to khong tra ve gia tri su dung vong do while
        void TimSoNguyenTo_DoWhile(int n)
        {
            int i = 2;
            do
            {
                int kt = 0;
                int j = 2;

                do
                {
                    if (i % j == 0 && i != 2)
                    {
                        kt++;
                        break;
                    }
                    j++;
                } while (j <= i / 2);

                if (kt == 0)
                {
                    Debug.Log($"So nguyen to la {i}");
                }
                i++;
            } while (i < n);
        }

        // Ham tim so nguyen to tra ve gia tri su dung vong do while
        int[] _TimSoNguyenTo_DoWhile(int n)
        {
            int[] newArr = new int[1];
            int indexx = 0;

            int i = 2;
            do
            {
                int kt = 0;
                int j = 2;

                do
                {
                    if (i % j == 0 && i != 2)
                    {
                        kt++;
                        break;
                    }
                    j++;
                } while (j <= i / 2);

                if (kt == 0)
                {
                    Array.Resize(ref newArr, indexx + 1);
                    newArr[indexx] = i;
                    indexx++;
                }
                i++;
            } while (i < n);

            var _i = 0;
            do
            {
                Debug.Log($"{newArr[_i]} la so nguyen to");
                _i++;
            } while (_i < newArr.Length);

            return newArr;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
