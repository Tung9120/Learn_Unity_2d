using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

namespace Learn_Unity_2d
{
    public class String1 : MonoBehaviour
    {
        string s1 = "abcfvb1cuo";
        string s2 = "abc2";
        string s3 = null;

        // Start is called before the first frame update
        void Start()
        {
            // string.Length tra ve do dai cua chuoi
            // Debug.Log($"do dai cua chuoi s1 la {s1.Length}");

            // String.Compare(string1, string2) de so sanh 2 chuoi
            // string1 == string2 tra ve 0
            // string1 > string2 tra ve 1
            // string1 < string2 tra ve -1

            // if(string.Compare(s1, s2) == 0)
            // {
            //     Debug.Log($"s1 == s2");
            // }
            // else if(string.Compare(s1, s2) > 0)
            // {
            //     Debug.Log($"s1 > s2");
            // }
            // else
            // {
            //     Debug.Log($"s1 < s2");
            // }

            // String.Concat(string1, string2) de noi 2 chuoi voi nhau 
            // giong phep loi chuoi nhung performance tot hon
            // Debug.Log(string.Concat(s1, s2));

            // IndexOf(char value) tra ve mot so nguyen kieu int la vi tri
            // xuat hien dau tien cua ky tu value trong chuoi, neu khong tim
            // thay thi tra ve -1
            // Debug.Log(s1.IndexOf("z"));

            // Insert(startIndex, string value) tra ve mot chuoi moi trong 
            // do bao gom chuoi cu da chen them chuoi value tai vi tri
            // startIndex
            // Debug.Log(s1.Insert(2 + 1, "d"));

            // String.IsNullOrEmpty(string) de kiem tra xem chuoi do co gia
            // tri null hoac la mot chuoi rong ("") khong 
            // Debug.Log(string.IsNullOrEmpty(s1)); // False
            // Debug.Log(string.IsNullOrEmpty(s3)); // True

            // LastIndexOf(char value) tra ve mot so nguyen kieu int la vi
            // tri xuat hien cuoi cung cua ky tu value trong chuoi, neu khong
            // tim thay thi tra ve -1
            // Debug.Log(s1.LastIndexOf('b'));

            // Remove(int startIndex, int count) tra ve mot chuoi moi da go bo
            // count ky tu tu vi tri startIndex trong chuoi ban dau
            // Debug.Log(s1.Remove(1, 3));

            // Replace(char oldValue, char newValue) tra ve mot chuoi moi da 
            // thay the cac ky tu oldValue bang ky tu newValue trong chuoi 
            // ban dau
            // Debug.Log(s1.Replace("ab", "xy"));

            // Split(char value) tra ve mot mang cac chuoi duoc cat ra tu
            // chuoi ban dau tai nhung noi co ky tu value
            // var s1SplitArray = s1.Split('b');
            // for(int i = 0; i < s1SplitArray.Length; i++)
            // {
            //     Debug.Log(s1SplitArray[i]);
            // }

            // var s1SplitArray = s1.Split(new char[] { 'b', 'c' });
            // for (int i = 0; i < s1SplitArray.Length; i++)
            // {
            //     Debug.Log(s1SplitArray[i]);
            // }

            // Substring(int startIndex, int length) tra ve mot chuoi moi
            // duoc cat tu vi tri startIndex voi so ky tu cat la length tu
            // chuoi ban dau
            // Debug.Log(s1.Substring(3, 4));

            // ToCharArray() chuyen doi tu mot chuoi sang mang
            var ToCharArray = s1.ToCharArray();
            for (int i = 0; i < ToCharArray.Length; i++)
            {
                Debug.Log(ToCharArray[i]);
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}