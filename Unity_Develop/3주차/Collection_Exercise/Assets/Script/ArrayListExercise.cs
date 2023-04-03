using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using UnityEngine;

public class ArrayListExercise : MonoBehaviour
{
    private void Awake()
    {
        
        ArrayList arrayList = new ArrayList();

        // 요소 추가 (순차)
        Debug.Log(arrayList.Add(10));
        
        // 데이터 출력
        PrintArrayList(arrayList);

        // 요소 추가 (원하는 위치)
        arrayList.Insert(1, 100); // 1번 위치에 100을 추가

        // 데이터 출력
        PrintArrayList(arrayList);

        // 요소 추가 (범위, ICollection)
        Collection<int> data = new Collection<int>();
        data.Add(1);
        data.Add(3);
        data.Add(2);
        arrayList.AddRange(data);

        // 데이터 출력
        PrintArrayList(arrayList);

        // 데이터 정렬 (정수 데이터만 있을 때 한정으로 사용 가능)
        // 그 외의 데이터가 들어가면 에러 발생
        arrayList.Sort();

        // 요소 삭제 (매개변수에 입력된 데이터)
        arrayList.Remove(10);

        // 데이터 출력
        PrintArrayList(arrayList);

        // 요소 삭제 (매개변수에 입력된 위치의 요소)
        arrayList.RemoveAt(0);

        // 데이터 출력
        PrintArrayList(arrayList);

        // 요소 삭제 (첫 번째 매개변수 위치부터 두 번째 매개변수 개수만큼 삭제)
        arrayList.RemoveRange(0, 2);

        // 데이터 출력
        PrintArrayList(arrayList);

        // 모든 요소 삭제
        arrayList.Clear();

        // 요소 개수 출력
        Debug.Log(arrayList.Count);


    }

    public void PrintArrayList(ArrayList list)
    {
        Debug.Log("===============================");

        for (int i=0; i<list.Count; i++)
        {
            Debug.Log($"list[{i}] = {list[i]}");
        }
    
    
    }
}
