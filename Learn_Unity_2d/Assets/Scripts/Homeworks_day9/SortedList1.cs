using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text;

namespace Learn_Unity_2d
{
    public class SortedList1 : MonoBehaviour
    {
        private ArrayList studentArr;
        private SortedList studentList;

        // Start is called before the first frame update
        void Start()
        {
            studentList = new SortedList();
            // studentList = new SortedList(new StudentSort2());
            // trong SortedList cac key phai cung kieu du lieu
            // Add(key, value)
            studentList.Add(3, 3);
            studentList.Add(1, "f");
            studentList.Add(2, 322);

            // Clear()
            // studentList.Clear();

            // Count
            // Debug.Log(studentList.Count);

            // Capacity
            // Debug.Log(studentList.Capacity);

            // Clone()
            // var sortedListClone = (SortedList)studentList.Clone();

            // foreach(DictionaryEntry temp in sortedListClone)
            // {
            //     Debug.Log($"{temp.Key} {temp.Value}");
            // }

            // ContainsKey(object Key)
            // Debug.Log(studentList.ContainsKey(3));

            // ContainsValue(object Value)
            // Debug.Log(studentList.ContainsValue("ff"));

             // CoppyTo(Array array, int index)
            // DictionaryEntry[] tezt = new DictionaryEntry[studentList.Count];
            // studentList.CopyTo(tezt, 0);
            // foreach(DictionaryEntry temp in tezt)
            // {
            //     Debug.Log($"{temp.Key} {temp.Value}");
            // }

            // GetByIndex(int index)
            // Debug.Log(studentList.GetByIndex(0));

            // GetKey(int index)
            // Debug.Log(studentList.GetKey(1));

            // GetKeyList() tra ve danh sach key
            // var studentKeyList = studentList.GetKeyList();
            // foreach(var temp in studentKeyList)
            // {
            //     Debug.Log(temp);
            // }

            // GetValueList() tra ve danh sach value
            // var studentValueList = studentList.GetValueList();
            // foreach(var temp in studentValueList)
            // {
            //     Debug.Log(temp);
            // }

            // IndexOfKey(object Key)
            // Debug.Log(studentList.IndexOfKey(2));

            // Remove(object key) bat dau tu key = 1
            // studentList.Remove(5);

            // RemoveAt(int index) bat dau tu index = 0
            // studentList.RemoveAt(0);

            // SetByIndex(int index, object value)
            studentList.SetByIndex(2, "abcdef");

            foreach(DictionaryEntry temp in studentList)
            {
                Debug.Log($"{temp.Key} {temp.Value}");
            }

            // studentList.Add(new Student("H", 45, 2), 3);
            // studentList.Add(new Student("f", 12, 0), "f");

            // foreach(DictionaryEntry temp in studentList)
            // {
            //     Student student = (Student)temp.Key;
            //     Debug.Log($"{temp.Key} {temp.Value}");
            // }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

    public class Student
    {
        public string name;
        public int age;
        public int classRoom;

        public Student()
        {

        }

        public Student(string name, int age, int classRoom)
        {
            this.name = name;
            this.age = age;
            this.classRoom = classRoom;
        }
    }

    public class StudentSort2 : IComparer
    {
        public int Compare(object x, object y)
        {
            Student s1 = x as Student;
            Student s2 = y as Student;

            if (string.Compare(s1.name, s2.name) < 0)
                return -1;
            else if (string.Compare(s1.name, s2.name) > 0)
                return 1;
            else
                return 0;
        }
    }
}
