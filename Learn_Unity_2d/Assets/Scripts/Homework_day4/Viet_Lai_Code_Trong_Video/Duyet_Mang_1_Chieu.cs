using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Learn_Unity_2d
{
    public class Duyet_Mang_1_Chieu : MonoBehaviour
    {
        int[] scoreArray;

        // Start is called before the first frame update
        void Start()
        {
            scoreArray = new int[] { 23, 52, 43, 34, 31, 90 };
            // Duyet mang thu cong
            // Debug.Log(scoreArray[0]);
            // Debug.Log(scoreArray[1]);
            // Debug.Log(scoreArray[2]);

            // Duyet mang dung vong lap for
            // Su dung phuong thuc .Length de tra so luong phan tu co trong mang
            // for(int i = 0; i < scoreArray.Length; i++)
            // {
            //    Debug.Log(scoreArray[i]);
            // }

            // Duyet mang dung vong lap while
            //int count = 0;

            // while(count < scoreArray.Length)
            // {
            //    Debug.Log(scoreArray[0]);
            //    count++;
            // }

            // Duyet mang dung vong lap do...while

            int count = 0;

            do
            {
                Debug.Log(scoreArray[count]);
                count++;
            } while (count < scoreArray.Length);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}