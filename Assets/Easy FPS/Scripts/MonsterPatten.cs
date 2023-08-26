using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterPatten : MonoBehaviour
{
    float PositionX = 0;
    float PositionZ = 0;
    float randompositionX1 = 0;
    float randompositionX2 = 0;
    float randompositionZ1 = 0;
    float randompositionZ2 = 0;
    float speedX = 0;
    float speedZ = 0;
    public float MonsterSpeed = 0.2f;
    public int Health = 100;

    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(random());
    }

    // Update is called once per frame
    void Update()
    {
        PositionX = transform.position.x;
        PositionZ = transform.position.z;

        if (PositionX > randompositionX1)
        {
            speedX = -MonsterSpeed;
        }
        else if (PositionX < randompositionX2)
        {
            speedX = MonsterSpeed;
        }
        if (PositionZ > randompositionZ1)
        {
            speedZ = -MonsterSpeed;
        }
        else if (PositionZ < randompositionZ2)
        {
            speedZ = MonsterSpeed;
        }
        transform.position += new Vector3(speedX, 0, speedZ);
    }

    IEnumerator random()
    {
        randompositionX1 = Random.Range(0, 500);
        randompositionX2 = Random.Range(-500, 0);
        randompositionZ1 = Random.Range(0, 500);
        randompositionZ2 = Random.Range(-500, 0);
        yield return null;
    }

   
   
}

