using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitDetection : MonoBehaviour {

	public float EnemyHealth;
	public GameObject enemy;
	Animator anim;

	void OnTriggerEnter(Collider other)
	{
			EnemyHealth -= 1f;
	}
	// Use this for initialization
	void Start () {
		
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if(EnemyHealth <= 0){
			anim.SetBool("Defeated", true);
			//Destroy(enemy);
		}
	}
}
