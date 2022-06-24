using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    //�ڷᱸ��
    // Queue : ���� ���� ���� �����Ͱ� ���� ���� ������ �����Դϴ�.
    // static : ������ ����� �� ���� �޸𸮿� ���� �ֽ��ϴ�.

    public static ObjectPool objpool;

    public GameObject prefab;

    public Queue<GameObject> queue = new Queue<GameObject>();



    public void Start()
    {
        
        //1. �ʱⰪ ����
        //2. ���ǽ� ����
        //3. ��ɹ��� �ѹ� �����մϴ�.
        //4. �ʱⰪ�� ������ŵ�ϴ�.
        for(int i = 0; i < 5; i++)
        {
            GameObject tempPrefab = Instantiate(prefab, new Vector3(0, 5, 0), Quaternion.identity);
            queue.Enqueue(tempPrefab);
            tempPrefab.SetActive(false);
        }
        
    }

    public void InsertQueue(GameObject tObject)
    {
        queue.Enqueue(tObject);
        tObject.SetActive(false);
    }

    public GameObject GetQueue()
    {
        GameObject temeObject = queue.Dequeue();
        temeObject.SetActive(true);

        return temeObject;
    }
   
}
