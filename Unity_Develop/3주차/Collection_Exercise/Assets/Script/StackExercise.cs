using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackExercise : MonoBehaviour
{
    private void Awake()
    {
        Stack stack = new Stack();

        for (int i = 0; i < 5; i++)
        {

            stack.Push(i);

        }

        // ���� ���ÿ� ����� ����� ����
        Debug.Log($"Stack Count : {stack.Count}");

        // ������ �ֻ��� ��Ҹ� �������� �ʰ�, ��Ҹ� ��ȯ�� �� ���
        Debug.Log($"�������� �߰��� ��� : {stack.Peek()}");
        Debug.Log($"Stack Count : {stack.Count}");

        // ������ �ֻ��� ��Ҹ� �����ϰ�, ������ ��Ҹ� ��ȯ
        object data = stack.Pop();
        Debug.Log($"���ÿ��� �������� ������ : {data}");
        Debug.Log($"Stack Count : {stack.Count}");

        // ������ ��� ��� ����
        stack.Clear();
        Debug.Log($"Stack Count : {stack.Count}");

    }

}