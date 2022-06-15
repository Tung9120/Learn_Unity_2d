using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Bài 4: Tính vận tốc quãng đường dài 20km, thời gian để đi hết quãng đường là 5 phút

        int S = 20;
        int t = 5;

        Debug.Log("Bai 4:");
        Debug.Log("Van toc la: " + (S / t) + " km/phut");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
