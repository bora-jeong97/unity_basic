using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloUnity : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 콘솔 출력
        Debug.Log("Hello");

        // var는 할당하는 값을 기준으로 타입을 결정
        var myName = "I_Jemin";
        var myAge = 23;

        Debug.Log("var myName : " + myName);
        Debug.Log("var myAge : " + myAge);
    }


}
