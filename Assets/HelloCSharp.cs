using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCSharp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        // ����ȯ ĳ����
        int height = 170;
        float heightDetail = 170.3f;

        // �ڵ� ����ȯ (�Ҿ������ ������ ���� ���)
        heightDetail = height;

        // ���� ����ؾ� �ϴ� ��� (�Ҿ������ ������ ������)
        height = (int)heightDetail;

        // ���ǹ� if��
        bool isBoy = false;

        if(isBoy == true)
        {
            Debug.Log("���� ���ڴ�");
        }
        if(!isBoy)
        {
            Debug.Log("���� ���ڴ�");
        }

        int year = 2017;

        // switch��
        switch (year)
        {
            case 2012:
                Debug.Log("���������");
                break;
            case 2017:
                Debug.Log("Ʈ��������5");
                break;
            default:
                Debug.Log("�⵵�� �ش���� ����");
                break;
        }

        // ������ Loop �ݺ�����
        // for��, while��, dowhile�� (������ �� �� �����ϰ� ����)
        

    
    }

}
