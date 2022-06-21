using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Learn_Unity_2d
{
    public class Mang_1_Chieu : MonoBehaviour
    {
        int[] scoreArray;
        // int[] scoreArray; // khai bao mang
        // int[] scoreArray = new int[3]; // khai bao + khoi tao mang cach 1
        // int[] scoreArray = new int[] { 1, 2, 3 }; // khai bao + khoi tao cach 2
        // int[] scoreArray = { 1, 2, 3, 4 }; // khai bao + khoi tao mang cach 3

        // Start is called before the first frame update
        void Start()
        {
            /*
            cach 1 va 2 co the khai bao va khoi tao mang trong ham nhung cach thu 3
            khi khai bao phai khoi tao ngay neu khong se bi loi
            */

            // Debug.Log(scoreArray.Length);
            //scoreArray = new int[10];
            //scoreArray[0] = 1; // thay doi gia tri cho phan tu dau tien cua mang 
            scoreArray = new int[] { 1, 2, 3 };
            scoreArray[2] = 4; // thay doi gia tri cho phan tu thu ba cua mang
            Debug.Log(scoreArray[2]);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}