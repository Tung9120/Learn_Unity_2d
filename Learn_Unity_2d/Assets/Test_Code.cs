using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Test_Code : MonoBehaviour
{
    int value = 109;
    object objectValue;
    int newValue;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Test: ");
        objectValue = value;
        // Debug.Log(objectValue);
        newValue = (int)objectValue;
        Debug.Log("newValue: " + newValue);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
