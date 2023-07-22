using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterPatten : MonoBehaviour
{

    public GameObject Monster;
    float PositionX = 0;
    float PositionZ = 0;
    float randompositionX = 0;
    float randompositionZ = 0;
    float speed = 0.5f;
    

    // Start is called before the first frame update
    void Start()
    {
        PositionX = Monster.transform.position.x;
        PositionZ = Monster.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(random());
        if (PositionX > randompositionX)
        {
            speed = -speed;
        }
        else if (PositionX < randompositionX)
        {
            speed = -speed;
        }
        if (PositionZ > randompositionZ)
        {
            speed = -speed;
        }
        else if (PositionZ < randompositionZ)
        {
            speed = -speed;
        }
        Monster.transform.position += new Vector3(speed, 0, speed);
    }

    IEnumerator random()
    {
        randompositionX = Random.Range(-10, 10);
        randompositionZ = Random.Range(-10, 10);
        yield return null;
    }

    


















    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.tag == "Bullet")
    //    {
    //        Destroy(gameObject);
    //    }

    //   }
}
