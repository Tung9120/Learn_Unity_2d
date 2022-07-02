using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Learn_Unity_2d
{
    public class BT3_buoi3_do_while : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            // Bai 3: Tinh tong cac so su dung vong lap do while
            // TongCacSo_Do_While(3);
            TongCacSoTraVe_Do_While(3);
        }

        // Ham tra ve tong cac so khong tra ve gia tri su dung vong do while
        void TongCacSo_Do_While(int n)
        {
            int tong = 0;
            int i = 0;

            do
            {
                tong += i;
                i++;
            } while (i <= n);

            Debug.Log($"Tong cac so la {tong}");
        }

        // Ham tra ve tong cac so tra ve gia tri su dung vong do while
        int TongCacSoTraVe_Do_While(int n)
        {
            int tong = 0;
            int i = 0;

            do
            {
                tong += i;
                i++;
            } while (i <= n);

            Debug.Log($"Tong cac so la {tong}");
            return tong;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
