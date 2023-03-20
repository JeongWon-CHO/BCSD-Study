using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Datatype1 : MonoBehaviour
{
    // enum PlayerState { Idle, Move, Attack }

    private void Awake()
    {

        /* 14. 
        int? intValue;

        intValue = null;
        Debug.Log(intValue.HasValue); // null 상태니깐 false가 나올 것임.
        // Debug.Log(intValue.Value); // 현재 intValue가 null이기 때문에 값을 출력하면 에러 발생

        intValue = 30;
        Debug.Log(intValue.HasValue);
        Debug.Log(intValue.Value);

        var valueInt = 33;
        var valueFloat = 33.4567f;
        var valueString = "문자열";

        Debug.Log("정수 : " + valueInt);
        Debug.Log("실수 : " + valueFloat);
        Debug.Log("문자열 : " + valueString);
        */


        /* 13. 열거형을 이용한 플레이어 상태 관리
        PlayerState playerState = playerState.Idle;

        switch (playerState)
        {
            case PlayerState.Idle:
                Debug.Log("플레이어 상태 : 대기");
                break;
            case PlayerState.Move:
                Debug.Log("플레이어 상태 : 이동");
                break;
            case PlayerState.Attack:
                Debug.Log("플레이어 상태 : 공격");
                break;
        }
        */


        /* 12. 상수를 이용한 플레이어 상태 관리
        const int PlayerIdle = 0;
        const int PlayerMove = 1;
        const int PlayerAttack = 2;

        int playerState = PlayerAttack;

        switch (playerState)
        {
            case PlayerIdle:
                Debug.Log("플레이어 상태 : 대기");
                break;
            case PlayerMove:
                Debug.Log("플레이어 상태 : 이동");
                break;
            case PlayerAttack:
                Debug.Log("플레이어 상태 : 공격");
                break;
        }
        */


        /* 11. 숫자를 문자열로 형 변환 - ToString()
        string stringValue = "초기화";
        int intValue = 33;
        float floatValue = 12.3456f;

        Debug.Log("stringValue : " + stringValue);

        // 정수를 문자열로 형 변환
        stringValue = intValue.ToString();
        Debug.Log("stringValue : " + stringValue);

        // 실수를 문자열로 형 변환
        stringValue = floatValue.ToString();
        Debug.Log("stringValue : " + stringValue);
        */


        /* 10. 문자열을 숫자로 형 변환 II - TryParse()
        string stringValue = "숫자가 아닙니다.";
        int intValue = 10;

        bool isConversion = int.TryParse(stringValue, out intValue);
        if (isConversion == true)
        {
            Debug.Log("stringValue : " + stringValue);
            Debug.Log("intValue : " + intValue);
        }
        else
        {
            Debug.Log("stringValue 변수에 들어있는 내용이 숫자가 아니어서 형변환에 실패하였습니다.");
        }
        */


        /* 09. 문자열을 숫자로 형 변환 I - Parse()
        
        // 문자열(string)에 숫자가 아닌 데이터가 들어있을 경우 숫자로 형 변환을 시도하면 에러 발생
        int intValue = 10;
        float floatValue = 12.3456f;
        string stringValue = "33";

        Debug.Log("intValue : " + intValue);
        Debug.Log("floatValue : " + floatValue);
        Debug.Log("stringValue : " + stringValue);

        intValue = int.Parse(stringValue);
        stringValue = "33.4567";
        floatValue = float.Parse(stringValue);

        Debug.Log("intValue : " + intValue);
        Debug.Log("floatValue : " + floatValue);
        Debug.Log("stringValue : " + stringValue);
        */


        /* 08. 부동 소수점과 정수 사이의 형 변환
        float floatValue = 0.9f;
        int intValue = (int)floatValue;

        Debug.Log("floatValue : " + floatValue);
        Debug.Log("intValue : " + intValue);

        floatValue = 1.1f;
        intValue = (int)floatValue;

        Debug.Log("floatValue : " + floatValue);
        Debug.Log("intValue : " + intValue);
        */


        /* 07. 크기가 서로 다른 부동 소수점 사이의 형 변환
        float floatValue = 69.6875f;
        double doubleValue = (double)floatValue;

        Debug.Log("floatValue : " + floatValue);
        Debug.Log("doubleValue : " + doubleValue);

        floatValue = 0.1f;
        doubleValue = (double)floatValue;

        Debug.Log("floatValue : " + floatValue);
        Debug.Log("doubleValue : " + doubleValue);
        */


        /* 06. 부호 있는 정수와 부호 없는 정수 사이의 형 변환
        sbyte sbyteValue = 31;
        byte byteValue = (byte)sbyteValue;

        Debug.Log("sbyteValue : " + sbyteValue);
        Debug.Log("byteValue : " + byteValue);

        // Type02. 부호 있는 정수가 음수일 때
        sbyteValue = -31;
        byteValue = (byte)sbyteValue; // 부호 없는 정수 byteValue

        Debug.Log("sbyteValue : " + sbyteValue);
        Debug.Log("byteValue : " + byteValue);

        // Type04. 부호 없는 정수가 부호 있는 정수 최대 값보다 클 때
        byteValue = 200;
        sbyteValue= (sbyte)byteValue;

        Debug.Log("sbyteValue : " + sbyteValue);
        Debug.Log("byteValue : " + byteValue);
        */


        /* 05. 크기가 서로 다른 정수(int, sbyte)
        sbyte sbyteValue = 10;
        int intValue = (int)sbyteValue;
         
        Debug.Log("sbyteValue : " + sbyteValue);
        Debug.Log("intValue : " + intValue);

        intValue = 130;
        sbyteValue = (sbyte)intValue; // sbyte -128 ~ 127이기에 오버플로우

        Debug.Log("sbyteValue : " + sbyteValue);
        Debug.Log("intValue : " + intValue);
        */


        /* 04. 오브젝트 변수
        object valueInt = 31;                       // 박싱 (데이터 저장)
        object valueFloat = 3.14159265358979f;
        object valueString = "객체지향 프로그래밍";
        object valueBool = false;

        Debug.Log("정수 : " + valueInt);            // 언박싱 (데이터 사용)
        Debug.Log("실수 : " + valueFloat);
        Debug.Log("문자열 : " + valueString);
        Debug.Log("논리 : " + valueBool);
        */


        /* 03. 문자열, 논리
        string stringValue = "안녕하세요. 조정원입니다.";
        bool boolValue = true;

        Debug.Log("string Data : " + stringValue);
        Debug.Log("bool Data : " + boolValue);
        */


        /* 02. 실수
        float floatValue01 = 3.141592653589793238462643383279f; // 7자리 표현
        float floatValue02 = 31.41592653589793238462643383279f; // 7자리 표현
        double doubleValue = 3.141592653589793238462643383279; // 15자리 표현
        decimal decimalValue = 3.141592653589793238462643383279m; // 29자리 표현

        Debug.Log("float Data : " + floatValue01);
        Debug.Log("float Data : " + floatValue02);
        Debug.Log("double Data : " + doubleValue);
        Debug.Log("decimal Data : " + decimalValue);
        */


        /* 01. 정수
        sbyte byteValue = -128;
        byte ubyteValue = 255;
        short shortValue = -32768;
        ushort ushortValue = 65535;
        int intValue = -2147483648;
        uint uintValue = 4294967295;
        long longValue = -922337203685477508;
        ulong ulongValue = 18446744073709551615;
        char charValue = 'K';

        Debug.Log("byte Data : " + byteValue);
        Debug.Log("ubyte Data : " + ubyteValue);
        Debug.Log("short Data : " + shortValue);
        Debug.Log("ushort Data : " + ushortValue);
        Debug.Log("int Data : " + intValue);
        Debug.Log("uint Data : " + uintValue);
        Debug.Log("long Data : " + longValue);
        Debug.Log("ulong Data : " + ulongValue);
        Debug.Log("char Data : " + charValue);
        */
    }
}
