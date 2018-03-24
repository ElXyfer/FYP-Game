using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

public class CutScene : MonoBehaviour {

    public GameObject Player;
    CameraSwitch cameraSwitch;
    public PlayableDirector[] playableDirector;
    public Text GameText;

	// Use this for initialization
	void Awake () {
        cameraSwitch = GetComponent<CameraSwitch>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Start_WalkOut()
    {
        Player.SetActive(false);
        cameraSwitch.changeCamera(1);
        playableDirector[0].Play();
        GameText.text = "Press the space bar to attack.";
    }

	public void Start_OfficeWalkIn()
	{
        Player.SetActive(false);
        cameraSwitch.changeCamera(1);
        playableDirector[1].Play();
        		
	}
}
