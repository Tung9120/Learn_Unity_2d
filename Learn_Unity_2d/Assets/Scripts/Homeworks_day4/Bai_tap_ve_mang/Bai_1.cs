using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Learn_Unity_2d
{
    public class Bai_1 : MonoBehaviour
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
            // Bai 1: Tim phan tu giong nhau trong mang 1 chieu, 2 chieu
            // TimPhanTuGiongNhauMang1Chieu(arr1);
            // _TimPhanTuGiongNhauMang1Chieu(arr1);
            // TimPhanTuGiongNhauMang2Chieu(arr2);
            _TimPhantuGiongNhauMang2chieu(arr2);
        }

        // Ham tim phan tu giong nhau khong tra ve gia tri (mang 1 chieu)
        void TimPhanTuGiongNhauMang1Chieu(int[] _array)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                var pt01 = _array[i];
                for (int j = i + 1; j < _array.Length; j++)
                {
                    var pt02 = _array[j];
                    if (pt01 == pt02 && i != j)
                        Debug.Log($"Cac so giong nhau la {pt01}");
                }
            }
        }

        // Ham tim phan tu giong nhau tra ve gia tri(mang 1 chieu)
        int[] _TimPhanTuGiongNhauMang1Chieu(int[] _array)
        {
            int count = 0;
            int[] newArr = new int[_array.Length];

            for (int i = 0; i < _array.Length; i++)
            {
                for (int j = i + 1; j < _array.Length; j++)
                {
                    if (_array[i] == _array[j])
                    {
                        Array.Resize(ref newArr, count + 1);
                        newArr[count] = _array[i];
                        count++;
                    }
                }
            }
            for (int i = 0; i < newArr.Length; i++)
            {
                Debug.Log(newArr[i]);
            }

            return newArr;
        }

        // Ham tim phan tu giong nhau khong tra ve gia tri (mang 2 chieu)
        void TimPhanTuGiongNhauMang2Chieu(int[,] _array)
        {
            for (int i = 0; i < _array.GetLength(0); i++)
            {
                for (int j = 0; j < _array.GetLength(1); j++)
                {
                    var pt01 = _array[i, j];
                    for (int k = 0; k < _array.GetLongLength(0); k++)
                    {
                        for (int l = 0; l < _array.GetLength(1); l++)
                        {
                            var pt02 = _array[k, l];
                            if (pt01 == pt02 && i != k && j != l)
                            {
                                Debug.Log($"Phan tu trung nhau la {pt01}"); ;
                            }
                        }
                    }
                }
            }
        }

        // Ham tim phan tu giong nhau ra ve gia tri (mang 2 chieu)
        int[] _TimPhantuGiongNhauMang2chieu(int[,] _array)
        {
            int[] newArr = new int[_array.Length];
            int count = 0;

            for (int i = 0; i < _array.GetLength(0); i++)
            {
                for (int j = 0; j < _array.GetLength(1); j++)
                {
                    var pt01 = _array[i, j];
                    for (int k = 0; k < _array.GetLongLength(0); k++)
                    {
                        for (int l = 0; l < _array.GetLength(1); l++)
                        {
                            var pt02 = _array[k, l];
                            if (pt01 == pt02 && i != k && j != l)
                            {
                                Array.Resize(ref newArr, count + 1);
                                newArr[count] = pt01;
                                count++;
                            }
                        }
                    }
                }
            }

            for(int i = 0; i < newArr.Length; i++)
            {
                Debug.Log($"Phan tu giong nhau trong mang la {newArr[i]}");
            }

            return newArr;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}