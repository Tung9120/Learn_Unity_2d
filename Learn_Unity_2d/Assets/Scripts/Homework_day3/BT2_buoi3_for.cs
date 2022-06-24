using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Learn_Unity_2d
{
    public class BT2_buoi3_for : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            // Bai2: Tinh Tong chan, le su dung vong for
            // TinhTongChanLeFor(3);
            int result = TinhTongChanLeTraVe_For(3, 1);
            Debug.Log(result);
            result = TinhTongChanLeTraVe_For(3, 2);
            Debug.Log(result);
        }

        // Ham tinh tong chan, le khong tra ve gia tri su dung vong for
        void TinhTongChanLe_For(int n)
        {
            int tongChan = 0;
            int tongLe = 0;

            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                    tongChan += i;
                else
                    tongLe += i;
            }
            Debug.Log($"Tong cac so chan la {tongChan}");
            Debug.Log($"Tong cac so le la {tongLe}");
        }

        // Ham tinh tong chan, le tra ve gia tri su dung vong for
        int TinhTongChanLeTraVe_For(int n, int option = 1)
        {
            int tongChan = 0;
            int tongLe = 0;

            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                    tongChan += i;
                else
                    tongLe += i;
            }

            // Ham nay em viet co them mot param option, neu chon 1 se tra 
            // ve tong le, neu chon 2 se tra ve tong chan
            return (option == 1) ? tongLe : tongChan;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}