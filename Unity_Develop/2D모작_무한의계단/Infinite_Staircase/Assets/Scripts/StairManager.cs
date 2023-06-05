using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairManager : MonoBehaviour
{
    public GameObject stairPrefab;  // ��� ������
    public int initialStairCount = 20;  // �ʱ� �����Ǵ� ��� ��
    public int deleteThreshold = 5;  // ��� ���� ����

    private GameObject[] stairs;  // ������ ��ܵ��� �迭
    private int currentStairIndex = 0;  // ���� �÷��̾ ��ġ�� ��� �ε���




    private void Start()
    {
        // �ʱ� ��� ����
        CreateInitialStairs();
        Debug.Log("StairManager ȣ��!");
    }

    private void Update()
    {
        // ������ ����Ű �Է� ����
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            // ��� �� ĭ ����
            if (currentStairIndex >= deleteThreshold)
            {
                Destroy(stairs[currentStairIndex - deleteThreshold]);
            }

            // ���� ������� �̵�
            currentStairIndex++;

            // ���ο� ��� ����
            GameObject newStair = Instantiate(stairPrefab, new Vector3(0f, initialStairCount - 1, 0f), Quaternion.identity);
            stairs[currentStairIndex] = newStair;
        }

    }

    private void CreateInitialStairs()
    {
        // �ʱ� ��� ����
        stairs = new GameObject[initialStairCount];

        for (int i = 0; i < initialStairCount; i++)
        {
            stairs[i] = Instantiate(stairPrefab, new Vector3(0f, i, 0f), Quaternion.identity);
        }
    }

}
