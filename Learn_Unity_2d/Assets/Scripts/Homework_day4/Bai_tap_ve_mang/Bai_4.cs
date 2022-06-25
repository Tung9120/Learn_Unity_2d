using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Learn_Unity_2d
{
    public class Bai_4 : MonoBehaviour
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
            // Bai 4: Tim cac so le trong mang 1, 2 chieu
            // TimCacSoLeMang1Chieu(arr1);
            // _TimCacSoLeMang1Chieu(arr1);
            // TimCacSoLeMang2Chieu(arr2);
            _TimCacSoLeMang2Chieu(arr2);
        }

        // Ham tim cac so le khong tra ve gia tri trong mang 1 chieu
        void TimCacSoLeMang1Chieu(int[] _array)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] % 2 != 0)
                {
                    Debug.Log($"Cac so le trong mang 1 chieu la {_array[i]}");
                }
            }
        }

        // Ham tim cac so le tra ve gia tri trong mang 1 chieu
        int[] _TimCacSoLeMang1Chieu(int[] _array)
        {
            int[] newArr = new int[_array.Length];
            int indexx = 0;

            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] % 2 != 0)
                {
                    newArr[indexx] = _array[i];
                    indexx++;
                }
            }

            for (int i = 0; i < newArr.Length; i++)
            {
                Debug.Log($"Cac phan tu so le trong mang 1 chieu la {newArr[i]}");
            }

            return newArr;
        }

        // Ham tim cac so le khong tra ve gia tri trong mang 2 chieu
        void TimCacSoLeMang2Chieu(int[,] _array)
        {
            for (int i = 0; i < _array.GetLength(0); i++)
            {
                for (int j = 0; j < _array.GetLength(1); j++)
                {
                    if (_array[i, j] % 2 != 0)
                    {
                        Debug.Log($"Cac so le trong mang 2 chieu la {_array[i, j]}");
                    }
                }
            }
        }

        // Ham tim cac so le tra ve gia tri trong mang 2 chieu
        int[] _TimCacSoLeMang2Chieu(int[,] _array)
        {
            int[] newArr = new int[_array.Length];
            int indexx = 0;

            for (int i = 0; i < _array.GetLength(0); i++)
            {
                for (int j = 0; j < _array.GetLength(1); j++)
                {
                    if (_array[i, j] % 2 != 0)
                    {
                        Array.Resize(ref newArr, indexx + 1);
                        newArr[indexx] = _array[i, j];
                        indexx++;
                    }
                }
            }

            for (int i = 0; i < newArr.Length; i++)
            {
                Debug.Log($"Cac phan tu so le trong mang 2 chieu la {newArr[i]}");
            }

            return newArr;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

