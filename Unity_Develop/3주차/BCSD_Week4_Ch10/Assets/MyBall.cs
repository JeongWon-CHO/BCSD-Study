using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBall : MonoBehaviour
{
    Rigidbody rigid;
    
    void Start()
    {
        rigid = GetComponent<Rigidbody>(); // ���� �ȿ� Ÿ�� ����.

        // rigid.velocity = Vector3.right; // ���� �̵� �ӵ�
        // rigid.velocity = Vector3.left;
        // rigid.velocity = new Vector3(2, 4, 3);
        // rigid.AddForce(Vector3.up * 10, ForceMode.Impulse); // ex.ĳ���� ����
    }


    void FixedUpdate() // RigidBody ���� �ڵ�� FixedUpdate�� �ۼ� ����
    {

        /* #1. �ӷ� �ٲٱ�
        
        rigid.velocity = new Vector3(2, 4, -1);
        rigid.velocity = Vector3.forward; // #1. �ӷ� �ٲٱ�
        */


        /* #2. ���� ���ϱ�

        if (Input.GetButtonDown("Jump"))
        {
            rigid.AddForce(Vector3.up * 10, ForceMode.Impulse);
            // Debug.Log(rigid.velocity);
        }

        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));

        rigid.AddForce(vec, ForceMode.Impulse);
        
        */


        /* #3. ȸ����

        rigid.AddTorque(Vector3.back); // Vec�� ������ �ؼ� ����.
        rigid.AddTorque(Vector3.up);
        rigid.AddTorque(Vector3.down);

        */


        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector3 vec = new Vector3(h, 0, v);

        rigid.AddForce(vec, ForceMode.Impulse);

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.name == "Cube")
        {
            rigid.AddForce(Vector3.up * 4, ForceMode.Impulse);
        }


        /*
         
        ���� �������� �浹�� �߻��ϴ� �̺�Ʈ
        void OnCollisionEnter(Collider other) { }
        void OnCollisionStay(Collider other) { }
        void OnCollisionExit(Collider other) { }
        
        �ݶ��̴� �浹�� �߻��ϴ� �̺�Ʈ
        void OnTriggerEnter(Collider other) { }
        void OnTriggerStay(Collider other) { }
        void OnTriggerExit(Collider other) { }

        */


    }

    public void Jump()
    {
        rigid.AddForce(Vector3.up * 20, ForceMode.Impulse);
    }

}
