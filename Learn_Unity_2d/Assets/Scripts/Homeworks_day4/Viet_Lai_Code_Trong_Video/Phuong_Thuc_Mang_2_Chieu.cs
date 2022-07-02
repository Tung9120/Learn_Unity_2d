using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Learn_Unity_2d
{
    public class Phuong_Thuc_Mang_2_Chieu : MonoBehaviour
    {
        float[,] secondArray;

        // Start is called before the first frame update
        void Start()
        {
            secondArray = new float[3, 4] // mang 2 chieu (3 dong, 4 cot)
            {
            {3.2f, 3.1f, 3.5f, 3.9f },
            {5.1f, 5.2f, 5.6f, 5.7f },
            {10.1f, 10.3f, 10.2f, 10.3f }
            };

            // phuong thuc .Length tra ve gia tri dong x cot
            // Debug.Log(secondArray.Length); //12

            // phuong thuc .GetLength(0) tra ve so dong cua mang
            // phuong thuc .GetLength(1) tra ve so cot cua mang
            // Debug.Log(secondArray.GetLength(0)); //3
            // Debug.Log(secondArray.GetLength(1)); //4
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
