using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour
{
    // ������ �̸��� ���ڷ� �����ؼ��� �ȵȴ�.
    // ������ Ư�����ڴ� _��$�� ���ȴ�.

    //if��
/*
    if(value_2 > 1)
    {
        print("1���� Ů�ϴ�");
    }
        else if (12 == 12)
    {
    print("�����ϴ�.");
    }
*/

    //�ν����� ����
    public GameObject prefab;

    //public : ��ũ��Ʈ �ȿ��� ������ �����̳� ���� ������Ʈ�� Ȯ���� �� �ִ�.
    //private : ��ũ��Ʈ ���ο� �ִ� ������ �����̳� ���� ������Ʈ �������� �ʵ��� �����մϴ�.
    public void GenericCreate()
    {
        //Instantiate : ���� ������Ʈ�� �����ϴ� �Լ�
        Instantiate(prefab, new Vector3(0, 5, 0), Quaternion.identity);
    }

    public void PoolCreate()
    {
        ObjectPool.objpool.GetQueue();
    }
}
