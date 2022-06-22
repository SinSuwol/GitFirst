using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour
{
    // 변수의 이름이 숫자로 시작해서는 안된다.
    // 변수의 특수문자는 _와$만 허용된다.

    //if문
/*
    if(value_2 > 1)
    {
        print("1보다 큽니다");
    }
        else if (12 == 12)
    {
    print("같습니다.");
    }
*/

    char value1 = 'V';
    int value_2 = 10;
    float value = 3.14f;


    //인스펙터 공개
    public GameObject prefab;

    //public : 스크립트 안에서 변수의 내용이나 게임 오프젝트를 확인할 수 있다.
    //private : 스크립트 내부에 있는 변수의 내용이나 게임 오프젝트 공개하지 않도록 설정합니다.
    public void GenericCreate()
    {
        //Instantiate : 게임 오브젝트를 생성하는 함수
        Instantiate(prefab, new Vector3(0, 5, 0), Quaternion.identity);
    }
}
