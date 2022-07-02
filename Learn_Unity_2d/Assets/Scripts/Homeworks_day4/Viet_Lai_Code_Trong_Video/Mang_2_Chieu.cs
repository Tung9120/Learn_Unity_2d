using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Learn_Unity_2d
{
    public class Mang_2_Chieu : MonoBehaviour
    {
        float[,] secondArray; // khoi tao mang

        // float[,] secondArray = new float[2, 5]; // khai bao mang 2 chieu (2 dong 5 cot) cach 1

        // float[,] secondArray = new float[,]
        // {
        //    {1.2f, 1.3f },
        //    {2.1f, 2.2f },
        //    {3.5f, 7.6f }
        // }; // khai bao mang 2 chieu (3 dong, 2 cot) cach 2

        // float[,] secondArray =
        // {
        //    {1.2f, 1.3f, 1.4f, 1.5f },
        //    {5.1f, 5.2f, 5.3f, 5.4f }
        // };  // khai bao mang 2 chieu cach 3

        // Start is called before the first frame update
        void Start()
        {
            // giong mang 1 chieu, khai bao cach 1, cach 2 khong can khoi tao gia tri mang ngay
            // cach thu 3, khai bao phai khoi tao gia tri cho mang

            secondArray = new float[,]
            {
            {1.2f, 1.3f },
            {2.1f, 2.3f },
            {3.1f, 3.5f }
            }; // khai bao 1 mang 2 chieu (3 dong, 2 cot)
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}