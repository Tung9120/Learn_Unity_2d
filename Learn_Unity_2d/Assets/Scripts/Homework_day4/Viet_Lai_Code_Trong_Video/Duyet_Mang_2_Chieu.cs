using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Learn_Unity_2d
{
    public class Duyet_Mang_2_Chieu : MonoBehaviour
    {
        float[,] secondArray =
        {
            {1.2f, 1.3f },
            {2.1f, 2.2f },
            {3.5f, 7.6f }
        };

        // Start is called before the first frame update
        void Start()
        {
            // su dung vong lap for de duyet mang 2 chieu
            // for(int i = 0; i < secondArray.GetLength(0); i++)
            // {
            //    for(int j = 0; j < secondArray.GetLength(1); j++)
            //    {
            //        Debug.Log(secondArray[i, j]);
            //    }
            // }

            // su dung vong lap while de duyet mang 2 chieu
            // int row = 0;
            // int col = 0;
            // while (row < secondArray.GetLength(0))
            // {
            //     while (col < secondArray.GetLength(1))
            //     {
            //         Debug.Log(secondArray[row, col]);
            //         col++;
            //     }
            //     col = 0;
            //     row++;
            // }

            // su dung vong lap do...while de duyet mang 2 chieu
            int row = 0;
            int col = 0;

            do
            {
                do
                {
                    Debug.Log(secondArray[row, col]);
                    col++;
                }while(col < secondArray.GetLength(1));

                col = 0;
                row ++;
            }while(row < secondArray.GetLength(0));
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}