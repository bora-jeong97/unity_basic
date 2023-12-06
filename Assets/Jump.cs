using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    // Call by Reference
    public Rigidbody rb; // 변수를 만들어 rigidbody를 가리키게 함.

    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(0, 1000, 0);    // rb를 쓰는 것이 아니라 rigidbody를 쓰는 것.
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
