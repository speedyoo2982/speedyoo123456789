using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject Monster;

    float RandomX = 0;
    float RandomZ = 0;
    float MonsterSpawnTime = 1.5f;
    float Monster_Time = 0;

    public int MonsterCount = 0;
    public int MonsterMaxCount = 100;

    bool no = false;

    bool test3 = false;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(test1());
        StartCoroutine(test());
    }

    // Update is called once per frame
    void Update()
    {
        Monster_Time += Time.deltaTime;
        if (Monster_Time > MonsterSpawnTime) 
        {
            if(MonsterMaxCount>MonsterCount)
            {
                StartCoroutine(MonsterSpawn());
            }
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
        MonsterCount += 1;
        
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
            Debug.Log("��¥ �̳� �� ¿�� ���̴� ����");
            yield return new WaitForSecondsRealtime(2);
            yield return new WaitUntil(() => (no));
            Debug.Log("��¥ �̳� �� ¿�� ���̰� ���ְ� �������� ����");
        }
    }

    IEnumerator test1()
    {

        yield return new WaitUntil(() => (test3));
        Debug.Log("m�� ��������!");

    }

    int test2()
    {
        return 99;
    }

  
}
