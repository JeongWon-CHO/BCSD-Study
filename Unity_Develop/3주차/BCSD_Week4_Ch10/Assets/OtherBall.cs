using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherBall : MonoBehaviour
{

    MeshRenderer mesh;
    Material mat;

    void Start()
    {
        mesh = GetComponent<MeshRenderer>(); // 컴포넌트 가져오기
        mat = mesh.material;
    }


    private void OnCollisionEnter(Collision collision) // 물리적 충돌이 시작할 때 호출되는 함수
    {
        if (collision.gameObject.name == "MyBall")
        {
            mat.color = new Color(0, 0, 0); // 검은색
        }
       
    }
    private void OnCollisionExit(Collision collision) // 물리적 충돌이 끝났을 때 호출되는 함수
    {
        if (collision.gameObject.name == "MyBall")
        {
            mat.color = new Color(1, 1, 1); // 흰색
        }
    }


    /*
    private void OnCollisionStay(Collision collision) // 물리적 충돌하고 있을 때 호출되는 함수
    {

    }

    private void OnCollisionExit(Collision collision) // 물리적 충돌이 끝났을 때 호출되는 함수
    {
        
    }
    */


}
