using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloArray : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        // �迭 0~9 �� 10��
        int[] scores = new int[10];

        scores[0] = 100;
        scores[1] = 90;
        scores[9] = 10;

        for(int i = 0; i < 10; i++)
        {
            Debug.Log(scores[i]);
        }




    }


}
