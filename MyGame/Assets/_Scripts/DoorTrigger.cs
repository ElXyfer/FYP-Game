using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour {

	Animator anim;
	private bool doorIsOpen = false;
	private FPScript fpScript;

	public GameObject doorObject;



	// Use this for initialization
	void Awake () {
		anim = GetComponent<Animator>();
		fpScript = doorObject.GetComponent<FPScript>();
	}


	void OnTriggerEnter(Collider other) {
		if(this.gameObject.tag == "Door1") {
			anim.SetTrigger("Open");
			doorIsOpen = true;
			if(doorIsOpen)
			{	
				anim.SetTrigger("KeepOpen");
				fpScript.SwitchCam_PlayScene();
			}	
		} else if(this.gameObject.tag == "Door2" && Inventory.FruitAmount == 1) {
				print("show message");
				anim.SetTrigger("Open");
		}
	}

	void OnTriggerStay(Collider other) {
		anim.SetTrigger("KeepOpen");
	}

	void OnTriggerExit(Collider other) {
			anim.SetTrigger("Close");
			doorIsOpen = false;
	} 

}
