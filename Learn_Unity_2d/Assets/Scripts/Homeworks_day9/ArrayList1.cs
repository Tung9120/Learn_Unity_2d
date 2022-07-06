using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text;

namespace Learn_Unity_2d
{
    public class ArrayList1 : MonoBehaviour
    {
        // khai bao mot ArrayList
        // phai them namspace System.Collections
        private ArrayList arrListDemo;
        private ArrayList arrListDemo2;

        // Start is called before the first frame update
        void Start()
        {
            // khoi tao mot ArrayList khong co tham so
            arrListDemo = new ArrayList();
            
            // khoi tao mot ArrayList truyen vao suc chua
            // arrListDemo = new ArrayList(6);

            //khoi tao mot ArrayList truyen vao mot ArrayList khac hoac mang 
            // co kieu la ICollection 
            // luc nay ArrayList dc khai bao se lay gia tri cua ArrayList dc truyen vao
            // ArrayList arrListDemo2;
            // arrListDemo = new ArrayList(arrListDemo2);

            // phuong thuc Add() se them gia tri vao cuoi mang ArrayList
            // tat ca gia tri truyen vao se la kieu object
            arrListDemo.Add(10);
            arrListDemo.Add(12f);
            arrListDemo.Add("udev");
            
            arrListDemo2 = new ArrayList();
            arrListDemo2.Add(2);
            arrListDemo2.Add(9.1f);
            arrListDemo2.Add("udev");
            
            // phhuong thuc Count tra ve so phan tu trong ArrayList
            // Debug.Log(arrListDemo.Count);

            // phuong thuc Capacity tra ve suc chua cua ArrayList
            // Debug.Log(arrListDemo.Capacity);

            // phuong thuc AddRange() la them mot mang co kieu ICollection
            // vao lam cac gia tri tiep theo cua mang va cac gia tri nay
            // xep vao cuoi mang
            arrListDemo.AddRange(arrListDemo2);

            // foreach(var value in arrListDemo)
            // {
            //     Debug.Log(value);
            // }

            // phuong thuc clear() xoa tat ca phan tu trong mang
            // arrListDemo.Clear();

            // phuong thuc Contains() kiem tra xem gia tri co ton tai trong
            // arrayList khong. tra ve true neu co, false neu khong
            // Debug.Log(arrListDemo.Contains(9.2f));

            // phuong thuc GetRange(chi so bat dau, do ta cac phan tu can lay ra)
            // lay ra so phan tu can lay tu chi so bat dau
            // var arrCopy = arrListDemo.GetRange(2, arrListDemo.Count - 2);

            // foreach(var temp in arrCopy)
            // {
            //     Debug.Log(temp);
            // }

            // phuong thuc IndexOf(value) tra ve vi tri xuat hien dau tien cua phan tu
            // Debug.Log(arrListDemo.IndexOf("udev"));

            // phuong thuc Insert(chi so chen phan tu, gia tri) chen gia tri vao vi tri
            // trong mang va day phan tu bi chen ra vi tri + 1
            // arrListDemo.Insert(3, "100");
            // foreach(var temp in arrListDemo)
            // {
            //     Debug.Log(temp);
            // }

            // phuong thuc Remove(object value) xoa phan tu value xuat hien dau tien trong mang
            // arrListDemo.Remove("udev");
            // foreach(var temp in arrListDemo)
            // {
            //     Debug.Log(temp);
            // }

            // phuong thuc Reverse() dao nguoc cac phan tu trong mang
            // arrListDemo.Reverse();
            // foreach(var temp in arrListDemo)
            // {
            //     Debug.Log(temp);
            // }

            // phuong thuc ToArray() tra ve mot mang cac object
            // var arr = arrListDemo.ToArray();

            // phuong thuc Clone() tao ra mot ban sao tu ArrayList hien nhung
            // tra ve mot object kieu mang

            var arrClone = (ArrayList)arrListDemo.Clone();
            for(int i = 0; i < arrListDemo.Count; i++)
            {
                // su dung var de xem phan tu thuoc kieu gi
                var arrItem = arrListDemo[i];
                Debug.Log(arrListDemo[i]);
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
