using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Learn_Unity_2d
{
    public class Enum1 : MonoBehaviour
    {
        // khai bao va khoi tao gia tri cho enum
        // enum chi gan dc gia tri kieu int
        enum GameState
        {
            Starting,
            Playing,
            Win ,
            GameOver
        }

        // Start is called before the first frame update
        void Start()
        {
            // Debug.Log(GameState.Win);
            // Debug.Log((int)GameState.Win);

            if(GameState.Win == (GameState)1) // ep kieu tu int sang enum
            {

            }

            Debug.Log((GameState)1); // ep kieu tu int sang enum

            if((int)GameState.Win == 2) // ep kieu tu enum sang int
            {

            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
