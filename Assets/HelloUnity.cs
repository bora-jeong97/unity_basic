using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloUnity : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // �ܼ� ���
        Debug.Log("Hello");

        // var�� �Ҵ��ϴ� ���� �������� Ÿ���� ����
        var myName = "I_Jemin";
        var myAge = 23;

        Debug.Log("var myName : " + myName);
        Debug.Log("var myAge : " + myAge);
    }


}
