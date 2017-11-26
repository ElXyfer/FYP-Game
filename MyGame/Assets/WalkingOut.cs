using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingOut : MonoBehaviour {

    public Transform player;
    public GameObject enemy, AnimatedEnemy;
    CameraSwitch cameraSwitch;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        cameraSwitch = GetComponent<CameraSwitch>();
	}

    public void AnimationComplete2()
    {
        print("Animation complete");
        cameraSwitch.changeCamera(1);
        player.position = new Vector3(36, 0, -2.2f);
        player.Rotate(Time.deltaTime, -90, 0);
        enemy.SetActive(true);
        AnimatedEnemy.SetActive(false);

    }
}
