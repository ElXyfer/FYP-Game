using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour {

	public List<Camera> cameras = new List<Camera>();
    public int playerScore = 100;

	void Awake () {
		
	}


	public void changeCamera(int desiredActiveCamera)
	{
		// provided camera is < the number of cameras, add 1
	    for (int camera = 0; camera < cameras.Count; camera++)
	    {
	    	// if (parameter) matches camera, set desiredActive camera to true 
	        cameras[camera].gameObject.SetActive(desiredActiveCamera == camera);
	    }
	}

}