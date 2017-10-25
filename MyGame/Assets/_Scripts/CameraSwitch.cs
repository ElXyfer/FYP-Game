using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour {

	public List<Camera> cameras = new List<Camera>();

	void Awake () {
		
	}


	public void changeCamera(int currentCamera) {
		// Set current camera to false, set new camera to true
		//cameras[0].gameObject.SetActive(false);
		//cameras[1].gameObject.SetActive(true);
		for (int camera = 0; camera < cameras.Count + 1; camera++) {
			// if current item is not the last item
			if (cameras[camera] != cameras[cameras.Count - 1]) {
				// if the index matches the current camera, sets current camera to false, sets the camera to true
				if (camera == currentCamera) {
					cameras[camera].gameObject.SetActive(false);
					cameras[camera + 1].gameObject.SetActive(true);
				}
			}
			break;
		}
	}

}