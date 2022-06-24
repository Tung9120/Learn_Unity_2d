using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Learn_Unity_2d
{
    public class Bai_2 : MonoBehaviour
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
            // Bai 2: Tim phan tu duy trong mang 1 chieu, 2 chieu
            // TimSoDuyNhatTrongMang(arr1);
            // _TimSoDuyNhatTrongMang(arr1);
            // TimSoDuyNhatTrongMang2(arr2);
            _TimSoDuyNhatTrongMang2(arr2);
        }

        // Ham tim phan tu duy nhat khong tra ve gia tri trong mang 1 chieu
        void TimSoDuyNhatTrongMang(int[] _array)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                var pt01 = _array[i];
                int count = 0;

                for (int j = 0; j < _array.Length; j++)
                {
                    var pt02 = _array[j];
                    if (i != j && pt01 == pt02)
                    {
                        count++;
                    }
                }
                if (count == 0)
                    Debug.Log($"Phan tu duy nhat trong mang la {pt01}");
            }
        }

        // Ham tim phan tu duy nhat tra ve gia tri trong mang 1 chieu
        int[] _TimSoDuyNhatTrongMang(int[] _array)
        {
            int[] newArr = new int[_array.Length];
            var indexx = 0;

            for (int i = 0; i < _array.Length; i++)
            {
                var pt01 = _array[i];
                int count = 0;

                for (int j = 0; j < _array.Length; j++)
                {
                    var pt02 = _array[j];
                    if (i != j && pt01 == pt02)
                    {
                        count++;
                    }
                }
                if (count == 0)
                {
                    newArr[indexx] = pt01;
                    indexx++;
                }
            }

            for (int i = 0; i < newArr.Length; i++)
            {
                Debug.Log(newArr[i]);
            }

            return newArr;
        }

        // Ham tim phan tu duy nhat khong tra ve gia tri trong mang 2 chieu
        void TimSoDuyNhatTrongMang2(int[,] _array)
        {
            for (int i = 0; i < _array.GetLength(0); i++)
            {
                for (int j = 0; j < _array.GetLength(1); j++)
                {
                    var pt01 = _array[i, j];
                    int count = 0;
                    for (int k = 0; k < _array.GetLongLength(0); k++)
                    {
                        for (int l = 0; l < _array.GetLength(1); l++)
                        {
                            var pt02 = _array[k, l];
                            if (pt01 == pt02 && i != k && j != l)
                            {
                                count++;
                            }
                        }
                    }
                    if (count == 0)
                        Debug.Log($"Phan tu duy nhat trong mang la {pt01}");
                }
            }
        }

        // Ham tim phan tu duy nhat tra ve gia tri trong mang 2 chieu
        int[] _TimSoDuyNhatTrongMang2(int[,] _array)
        {
            int[] newArr = new int[_array.Length];
            int indexx = 0;

            for (int i = 0; i < _array.GetLength(0); i++)
            {
                for (int j = 0; j < _array.GetLength(1); j++)
                {
                    var pt01 = _array[i, j];
                    int count = 0;
                    for (int k = 0; k < _array.GetLongLength(0); k++)
                    {
                        for (int l = 0; l < _array.GetLength(1); l++)
                        {
                            var pt02 = _array[k, l];
                            if (pt01 == pt02 && i != k && j != l)
                            {
                                count++;
                            }
                        }
                    }
                    if (count == 0)
                    {
                        Array.Resize(ref newArr, indexx + 1);
                        newArr[indexx] = pt01;
                        indexx++;
                    }
                }
            }

            for(int i = 0; i < newArr.Length; i++)
            {
                Debug.Log(newArr[i]);
            }

            return newArr;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
