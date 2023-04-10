using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goldmetal_06 : MonoBehaviour
{

    void Start()
    {
        /*
        Vector3 vec = new Vector3(5, 5, 5); // ���� ���� vec ����
        transform.Translate(vec); // ���Ͱ��� ���� ��ġ�� ���ϴ� �Լ�
        */
    }


    void Update()
    {

        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        transform.Translate(vec);

        /*
         
        Vector3 vec = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        transform.Translate(vec);
        
         */



        /*
        Vector3 vec = new Vector3(0, 0.1f, 0); // ���� ���� vec ����
        transform.Translate(vec); // ���Ͱ��� ���� ��ġ�� ���ϴ� �Լ�
        // + ����ī�޶󿡵� �����Ͽ� ī�޶� �Բ� �̵��� �� ����
        */



        /* Ⱦ / �� �̵��ϱ�
         
        if (Input.anyKeyDown)
            Debug.Log("�÷��̾ �ƹ� Ű�� �������ϴ�.");

        if (Input.GetButton("Horizontal"))
        {
            // Input.GetAxis("Horizontal"); -> ����, ���� ��ư �Է��� ������ float
            // Debug.Log("Ⱦ �̵� ��..." + Input.GetAxis("Horizontal")); 
            Debug.Log("Ⱦ �̵� ��..." + Input.GetAxisRaw("Horizontal")); // ����ġ ������ ���� �����ʸ� �ް� ������
        
        }

        if (Input.GetButton("Vertical"))
        {
            Debug.Log("�� �̵� ��..." + Input.GetAxisRaw("Vertical"));
        }
            
        */



        /* ����� �Է�Ű �ޱ� -> Size �����ؼ� �߰��ϱ�

        if (Input.anyKeyDown)
            Debug.Log("�÷��̾ �ƹ� Ű�� �������ϴ�.");

        if (Input.GetButtonDown("SuperFire"))
            Debug.Log("�ʻ��!");

        if (Input.GetButton("Fire1"))
            Debug.Log("���� ������ ��...");

        if (Input.GetButtonUp("Fire1"))
            Debug.Log("���� ����!!");

        */




        /* Button�� ����̽��� ������� �������� ����̽��� ������ �� �ִ�.

        if (Input.anyKeyDown)
            Debug.Log("�÷��̾ �ƹ� Ű�� �������ϴ�.");

        if (Input.GetButtonDown("Fire1"))
            Debug.Log("����!");

        if (Input.GetButton("Fire1"))
            Debug.Log("���� ������ ��...");

        if (Input.GetButtonUp("Fire1"))
            Debug.Log("���� ����!!");
        */




        /* Input Manager - Jump
        
        if (Input.anyKeyDown)
            Debug.Log("�÷��̾ �ƹ� Ű�� �������ϴ�.");

        if (Input.GetButtonDown("Jump"))
            Debug.Log("����!");

        if (Input.GetButton("Jump"))
            Debug.Log("���� ������ ��...");

        if (Input.GetButtonUp("Jump"))
            Debug.Log("���� ����!!");
        
         */



        /* �������� ���콺�� Ű���忡 ���ؼ���

        if (Input.anyKeyDown)
            Debug.Log("�÷��̾ �ƹ� Ű�� �������ϴ�.");

        if (Input.GetMouseButtonDown(0)) // 0�� ��Ŭ��, 1�� ��Ŭ��
            Debug.Log("�̻��� �߻�!");

        if (Input.GetMouseButton(0))
            Debug.Log("�̻��� ������ �� ...");

        if (Input.GetMouseButtonUp(0))
            Debug.Log("���� �̻��� �߻�!!!");

        */



        /* Ű���� �Է�
        
        if (Input.anyKeyDown)
            Debug.Log("�÷��̾ �ƹ� Ű�� �������ϴ�.");
         
        if (Input.anyKey)
            Debug.Log("�÷��̾ �ƹ� Ű�� ������ �ֽ��ϴ�.");

        if (Input.GetKeyDown(KeyCode.Return)) // Return�� ����. Escape�� ESCŰ
            Debug.Log("�������� �����Ͽ����ϴ�.");

        if (Input.GetKey(KeyCode.LeftArrow)) // stay ����
            Debug.Log("�������� �̵� ��");

        if (Input.GetKeyUp(KeyCode.RightArrow)) // �����ٰ� ���� ��
            Debug.Log("������ �̵��� ���߾����ϴ�.");

        */

    }


}
