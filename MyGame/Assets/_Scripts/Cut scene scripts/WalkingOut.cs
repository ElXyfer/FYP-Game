using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WalkingOut : MonoBehaviour {

    public GameObject player;
    public GameObject enemy, AnimatedEnemy;
    CameraSwitch cameraSwitch;
    public Text GameText;

	// Update is called once per frame
	void Awake () {
        cameraSwitch = GetComponent<CameraSwitch>();
	}

    public void AnimationComplete2()
    {
        print("Animation complete");
        player.SetActive(true);
        cameraSwitch.changeCamera(1);
        player.transform.position = new Vector3(36, 0, -2.2f);
        player.transform.Rotate(Time.deltaTime, -90, 0);
        enemy.SetActive(true);
        Destroy(AnimatedEnemy, 0f);
        GameText.text = "";

    }
}
