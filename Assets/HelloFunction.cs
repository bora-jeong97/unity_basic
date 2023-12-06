using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloFunction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float sizeOfCircle = 30f; // ���� ����
        float radius = GetRadius(sizeOfCircle);
        Debug.Log("���� ������ : " + sizeOfCircle + "���� ������ : "+ radius);
    }

    //������
    float GetRadius(float size)
    {
        /*  C(���ǵѷ�) = 2����r
         *  A(���� ����) = ����r����
         *  
         */
        float pi = 3.14f;
        float tmp = size / pi;
        float radius = Mathf.Sqrt(tmp); // ������ Sqrt : ������ ��Ʈ

        return radius;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
