using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherBall : MonoBehaviour
{

    MeshRenderer mesh;
    Material mat;

    void Start()
    {
        mesh = GetComponent<MeshRenderer>(); // ������Ʈ ��������
        mat = mesh.material;
    }


    private void OnCollisionEnter(Collision collision) // ������ �浹�� ������ �� ȣ��Ǵ� �Լ�
    {
        if (collision.gameObject.name == "MyBall")
        {
            mat.color = new Color(0, 0, 0); // ������
        }
       
    }
    private void OnCollisionExit(Collision collision) // ������ �浹�� ������ �� ȣ��Ǵ� �Լ�
    {
        if (collision.gameObject.name == "MyBall")
        {
            mat.color = new Color(1, 1, 1); // ���
        }
    }


    /*
    private void OnCollisionStay(Collision collision) // ������ �浹�ϰ� ���� �� ȣ��Ǵ� �Լ�
    {

    }

    private void OnCollisionExit(Collision collision) // ������ �浹�� ������ �� ȣ��Ǵ� �Լ�
    {
        
    }
    */


}
