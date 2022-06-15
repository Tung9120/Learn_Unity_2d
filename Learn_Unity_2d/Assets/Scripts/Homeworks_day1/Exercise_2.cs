using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Bài 2: Tính diện tích, chu vi hình tam giác

        int a = 5;
        int b = 9;
        int c = 14;
        int h = 10;

        Debug.Log("Bai 2:");
        Debug.Log("Tinh dien tich hinh tam giac: " + (a * h / 2));
        Debug.Log("Tinh chu vi hinh tam giac: " + (a + b + c));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
