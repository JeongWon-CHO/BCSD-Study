using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairManager : MonoBehaviour
{
    public GameObject stairPrefab;  // 계단 프리팹
    public int initialStairCount = 20;  // 초기 생성되는 계단 수
    public int deleteThreshold = 5;  // 계단 삭제 기준

    private GameObject[] stairs;  // 생성된 계단들의 배열
    private int currentStairIndex = 0;  // 현재 플레이어가 위치한 계단 인덱스




    private void Start()
    {
        // 초기 계단 생성
        CreateInitialStairs();
        Debug.Log("StairManager 호출!");
    }

    private void Update()
    {
        // 오른쪽 방향키 입력 감지
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            // 계단 한 칸 삭제
            if (currentStairIndex >= deleteThreshold)
            {
                Destroy(stairs[currentStairIndex - deleteThreshold]);
            }

            // 다음 계단으로 이동
            currentStairIndex++;

            // 새로운 계단 생성
            GameObject newStair = Instantiate(stairPrefab, new Vector3(0f, initialStairCount - 1, 0f), Quaternion.identity);
            stairs[currentStairIndex] = newStair;
        }

    }

    private void CreateInitialStairs()
    {
        // 초기 계단 생성
        stairs = new GameObject[initialStairCount];

        for (int i = 0; i < initialStairCount; i++)
        {
            stairs[i] = Instantiate(stairPrefab, new Vector3(0f, i, 0f), Quaternion.identity);
        }
    }

}
