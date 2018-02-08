using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour {

    public GameObject[] cameras;
    //CameraInformation camInfo;

	// Use this for initialization
	void Awake () {

        for (int i = 0; i < cameras.Length; i++ ) {
            var cam = cameras[i].GetComponent<CameraInformation>();
            cam.Index = i;
            print("The index is " + cam.Index);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GetCamera(GameObject currentCamera, GameObject nextCamera = null) {
        if (nextCamera != null) {
            cameras[currentCamera.GetComponent<CameraInformation>().Index].SetActive(false);
            cameras[nextCamera.GetComponent<CameraInformation>().Index].SetActive(true);
            print("im not nukl");
        } else {
            cameras[currentCamera.GetComponent<CameraInformation>().Index].SetActive(true);

            print("im  null");
        }
    }
}
