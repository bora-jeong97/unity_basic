using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCSharp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        // 형변환 캐스팅
        int height = 170;
        float heightDetail = 170.3f;

        // 자동 형변환 (잃어버리는 정보가 없는 경우)
        heightDetail = height;

        // 직접 명시해야 하는 경우 (잃어버리는 정보가 있으면)
        height = (int)heightDetail;

        // 조건문 if문
        bool isBoy = false;

        if(isBoy == true)
        {
            Debug.Log("나는 남자다");
        }
        if(!isBoy)
        {
            Debug.Log("나는 여자다");
        }

        int year = 2017;

        // switch문
        switch (year)
        {
            case 2012:
                Debug.Log("레미제라블");
                break;
            case 2017:
                Debug.Log("트랜스포머5");
                break;
            default:
                Debug.Log("년도가 해당사항 없음");
                break;
        }

        // 루프문 Loop 반복문들
        // for문, while문, dowhile문 (무조건 한 번 실행하고 종료)
        

    
    }

}
