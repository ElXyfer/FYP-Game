using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;


public class DoorTrigger : MonoBehaviour {

	private bool doorIsOpen = false;
	Animator anim;
	//public Camera FirstPersonCam, MainCam;

	public List<Camera> cameras = new List<Camera>();
	public GameObject capsulGO;
	private AgentScript agentScript;
	public PlayableDirector playableDirector;


	// Use this for initialization
	void Awake () {
		anim = GetComponent<Animator>();
		agentScript = capsulGO.GetComponent<AgentScript>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {

			anim.SetTrigger("Open");
			doorIsOpen = true;
			if(doorIsOpen)
			{	
				cameras[0].gameObject.SetActive(false);
				cameras[1].gameObject.SetActive(true);
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
