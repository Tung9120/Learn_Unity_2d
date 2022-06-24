using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Learn_Unity_2d
{
    public class BT3_buoi3_for : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            // Bai 3: Tinh tong cac so su dung vong lap for
            // TongCacSo_For(3);
            TongCacSoTraVe_For(3);
        }

        // Ham tra ve tong cac so khong tra ve gia tri su dung vong for
        void TongCacSo_For(int n)
        {
            int tong = 0;

            for (int i = 0; i <= n; i++)
            {
                tong += i;
            }

            Debug.Log($"Tong cac so la {tong}");
        }

        // Ham tra ve tong cac so tra ve gia tri su dung vong for
        int TongCacSoTraVe_For(int n)
        {
            int tong = 0;

            for (int i = 0; i <= n; i++)
            {
                tong += i;
            }

            Debug.Log($"Tong cac so la {tong}");
            return tong;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
