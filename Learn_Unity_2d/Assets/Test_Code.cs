using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Test_Code : MonoBehaviour
{
    int a;

    // Start is called before the first frame update
    void Start()
    {
        ChangeA(ref a);
        ChangeA(ref a);
        ChangeA(ref a);

       // Debug.Log(a); // a = 3
    }

    void ChangeA(ref int value)
    {
        value = 0;
        value++;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
