using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationManager : MonoBehaviour {

    public GameObject Player;
    public GameObject enemy, AnimatedEnemy;
    CameraSwitch cameraSwitch;
    public Text GameText;
    GameObject mainCamera;
    GameObject cameras;
    GameObject cutScene;
    GameObject cameraManager;



	// Use this for initialization
	void Start () {
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
        cameras = GameObject.FindGameObjectWithTag("Cameras");
        cutScene = cameras.transform.Find("Cut scene B2").gameObject;
        cameraManager = GameObject.FindGameObjectWithTag("CameraManager");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AnimationComplete2()
    {
        print("Animation complete");
        Player.SetActive(true);
        Player.transform.position = new Vector3(36, 0, -2.2f);
        Player.transform.Rotate(Time.deltaTime, -90, 0);
        enemy.SetActive(true);
        AnimatedEnemy.SetActive(false);
        GameText.text = "";
        cameraManager.GetComponent<CameraManager>().GetCamera(cutScene, mainCamera);

    }
}
