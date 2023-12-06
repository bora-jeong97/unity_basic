using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloFunction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float sizeOfCircle = 30f; // 원의 넓이
        float radius = GetRadius(sizeOfCircle);
        Debug.Log("원의 사이즈 : " + sizeOfCircle + "원의 반지름 : "+ radius);
    }

    //반지름
    float GetRadius(float size)
    {
        /*  C(원의둘레) = 2파이r
         *  A(원의 넓이) = 파이r제곱
         *  
         */
        float pi = 3.14f;
        float tmp = size / pi;
        float radius = Mathf.Sqrt(tmp); // 제곱근 Sqrt : 스퀘어 루트

        return radius;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
