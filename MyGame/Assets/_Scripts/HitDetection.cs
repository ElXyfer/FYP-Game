using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitDetection : MonoBehaviour {

	public static float EnemyHealth;
	Animator anim;
    GameObject GameManager;
    CutSceneManager cutSceneManager;

	// Use this for initialization
	void Awake () {
		anim = GetComponent<Animator>();
        GameManager = GameObject.FindWithTag("CutSceneManager");
        cutSceneManager = GameManager.GetComponent<CutSceneManager>();
        EnemyHealth = 5;
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Hands") {
			EnemyHealth -= 1f;
			anim.SetBool("isHit", true);
			print("Hit" + 1);
		}
	}

	
	// Update is called once per frame
	void Update () {
		if(EnemyHealth <= 1){
			anim.SetBool("Defeated", true);
           
            Invoke ("DestroyObject", 2); // needs to go 
		}
	}

	public void DestroyObject(){ // move this to a cut scene controller
        Inventory.ItemAmmount++;

        Destroy(this.gameObject); // change time loading on this
        if(this.gameObject.tag == "EnemyV1")
            cutSceneManager.PlayCSB3();

	}

}
