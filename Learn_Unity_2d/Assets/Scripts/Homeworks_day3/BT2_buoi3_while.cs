using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Learn_Unity_2d
{
    public class BT2_buoi3_while : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Bai 2: Tinh tong chan, le su dung vong while
        // TinhTongChanLe_While(3);
        int tongLe = TinhTongChanLeTraVe_While(3, 1);
        Debug.Log($"Tong so le la {tongLe}");
        int tongChan = TinhTongChanLeTraVe_While(3, 2);
        Debug.Log($"Tong so chan le {tongChan}");
    }

    // Ham tinh tong chan, le khong tra ve gia tri su dung vong while
    void TinhTongChanLe_While (int n)
    {
        int tongChan = 0;
        int tongLe = 0;
        int i = 0;

        while(i <= n)
        {
            if(i % 2 == 0)
                tongChan += i;
            else
                tongLe += i;

            i++;
        }
        Debug.Log($"Tong cac so chan la {tongChan}");
        Debug.Log($"Tong cac so le la {tongLe}");
    }

    // Ham tinh tong chan, le tra ve gia tri su dung vong while
    int TinhTongChanLeTraVe_While (int n,  int tuyChon = 1)
    {
        int tongChan = 0;
        int tongLe = 0;
        int i = 0;

        while(i <= n)
        {
            if(i % 2 == 0)
                tongChan += i;
            else
                tongLe += i;

            i++;
        }

        return (tuyChon != 1) ? tongChan : tongLe;
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
}
