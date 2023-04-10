using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goldmetal_07 : MonoBehaviour
{
    Vector3 target = new Vector3(8, 1.5f, 0);

    void Update()
    {
        /* 1. MoveTowards (등속 이동)
        
        transform.position = Vector3.MoveTowards(transform.position, target, 1f); // 현재 위치, 목표 위치, 속도를 매개 변수로
        */



        /* 2. SmoothDamp (부드러운 감속이동)
        
        Vector3 velo = Vector3.zero;
        // Vector3 velo = Vector3.up * 50;
        
         */


        /* 3. Lerp (선형 보간)
        
        transform.position = Vector3.Lerp(transform.position, target, 0.05f); // 현재 위치, 목표 위치, 참조 속도, 속도
        // 마지막 매개변수에 비례하여 속도 증가
        
         */



        /* 4. SLerp (구면 선형 보간; 호를 그리며 이동)

        transform.position = Vector3.Slerp(transform.position, target, 0.05f);
        
        */



        // 델타 타임

        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal") * Time.deltaTime, Input.GetAxisRaw("Vertical") * Time.deltaTime);
        transform.Translate(vec);

    }

}
