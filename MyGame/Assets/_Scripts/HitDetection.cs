using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitDetection : MonoBehaviour {

	public float EnemyHealth;
	public GameObject enemy;
	public Transform objectLocation;
	public GameObject lockerKey;

	Animator anim;
    public GameObject convoLink;
    Conversation convo;

    private CameraSwitch cameraSwitch;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
        convo = convoLink.GetComponent<Conversation>();
        cameraSwitch = GetComponent<CameraSwitch>();
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
		if(EnemyHealth <= 0){
			anim.SetBool("Defeated", true);
           
			Invoke ("DestroyObject", 2);
		}
	}

	public void DestroyObject(){
        Inventory.ItemAmmount++;
        cameraSwitch.changeCamera(1);
        convo.Start_Conversation();
        print(Inventory.ItemAmmount);
        Destroy(enemy);


	}



}
