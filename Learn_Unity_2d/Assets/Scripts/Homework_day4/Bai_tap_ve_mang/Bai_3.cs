using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Learn_Unity_2d
{
    public class Bai_3 : MonoBehaviour
    {
        int[] arr1 = { 1, 2, 4, 2, 6, 1, 7, 8, 6, 5 };
        int[,] arr2 = new int[3, 10]
        {
            {1, 2, 4, 2, 6, 1, 7, 8, 6, 5},
            {7, 3, 0, 9, 1, 8, 6, 10, 11, 17},
            {10, 21, 1, 3, 5, 9, 2, 4, 12, 18}
        };

        // Start is called before the first frame update
        void Start()
        {
            // Bai 3: Tim cac so chan mang 1, 2 chieu
            // TimCacSoChanMang1Chieu(arr1);
            // _TimCacSoChanMang1Chieu(arr1);
            // TimCacSoChanMang2Chieu(arr2);
            _TimCacSoChanMang2Chieu(arr2);
        }

        // Ham tim cac so chan khong tra ve gia trong mang 1 chieu
        void TimCacSoChanMang1Chieu(int[] _array)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] % 2 == 0)
                {
                    Debug.Log($"Cac so chan trong mang 1 chieu la {_array[i]}");
                }
            }
        }

        // Ham tim cac so chan tra ve gia tri trong mang 1 chieu
        int[] _TimCacSoChanMang1Chieu(int[] _array)
        {
            int[] newArr = new int[_array.Length];
            int indexx = 0;

            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] % 2 == 0)
                {
                    Array.Resize(ref newArr, indexx + 1);
                    newArr[indexx] = _array[i];
                    indexx++;
                }
            }

            for (int i = 0; i < newArr.Length; i++)
            {
                Debug.Log($"Cac phan tu trong mang moi la {newArr[i]}");
            }

            return newArr;
        }

        // Ham tim cac so chan khong tra ve gia tri trong mang 2 chieu
        void TimCacSoChanMang2Chieu(int[,] _array)
        {
            for (int i = 0; i < _array.GetLength(0); i++)
            {
                for (int j = 0; j < _array.GetLength(1); j++)
                {
                    if (_array[i, j] % 2 == 0)
                    {
                        Debug.Log($"Cac so chan trong mang 2 chieu la {_array[i, j]}");
                    }
                }
            }
        }

        // Ham tim cac so chan tra ve gia tri trong mang 2 chieu
        int[] _TimCacSoChanMang2Chieu(int[,] _array)
        {
            int[] newArr = new int[_array.Length];
            int indexx = 0;

            for (int i = 0; i < _array.GetLength(0); i++)
            {
                for (int j = 0; j < _array.GetLength(1); j++)
                {
                    if (_array[i, j] % 2 == 0)
                    {
                        Array.Resize(ref newArr, indexx + 1);
                        newArr[indexx] = _array[i, j];
                        indexx++;
                    }
                }
            }

            for (int i = 0; i < newArr.Length; i++)
            {
                Debug.Log($"Cac phan tu so chan trong mang 2 chieu la {newArr[i]}");
            }

            return newArr;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
