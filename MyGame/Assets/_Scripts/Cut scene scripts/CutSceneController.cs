using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;

public class CutSceneController : MonoBehaviour {

	Animator anim;
    public GameObject Player;
	public PlayableDirector walkInScene;
	public GameObject capsulGO;
	private AgentScript agentScript;
	private CameraSwitch cameraSwitch;
    public GameObject switchCamObjReference;



	void Awake () {
		anim = GetComponent<Animator>();
		agentScript = capsulGO.GetComponent<AgentScript>();
        cameraSwitch = switchCamObjReference.GetComponent<CameraSwitch>();
	}

	public void SwitchCam_PlayScene(){
		cameraSwitch.changeCamera(1);
        walkInScene.Play();
		agentScript.startNavMesh();
	}

}
