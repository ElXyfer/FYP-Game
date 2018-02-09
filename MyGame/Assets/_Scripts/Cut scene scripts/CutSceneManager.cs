using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutSceneManager : MonoBehaviour {

    // camera switch to CSB3 
    public GameObject camSwitchLink;
    CameraSwitch camSwitch;

    // CSB3 Camera
    public GameObject csb3Camera;
    Conversation convoScript;

	// Use this for initialization
	void Awake () {
        camSwitch = camSwitchLink.GetComponent<CameraSwitch>();
        convoScript = csb3Camera.GetComponent<Conversation>();
	}
	
	// Update is called once per frame
	void Update () {

	}

    public void PlayCSB3() {
        camSwitch.changeCamera(1);
        convoScript.Start_Conversation();
    }
}
