using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Learn_Unity_2d
{
    public class Foreach : MonoBehaviour
    {
        int[] scoreArray = { 1, 2, 3, 4, 5 };
        float[,] secondArray =
        {
        {1.0f, 2.0f},
        {3.0f, 4.0f},
        {5.0f, 6.0f}
    };

        // Start is called before the first frame update
        void Start()
        {
            // foreach (int temp in scoreArray)
            // {
            //     Debug.Log(temp);
            // }

            // foreach (var temp in secondArray) // co the su dung tu khoa var trong vong lap foreach
            // {
            //     Debug.Log(temp);
            // }

            // vong lap foreach chi duyet duoc tuan tu 
            // vd: duyet tu cuoi mang den dau mang vong lap foreach khong lam duoc 
            // nen su dung vong lap for de lam dieu do

            // for(int i = scoreArray.Length - 1; i >= 0; i--)
            // {
            //     Debug.Log(scoreArray[i]);
            // }

            // vd: muon it ra gia tri lien truoc va lien sau mot phan tu thi  
            // khong the su dung vong lap foreach ma phai su dung vong lap for

            // for (int i = scoreArray.Length - 1; i >= 0; i--)
            // {
            //     if(i > 0)
            //     {
            //         Debug.Log($"Phan tu lien truoc cua {scoreArray[i]} la: {scoreArray[i - 1]}");
            //     }

            //     if(i < scoreArray.LongLength - 1)
            //     {
            //         Debug.Log($"Phan tu lien sau cua {scoreArray[i]} la {scoreArray[i + 1]}");
            //     }
            // }

            // vd: muon thay doi gia tri cac phan tu trong mang thi khong
            // the su dung vong lap foreach ma phai su dung vong lap for

            for(int i = 0; i < scoreArray.Length; i++)
            {
                // thay doi gia tri cac phan tu trong mang su dung vong lap for
                scoreArray[i] += 100;
                Debug.Log(scoreArray[i]);
            }


    }

        // Update is called once per frame
        void Update()
        {

        }
    }

}