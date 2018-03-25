using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutSceneManager : MonoBehaviour {

    public GameObject player;

    CameraSwitch cameraSwitch;
	// Use this for initialization
	void Awake () {
        cameraSwitch = GetComponent<CameraSwitch>();
	}
	
	// Update is called once per frame
	void Update () {

	}

    public void End_WalkInToOffice(){
        player.SetActive(true);
        cameraSwitch.changeCamera(1);
        player.transform.position = new Vector3(22, 0, -8.5f);
        player.transform.Rotate(Time.deltaTime, -154, 0);
    }

}
