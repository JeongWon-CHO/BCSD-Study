using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goldmetal_07 : MonoBehaviour
{
    Vector3 target = new Vector3(8, 1.5f, 0);

    void Update()
    {
        /* 1. MoveTowards (��� �̵�)
        
        transform.position = Vector3.MoveTowards(transform.position, target, 1f); // ���� ��ġ, ��ǥ ��ġ, �ӵ��� �Ű� ������
        */



        /* 2. SmoothDamp (�ε巯�� �����̵�)
        
        Vector3 velo = Vector3.zero;
        // Vector3 velo = Vector3.up * 50;
        
         */


        /* 3. Lerp (���� ����)
        
        transform.position = Vector3.Lerp(transform.position, target, 0.05f); // ���� ��ġ, ��ǥ ��ġ, ���� �ӵ�, �ӵ�
        // ������ �Ű������� ����Ͽ� �ӵ� ����
        
         */



        /* 4. SLerp (���� ���� ����; ȣ�� �׸��� �̵�)

        transform.position = Vector3.Slerp(transform.position, target, 0.05f);
        
        */



        // ��Ÿ Ÿ��

        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal") * Time.deltaTime, Input.GetAxisRaw("Vertical") * Time.deltaTime);
        transform.Translate(vec);

    }

}
