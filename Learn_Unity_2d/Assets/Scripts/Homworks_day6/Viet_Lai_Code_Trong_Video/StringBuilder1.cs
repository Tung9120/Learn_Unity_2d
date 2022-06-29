using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

namespace Learn_Unity_2d
{
    public class StringBuilder1 : MonoBehaviour
    {
        StringBuilder s4; // khai bao bien co kieu du lieu StringBuilder

        // Start is called before the first frame update
        void Start()
        {
            // kieu du lieu nay khi su dung phuong thuc se thao tac truc
            // tiep tren bien duoc thao tac, khac voi kieu string tao
            // ra mot bien moi de thao tac
            s4 = new StringBuilder("abcdef"); // co the de rong hoac tao 1 string trong ()

            // Append(string text) la phep noi chuoi
            // Debug.Log(s4.Append("xyzt"));

            // Clear() tra ve mot empty string
            // Debug.Log(s4.Clear());

            // s4 = 'adafasd'; // error
            // de gan lai gia tri moi cho stringBuilder su dung cach sau:
            // s4.Clear();
            // s4.Append(string newValue);

            // ToString() chuyen kieu StringBuilder sang string
            Debug.Log(s4.ToString());
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}