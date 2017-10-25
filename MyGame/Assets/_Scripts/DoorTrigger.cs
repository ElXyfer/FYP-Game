using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;


public class DoorTrigger : MonoBehaviour {

	Animator anim;
	public PlayableDirector playableDirector;
	public GameObject capsulGO;
	public GameObject FPCamera;

	private bool doorIsOpen = false;
	private AgentScript agentScript;
	private CameraSwitch cameraSwitch;


	// Use this for initialization
	void Awake () {

//		cameraSwitch.cameras[1].gameObject.SetActive(false);
		anim = GetComponent<Animator>();
		agentScript = capsulGO.GetComponent<AgentScript>();
		cameraSwitch = FPCamera.GetComponent<CameraSwitch>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {

			anim.SetTrigger("Open");
			doorIsOpen = true;
			if(doorIsOpen)
			{	
				cameraSwitch.changeCamera(0);
				playableDirector.Play();
				agentScript.startNavMesh();
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
