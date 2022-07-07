using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class LinQ1 : MonoBehaviour
{
    public List<int> listA;
    public List<int> listB;
    // Start is called before the first frame update
    void Start()
    {
        listA = new List<int>();
        listB = new List<int>();

        listA.Add(1);
        listA.Add(2);
        listA.Add(3);
        listA.Add(4);

        listB.Add(4);
        listB.Add(5);
        listB.Add(6);
        listB.Add(1);

        //var result = listA.Distinct().ToArray();
        //var result = listA.Except(listB);
        //var result = listA.Intersect(listB);
        //var result = listA.Union(listB);
        // var result = listA.Where(r =>  r > 2 && r < 6).ToArray();
        // var result = listA.Take(4);
        // var result = listA.Where(r => r <= 5).Take(4).ToArray();
        var result = listA.Intersect(listB).Where(e => e == 7).ToArray();

        foreach(var item in result)
        {
            Debug.Log(item);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
