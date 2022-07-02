using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Learn_Unity_2d
{
    public class BT2_buoi3_do_while : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            // Bai 2: Tinh tong chan, le su dung vong do while
            //TinhTongChanLe_Do_While(3);
            int tongLe = TinhTongChanLeTraVe_Do_While(3, 1);
            Debug.Log($"Tong so le la {tongLe}");
            int tongChan = TinhTongChanLeTraVe_Do_While(3, 2);
            Debug.Log($"Tong so chan le {tongChan}");
        }

        // Ham tinh tong chan, le khong tra ve gia tri su dung vong do while
        void TinhTongChanLe_Do_While(int n)
        {
            int tongChan = 0;
            int tongLe = 0;
            int i = 0;

            do
            {
                if (i % 2 == 0)
                    tongChan += i;
                else
                    tongLe += i;

                i++;
            } while (i <= n);

            Debug.Log($"Tong cac so chan la {tongChan}");
            Debug.Log($"Tong cac so le la {tongLe}");
        }

        // Ham tinh tong chan, le tra ve gia tri su dung vong do while
        int TinhTongChanLeTraVe_Do_While(int n, int tuyChon = 1)
        {
            int tongChan = 0;
            int tongLe = 0;
            int i = 0;

            do
            {
                if (i % 2 == 0)
                    tongChan += i;
                else
                    tongLe += i;

                i++;
            } while (i <= n);

            return (tuyChon % 2 == 0) ? tongChan : tongLe;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}