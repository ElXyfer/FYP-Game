using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour {

	private bool doorIsOpen = false;
	Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {

			anim.SetTrigger("Open");
			doorIsOpen = true;
	}

	void OnTriggerStay(Collider other) {
		anim.SetTrigger("KeepOpen");
	}

	void OnTriggerExit(Collider other) {
			anim.SetTrigger("Close");
			doorIsOpen = false;
	} 

}
