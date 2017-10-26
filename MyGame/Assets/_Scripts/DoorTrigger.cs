using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour {

	Animator anim;
	private bool doorIsOpen = false;
	private FPScript fpScript;
	public GameObject fpCam;



	// Use this for initialization
	void Awake () {
		anim = GetComponent<Animator>();
		fpScript = fpCam.GetComponent<FPScript>();
	}


	void OnTriggerEnter(Collider other) {
		
			anim.SetTrigger("Open");
			doorIsOpen = true;
			if(doorIsOpen)
			{	
				anim.SetTrigger("KeepOpen");
				fpScript.SwitchCam_PlayScene();

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
