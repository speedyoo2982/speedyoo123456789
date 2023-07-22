using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject Monster;

    float RandomX = 0;
    float RandomZ = 0;
    float MonsterSpawnTime = 2f;
    float Monster_Time = 0;

    bool no = false;

    bool test3 = false;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(test1());
        StartCoroutine(test());
        StartCoroutine(MonsterSpawn());
    }

    // Update is called once per frame
    void Update()
    {
        Monster_Time += Time.deltaTime;
        if (Monster_Time > MonsterSpawnTime) 
        {
            StartCoroutine(MonsterSpawn());
            Monster_Time = 0;
        }
        int aee = 0;

        aee = test2();

        if (Input.GetKeyDown(KeyCode.M))
        {
            test3 = true;
        }

    }

    IEnumerator MonsterSpawn()
    {
        random();
        Instantiate(Monster, new Vector3(RandomX, 3.4f,RandomZ),new Quaternion());
        
        yield return null;
    }

    void random()
    {
        RandomX = Random.Range(-500, 500);
        RandomZ = Random.Range(-500, 500);


    }




    IEnumerator test()
    {
        while(true)
        {
            yield return null;
            Debug.Log("진짜 겁나 개 쩔어 보이는 문구");
            yield return new WaitForSecondsRealtime(2);
            yield return new WaitUntil(() => (no));
            Debug.Log("진짜 겁나 개 쩔어 보이고 멋있고 간지나는 문구");
        }
    }

    IEnumerator test1()
    {

        yield return new WaitUntil(() => (test3));
        Debug.Log("m을 눌렀군요!");

    }

    int test2()
    {
        return 99;
    }

  
}
