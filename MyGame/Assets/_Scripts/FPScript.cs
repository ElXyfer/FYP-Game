using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;

public class FPScript : MonoBehaviour {

	Animator anim;
	public PlayableDirector playableDirector;
	public GameObject capsulGO;
	private AgentScript agentScript;
	private CameraSwitch cameraSwitch;
	public GameObject fpcam;

	void Awake () {
		anim = GetComponent<Animator>();
		agentScript = capsulGO.GetComponent<AgentScript>();
		cameraSwitch = fpcam.GetComponent<CameraSwitch>();
	}

	public void SwitchCam_PlayScene(){
		cameraSwitch.changeCamera(1);
		playableDirector.Play();
		agentScript.startNavMesh();
	}

}
