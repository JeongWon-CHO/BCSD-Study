using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{

    private void Awake()
    {
        Debug.Log("플레이어 데이터가 준비되었습니다.");
    }


    void OnEnable() // 활성화
    {
        Debug.Log("플레이어가 로그인했습니다.");
        
    }


    void Start()
    {
        Debug.Log("사냥 장비를 챙겼습니다.");
    }


    void FixedUpdate() // 1초에 약 50번 호출. CPU를 많이 사용함.
    {                          // >> 보통 물리 연산과 관련된 내용만 넣음.
        Debug.Log("이동~");
    }

    void Update() // 주기적으로 변하는 로직을 넣을 때 쓰는 함수.
                 // 환경에 따라 실행 주기가 떨어질 수 있지만 보통 60프레임으로 실행됨.
    {
        Debug.Log("몬스터 사냥!!");
    }

    void LateUpdate() // 모든 업데이트가 끝나고 실행.
    {
        Debug.Log("경험치 획득!");
    }


    void OnDisable()
    {
        Debug.Log("플레이어가 로그아웃했습니다.");
        
    }

    void OnDestroy() // 오브젝트가 삭제되기 전에 무언가 남기고 삭제되는 영역
    {
        Debug.Log("플레이어 데이터를 해체하였습니다.");
    }

}
