using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text;

namespace Learn_Unity_2d
{
    public class SortArrayList1 : MonoBehaviour
    {
        // private ArrayList arrListDemo;
        // private ArrayList arrListDemo2;
        private ArrayList studentArr;

        // Start is called before the first frame update
        void Start()
        {
            // arrListDemo = new ArrayList();
            // arrListDemo.Add(10);
            // arrListDemo.Add(12);
            // arrListDemo.Add(54);

            // arrListDemo2 = new ArrayList();
            // arrListDemo2.Add(2);
            // arrListDemo2.Add(565);
            // arrListDemo2.Add(78);

            // arrListDemo.AddRange(arrListDemo2);

            // phuong thuc Sort() khong co tham so sap xep cac phan tu, ap dung khi tat 
            // ca cac phan tu phai cung kieu du lieu
            // arrListDemo.Sort();

            // foreach(var temp in arrListDemo)
            // {
            //     Debug.Log(temp);
            // }

            studentArr = new ArrayList();
            studentArr.Add(new Student("A", 12, 2));
            studentArr.Add(new Student("T", 10, 0));
            studentArr.Add(new Student("C", 11, 1));
            studentArr.Add(new Student("H", 14, 5));
            studentArr.Add(new Student("B", 19, 3));

            // phuong thuc Sort(IComparer) co tham so truyen vao la mot 
            // object tao ra tu lop ke thua Icomparer
            // studentArr.Sort(new StudentSort());

            // foreach(Student student in studentArr)
            // {
            //     Debug.Log(student.name);
            // }

            // Sort(vi tri bat dau, so phan tu, Icomparer)
            studentArr.Sort(2, 3, new StudentSort());
            foreach(Student student in studentArr)
            {
                Debug.Log(student.name);
            }
        }

        public class Student
        {
            public string name;
            public int age;
            public int classRoom;

            public Student(string name, int age, int classRoom)
            {
                this.name = name;
                this.age = age;
                this.classRoom = classRoom;
            }

            public Student(int a)
            {

            }
        }

        // IComparper la 1 interface co trong namspace System.Collections
        // dung de so sanh
        public class StudentSort : IComparer
        {
            public int Compare(object x, object y)
            {
                Student s1 = x as Student;
                Student s2 = (Student)y;

                // if(s1.age < s2.age)
                //     return -1;
                // else if(s1.age > s2.age)
                //     return 1;
                // else
                //     return 0;

                if(string.Compare(s1.name, s2.name) < 0)
                    return -1;
                else if(string.Compare(s1.name, s2.name) > 0)
                    return 1;
                else
                    return 0;
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
