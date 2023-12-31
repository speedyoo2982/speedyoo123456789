﻿using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {

	[Tooltip("Furthest distance bullet will look for target")]
	public float maxDistance = 1000000;
	RaycastHit hit;
	[Tooltip("Prefab of wall damange hit. The object needs 'LevelPart' tag to create decal on it.")]
	public GameObject decalHitWall;
	[Tooltip("Decal will need to be sligtly infront of the wall so it doesnt cause rendeing problems so for best feel put from 0.01-0.1.")]
	public float floatInfrontOfWall;
	[Tooltip("Blood prefab particle this bullet will create upoon hitting enemy")]
	public GameObject bloodEffect;
	[Tooltip("Put Weapon layer and Player layer to ignore bullet raycast.")]
	public LayerMask ignoreLayer;

	public Test test_;
	public MonsterPatten MonsterPatten_;
	public UI UI_;

	private void Start()
    {
        test_= GameObject.FindObjectOfType<Test>();
		
	}

    /*
	* Uppon bullet creation with this script attatched,
	* bullet creates a raycast which searches for corresponding tags.
	* If raycast finds somethig it will create a decal of corresponding tag.
	*/
    void Update () {

		if(Physics.Raycast(transform.position, transform.forward,out hit, maxDistance, ~ignoreLayer)){
			if(decalHitWall){
				if(hit.transform.tag == "LevelPart"){
					Instantiate(decalHitWall, hit.point + hit.normal * floatInfrontOfWall, Quaternion.LookRotation(hit.normal));
					Destroy(gameObject);
				}
				if(hit.transform.tag == "Dummie"){
					Instantiate(bloodEffect, hit.point, Quaternion.LookRotation(hit.normal));
					Destroy(gameObject);
				}
				if (hit.transform.tag == "Monster")
				{
					Instantiate(bloodEffect, hit.point, Quaternion.LookRotation(hit.normal));
					Destroy(gameObject);
					UI_ = GameObject.FindObjectOfType<UI>();
					MonsterPatten_ = hit.transform.gameObject.GetComponent<MonsterPatten>();
					MonsterPatten_.Health -= 50;
					Debug.Log("아야"+MonsterPatten_.Health);
					if (MonsterPatten_.Health<=0)
                    {
						Debug.Log("죽음");
						UI_.Score += 1;
						Destroy(hit.transform.gameObject);
						

					}					
				}
			}		
			Destroy(gameObject);
		}
		Destroy(gameObject, 0.1f);
	}
}
