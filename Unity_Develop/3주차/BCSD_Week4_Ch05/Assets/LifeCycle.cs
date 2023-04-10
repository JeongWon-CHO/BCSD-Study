using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{

    private void Awake()
    {
        Debug.Log("�÷��̾� �����Ͱ� �غ�Ǿ����ϴ�.");
    }


    void OnEnable() // Ȱ��ȭ
    {
        Debug.Log("�÷��̾ �α����߽��ϴ�.");
        
    }


    void Start()
    {
        Debug.Log("��� ��� ì����ϴ�.");
    }


    void FixedUpdate() // 1�ʿ� �� 50�� ȣ��. CPU�� ���� �����.
    {                          // >> ���� ���� ����� ���õ� ���븸 ����.
        Debug.Log("�̵�~");
    }

    void Update() // �ֱ������� ���ϴ� ������ ���� �� ���� �Լ�.
                 // ȯ�濡 ���� ���� �ֱⰡ ������ �� ������ ���� 60���������� �����.
    {
        Debug.Log("���� ���!!");
    }

    void LateUpdate() // ��� ������Ʈ�� ������ ����.
    {
        Debug.Log("����ġ ȹ��!");
    }


    void OnDisable()
    {
        Debug.Log("�÷��̾ �α׾ƿ��߽��ϴ�.");
        
    }

    void OnDestroy() // ������Ʈ�� �����Ǳ� ���� ���� ����� �����Ǵ� ����
    {
        Debug.Log("�÷��̾� �����͸� ��ü�Ͽ����ϴ�.");
    }

}
