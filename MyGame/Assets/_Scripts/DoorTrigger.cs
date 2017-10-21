using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class DoorTrigger : MonoBehaviour {

	private bool doorIsOpen = false;
	Animator anim;
	public Camera FirstPersonCam, MainCam;
	public GameObject capsulGO;
	private AgentScript agentScript;


	// Use this for initialization
	void Awake () {
		anim = GetComponent<Animator>();
		agentScript = capsulGO.GetComponent<AgentScript>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {

		FirstPersonCam.gameObject.SetActive(true);
		MainCam.gameObject.SetActive(false);
		agentScript.startNavMesh();

			

			anim.SetTrigger("Open");
			doorIsOpen = true;
			if(doorIsOpen)
			{
				anim.SetTrigger("KeepOpen");
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
