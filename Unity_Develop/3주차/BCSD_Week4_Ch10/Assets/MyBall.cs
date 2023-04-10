using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBall : MonoBehaviour
{
    Rigidbody rigid;
    
    void Start()
    {
        rigid = GetComponent<Rigidbody>(); // 꺽쇠 안에 타입 넣음.

        // rigid.velocity = Vector3.right; // 현재 이동 속도
        // rigid.velocity = Vector3.left;
        // rigid.velocity = new Vector3(2, 4, 3);
        // rigid.AddForce(Vector3.up * 10, ForceMode.Impulse); // ex.캐릭터 점프
    }


    void FixedUpdate() // RigidBody 관련 코드는 FixedUpdate에 작성 권장
    {

        /* #1. 속력 바꾸기
        
        rigid.velocity = new Vector3(2, 4, -1);
        rigid.velocity = Vector3.forward; // #1. 속력 바꾸기
        */


        /* #2. 힘을 가하기

        if (Input.GetButtonDown("Jump"))
        {
            rigid.AddForce(Vector3.up * 10, ForceMode.Impulse);
            // Debug.Log(rigid.velocity);
        }

        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));

        rigid.AddForce(vec, ForceMode.Impulse);
        
        */


        /* #3. 회전력

        rigid.AddTorque(Vector3.back); // Vec을 축으로 해서 돈다.
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
         
        실제 물리적인 충돌로 발생하는 이벤트
        void OnCollisionEnter(Collider other) { }
        void OnCollisionStay(Collider other) { }
        void OnCollisionExit(Collider other) { }
        
        콜라이더 충돌로 발생하는 이벤트
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
