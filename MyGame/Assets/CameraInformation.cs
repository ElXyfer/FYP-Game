using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraInformation : MonoBehaviour {

    int index;
    public GameObject NextCamera;

    public int Index
    {
        get
        {
            return index;
        }

        set
        {
            index = value;
        }
    }


    public void TriggerNextCamera() {
        GameObject.FindGameObjectWithTag("CameraManager").GetComponent<CameraManager>().GetCamera(gameObject, NextCamera);
    }
}
