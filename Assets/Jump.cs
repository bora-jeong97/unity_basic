using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    // Call by Reference
    public Rigidbody rb; // ������ ����� rigidbody�� ����Ű�� ��.

    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(0, 1000, 0);    // rb�� ���� ���� �ƴ϶� rigidbody�� ���� ��.
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
