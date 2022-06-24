using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    //자료구조
    // Queue : 가장 먼저 들어온 데이터가 가장 먼저 나가는 구조입니다.
    // static : 게임이 종료될 때 까지 메모리에 남아 있습니다.

    public static ObjectPool objpool;

    public GameObject prefab;

    public Queue<GameObject> queue = new Queue<GameObject>();



    public void Start()
    {
        
        //1. 초기값 설정
        //2. 조건식 설정
        //3. 명령문을 한번 실행합니다.
        //4. 초기값을 증감시킵니다.
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
