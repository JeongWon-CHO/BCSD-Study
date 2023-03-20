using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Datatype2 : MonoBehaviour
{
    private void Awake()
    {
        /* 11. 비트 연산자
        int a = 3;

        Debug.Log($"{a} << 1 = {a << 1}");
        Debug.Log($"{a} << 2 = {a << 2}");
        Debug.Log($"{a} << 3 = {a << 3}");
        Debug.Log($"{a} << 4 = {a << 4}");

        a = 255;
        Debug.Log($"{a} >> 1 = {a >> 1}");
        Debug.Log($"{a} >> 2 = {a >> 2}");
        Debug.Log($"{a} >> 3 = {a >> 3}");
        Debug.Log($"{a} >> 4 = {a >> 4}");

        a = -255;
        Debug.Log($"{a} >> 1 = {a >> 1}");
        Debug.Log($"{a} >> 2 = {a >> 2}");
        Debug.Log($"{a} >> 3 = {a >> 3}");
        Debug.Log($"{a} >> 4 = {a >> 4}");

        // 이진수 형태로 출력
        Debug.Log(Convert.ToString(a >> 4, 2));

        // 논리곱 연산자 &
        Debug.Log($"10 & 6 = {10 & 6}");

        // 논리합 연산자 |
        Debug.Log($"10 | 6 = {10 | 6}");

        // 베타적 논리합 연산자 ^
        Debug.Log($"10 ^ 6 = {10 ^ 6}");

        // 보수 연산자
        Debug.Log($"~10 = {~10}");
        */


        /* 10. 삼항 연산자
        bool result = false;
        int x = 5, y = 2;

        result = x > 2 && y != 5;
        Debug.Log($"{x} > 2 && {y} != 5 = {result}");

        result = x < 4 || y == 3;
        Debug.Log($"{x} < 4 || {y} == 3 = {result}");

        Debug.Log(result);
        result = !result;
        Debug.Log(result);

        // 조건(삼항) 연산자
        int hp = -10;
        hp = hp < 0 ? 0 : hp;
        Debug.Log("체력 : " + hp);
        */


        /* 09. 비교(관계) 연산자
        int x = 5; int y = 2;

        Debug.Log($"{x} > {y} = {x > y}");
        Debug.Log($"{x} < {y} = {x < y}");
        Debug.Log($"{x} >= {y} = {x >= y}");
        Debug.Log($"{x} <= {y} = {x <= y}");
        Debug.Log($"{x} == {y} = {x == y}");
        Debug.Log($"{x} != {y} = {x != y}");
        */


        /* 08. 증감 연산자
        int a = 10;
        Debug.Log(a);

        a++;
        Debug.Log(a);

        ++a;
        Debug.Log(a);

        Debug.Log(a++);
        Debug.Log(a);
        Debug.Log(++a);
        Debug.Log(a);
        */


        /* 07. 대입(할당) 연산자
        int a = 10;
        Debug.Log($"a = 10 : {a}");

        a += 10;
        Debug.Log($"a += 10 : 결과 값 {a}");

        // 문자열 보간의 보간식에 수식을 넣어서 연산
        Debug.Log($"a -= 9 : 결과 값 {a -= 9}");
        Debug.Log($"a *= 9 : 결과 값 {a *= 8}");
        Debug.Log($"a /= 9 : 결과 값 {a /= 7}");
        Debug.Log($"a %= 9 : 결과 값 {a %= 6}");
        Debug.Log($"a &= 9 : 결과 값 {a &= 5}");
        Debug.Log($"a |= 9 : 결과 값 {a |= 4}");
        Debug.Log($"a ^= 9 : 결과 값 {a ^= 3}");
        Debug.Log($"a <<= 9 : 결과 값 {a <<= 2}");
        Debug.Log($"a >>= 9 : 결과 값 {a >>= 1}");
        */


        /* 06. 산술 연산자
        int a = 5 + 6;
        int b = a - 3;
        int c = a * b;
        int d = c / 8;
        int e = d % 4;

        Debug.Log($"{a} = 5 + 6");
        Debug.Log($"{b} = {a} - 3");
        Debug.Log($"{c} = {a} + {b}");
        Debug.Log($"{d} = {c} / 8");
        Debug.Log($"{e} = {d} % 4");
        */


        /* 05. 문자열 분할
        string position = "3, 5, 6";
        string[] str = position.Split(',');
        Debug.Log($"{str[0]}, {str[1]}, {str[2]}");

        string str2 = "HELLO, WORLD";
        str2 = str2.Substring(7);
        Debug.Log(str2);
        */


        /* 04. 문자열 변형
        string str = "HELLO, WORLD";
        Debug.Log(str);

        str = str.ToLower();
        Debug.Log($"ToLower() - {str}");

        str = str.ToUpper();
        Debug.Log($"ToUpper() - {str}");

        str = str.Insert(0, "Hi~ ");
        Debug.Log($"Insert() - {str}");

        str = str.Remove(0, 4);
        Debug.Log($"Remove() - {str}");

        Debug.Log("== Trim ==");
        //공백 추가
        str = "    " + str + "    ";
        Debug.Log(str + "공백 체크");

        str = str.Trim();         // 문자열의 앞, 뒤 공백 제거
        //str = str.TrimStart();  // 문자열의 앞 공백 제거
        //str = str.TrimEnd();    // 문자열의 뒤 공백 제거
        Debug.Log(str + "공백 체크");

        Debug.Log($"Before Replace : {str}");
        str = str.Replace("HELLO", "BYE");
        Debug.Log($"After Replace : {str}");
        */


        /* 03. 문자열 탐색 
        string str = "Hello, World";
        Debug.Log(str);

        int numeric = str.IndexOf('o');
        Debug.Log($"o는 앞에서부터 {numeric+1}번째에 있습니다.");

        numeric = str.LastIndexOf('o');
        Debug.Log($"o는 뒤에서부터 {numeric}번째에 있습니다.");

        bool isTrue = str.StartsWith("Hello");
        Debug.Log($"{str} 문장은 Hello부터 시작한다? {isTrue}");

        isTrue = str.StartsWith("World");
        Debug.Log($"{str} 문장은 World부터 시작한다? {isTrue}");

        isTrue = str.EndsWith("Hello");
        Debug.Log($"{str} 문장은 World로 끝난다? {isTrue}");

        isTrue = str.EndsWith("World");
        Debug.Log($"{str} 문장은 World로 끝난다? {isTrue}");

        isTrue = str.Contains("Hell");
        Debug.Log($"{str} 문장에 Hell이 포함되어 있다? {isTrue}");
        */


        /* 02. string.Format() vs 문자열 보간
        int minutes = 1;
        int seconds = 15;

        // sting.Format()
        Debug.Log(string.Format("{0}{1}{2}", minutes, ":", seconds));
        // 문자열 보간
        Debug.Log($"{minutes} : {seconds}");

        // string.Format()
        Debug.Log($"{minutes,-10:D5}");
        */


        /* 01. string.Format()을 이용한 문자열 가공
        int minutes = 1;
        int seconds = 15;

        // 서식 항목 - 맞춤
        Debug.Log(string.Format("기본 : {0}{1}{2}", minutes, ":", seconds));
        Debug.Log(string.Format("기본 : {0, -5}{1}{2}", minutes, ":", seconds));
        Debug.Log(string.Format("기본 : {0, 5}{1}{2}", minutes, ":", seconds));

        // 서식 항목 - 서식 문자열 설정 (숫자)
        Debug.Log(string.Format("10진수 서식화 : {0:D}", 123));
        Debug.Log(string.Format("10진수 서식화(5자리) : {0:D5}", 123));

        Debug.Log(string.Format("16진수 서식화 : {0:X}", 123));
        Debug.Log(string.Format("16진수 서식화(5자리) : {0:X5}", 123));

        Debug.Log(string.Format("고정소수점 서식화 : {0:F}", 1.23));
        Debug.Log(string.Format("고정소수점 서식화(소수점 1자리) : {0:F1}", 1.23));

        Debug.Log(string.Format("콤마로 구분 : {0:N}", 1234567890));
        Debug.Log(string.Format("지수 : {0:E}", 1234567890));

        // 서식 문자열 설정 (날짜)
        // DataTime dt = new DataTime(2020, 2, 22, 13, 40, 0);
        // string str = dt.ToString("yyyy-MM-dd HH:mm:ss (dddd)");
        // Debug.Log(str);
        */

    }
}
