using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text;

namespace Learn_Unity_2d
{
    public class List1 : MonoBehaviour
    {
        List<float> scoreArr;
        // Start is called before the first frame update
        void Start()
        {
            scoreArr = new List<float>();
            // scoreArr = new List<float>(3);
            // scoreArr = new List<float>(new List<float>());

            // Add(object value)
            scoreArr.Add(1f);
            scoreArr.Add(2f);
            scoreArr.Add(3f);

            // AddRange(List<>())
            // scoreArr.AddRange(new List<float>());

            // Clear()
            // scoreArr.Clear();

            // Contains(T Value)
            // Debug.Log(scoreArr.Contains(1f));

            // CopyTo(Array array, int index)
            // float[] tezt = new float[scoreArr.Count];
            // scoreArr.CopyTo(tezt, 0);

            // foreach(var temp in tezt)
            // {
            //     Debug.Log(temp);
            // }

            // indexOf(T Value)
            // Debug.Log(scoreArr.IndexOf(1f));

            // insert(int index, T Value)
            // scoreArr.Insert(0, 0f);

            // InsertRange(int index, List<T>)
            // scoreArr.InsertRange(scoreArr.Count, new List<float>(3){4f, 5f, 6f});

            // LastIndexOf(T Value)
            // Debug.Log(scoreArr.LastIndexOf(3f));

            // Remove(T Value)
            // scoreArr.Remove(3f);

            // Revese();
            // scoreArr.Reverse();

            // Sort();
            // scoreArr.Sort();

            // ToArray()
            // var newArray = scoreArr.ToArray();

            // foreach (var item in newArray)
            // {
            //     Debug.Log(item);
            // }

            foreach (var item in scoreArr)
            {
                Debug.Log(item);
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
