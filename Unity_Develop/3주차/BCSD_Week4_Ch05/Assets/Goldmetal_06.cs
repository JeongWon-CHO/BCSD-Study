using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goldmetal_06 : MonoBehaviour
{

    void Start()
    {
        /*
        Vector3 vec = new Vector3(5, 5, 5); // 벡터 변수 vec 생성
        transform.Translate(vec); // 벡터값을 현재 위치에 더하는 함수
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
        Vector3 vec = new Vector3(0, 0.1f, 0); // 벡터 변수 vec 생성
        transform.Translate(vec); // 벡터값을 현재 위치에 더하는 함수
        // + 메인카메라에도 적용하여 카메라도 함께 이동할 수 있음
        */



        /* 횡 / 종 이동하기
         
        if (Input.anyKeyDown)
            Debug.Log("플레이어가 아무 키를 눌렀습니다.");

        if (Input.GetButton("Horizontal"))
        {
            // Input.GetAxis("Horizontal"); -> 수평, 수직 버튼 입력을 받으면 float
            // Debug.Log("횡 이동 중..." + Input.GetAxis("Horizontal")); 
            Debug.Log("횡 이동 중..." + Input.GetAxisRaw("Horizontal")); // 가중치 오로지 왼쪽 오른쪽만 받고 싶으면
        
        }

        if (Input.GetButton("Vertical"))
        {
            Debug.Log("종 이동 중..." + Input.GetAxisRaw("Vertical"));
        }
            
        */



        /* 사용자 입력키 받기 -> Size 수정해서 추가하기

        if (Input.anyKeyDown)
            Debug.Log("플레이어가 아무 키를 눌렀습니다.");

        if (Input.GetButtonDown("SuperFire"))
            Debug.Log("필살기!");

        if (Input.GetButton("Fire1"))
            Debug.Log("점프 모으는 중...");

        if (Input.GetButtonUp("Fire1"))
            Debug.Log("슈퍼 점프!!");

        */




        /* Button은 디바이스에 관계없이 여러가지 디바이스를 설정할 수 있다.

        if (Input.anyKeyDown)
            Debug.Log("플레이어가 아무 키를 눌렀습니다.");

        if (Input.GetButtonDown("Fire1"))
            Debug.Log("점프!");

        if (Input.GetButton("Fire1"))
            Debug.Log("점프 모으는 중...");

        if (Input.GetButtonUp("Fire1"))
            Debug.Log("슈퍼 점프!!");
        */




        /* Input Manager - Jump
        
        if (Input.anyKeyDown)
            Debug.Log("플레이어가 아무 키를 눌렀습니다.");

        if (Input.GetButtonDown("Jump"))
            Debug.Log("점프!");

        if (Input.GetButton("Jump"))
            Debug.Log("점프 모으는 중...");

        if (Input.GetButtonUp("Jump"))
            Debug.Log("슈퍼 점프!!");
        
         */



        /* 물리적인 마우스와 키보드에 한해서만

        if (Input.anyKeyDown)
            Debug.Log("플레이어가 아무 키를 눌렀습니다.");

        if (Input.GetMouseButtonDown(0)) // 0은 좌클릭, 1은 우클릭
            Debug.Log("미사일 발사!");

        if (Input.GetMouseButton(0))
            Debug.Log("미사일 모으는 중 ...");

        if (Input.GetMouseButtonUp(0))
            Debug.Log("슈퍼 미사일 발사!!!");

        */



        /* 키보드 입력
        
        if (Input.anyKeyDown)
            Debug.Log("플레이어가 아무 키를 눌렀습니다.");
         
        if (Input.anyKey)
            Debug.Log("플레이어가 아무 키를 누르고 있습니다.");

        if (Input.GetKeyDown(KeyCode.Return)) // Return은 엔터. Escape는 ESC키
            Debug.Log("아이템을 구입하였습니다.");

        if (Input.GetKey(KeyCode.LeftArrow)) // stay 상태
            Debug.Log("왼쪽으로 이동 중");

        if (Input.GetKeyUp(KeyCode.RightArrow)) // 눌렀다가 뗐을 때
            Debug.Log("오른쪽 이동을 멈추었습니다.");

        */

    }


}
