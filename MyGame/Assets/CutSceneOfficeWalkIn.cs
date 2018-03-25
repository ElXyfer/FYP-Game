using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

public class CutSceneOfficeWalkIn : MonoBehaviour
{

    public GameObject Player;
    public Text GameText;
    CameraSwitch cameraSwitch;
    public PlayableDirector playableDirector;

    // Use this for initialization
    void Awake()
    {
        cameraSwitch = GetComponent<CameraSwitch>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Start_OfficeWalkIn()
    {
        Player.SetActive(false);
        cameraSwitch.changeCamera(1);
        playableDirector.Play();
    }


}
