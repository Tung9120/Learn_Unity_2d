using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Learn_Unity_2d
{
    public class Bai_6 : MonoBehaviour
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
            // Bai 6: Tinh tich cac so trong mang 1, 2 chieu
            // TinhTichCacSoMang1Chieu(arr1);
            // _TinhTichCacSoMang1Chieu(arr1);
            // TinhTichCacSoMang2Chieu(arr2);
            _TinhTichCacSoMang2Chieu(arr2);
        }

        // Ham tinh tich cac so khong tra ve gia tri trong mang 1 chieu
        void TinhTichCacSoMang1Chieu(int[] _array)
        {
            var result = 1;

            for (int i = 0; i < _array.Length; i++)
            {
                result *= _array[i];
            }

            Debug.Log($"Tich cac so trong mang 1 chieu la {result}");
        }

        // Ham tinh tich cac so tra ve gia tri trong mang 1 chieu
        int _TinhTichCacSoMang1Chieu(int[] _array)
        {
            var result = 1;

            for (int i = 0; i < _array.Length; i++)
            {
                result *= _array[i];
            }

            Debug.Log($"Tich cac so trong mang 1 chieu la {result}");

            return result;
        }

        // Ham tinh tich cac so khong tra ve gia tri trong mang 2 chieu
        void TinhTichCacSoMang2Chieu(int[,] _array)
        {
            var result = 1;

            for (int i = 0; i < _array.GetLength(0); i++)
            {
                for (int j = 0; j < _array.GetLength(1); j++)
                {
                    result *= _array[i, j];
                }
            }

            Debug.Log(result);
        }

        // Ham tinh tich cac so tra ve gia tri trong mang 2 chieu
        int _TinhTichCacSoMang2Chieu(int[,] _array)
        {
            var result = 1;

            for (int i = 0; i < _array.GetLength(0); i++)
            {
                for (int j = 0; j < _array.GetLength(1); j++)
                {
                    result *= _array[i, j];
                }
            }

            Debug.Log(result);
            return result;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}