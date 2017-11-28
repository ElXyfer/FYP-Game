using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

public class DoorTrigger : MonoBehaviour
{

    Animator anim;
    bool doorIsOpen = false;
    public GameObject Player;
    public GameObject enemy;

    CutSceneController fpScript;
    CameraSwitch cameraSwitch;
    public PlayableDirector playableDirector;
    public Text GameText;

    // Use this for initialization
    void Awake()
    {
        anim = GetComponent<Animator>();
        fpScript = Player.GetComponent<CutSceneController>();
        cameraSwitch = GetComponent<CameraSwitch>();
    }


    void OnTriggerEnter(Collider other)
    {
        if (this.gameObject.tag == "Door1")
        {
            anim.SetTrigger("Open");
            doorIsOpen = true;
            if (doorIsOpen)
            {
                anim.SetTrigger("KeepOpen");
                fpScript.SwitchCam_PlayScene();
                doorIsOpen = false;
            }
        } else if (this.gameObject.tag == "Door2" && Inventory.ItemAmmount >= 1) { // change/ fix this to be = 1, inventory bug
            
            doorIsOpen = true;
            anim.SetTrigger("Open");
            //Invoke("AwakeEnemy", 5);
            if (doorIsOpen == true)
            {
                Start_WalkOut();
                anim.SetTrigger("KeepOpen");
                doorIsOpen = false;
            }

        }
        else if (this.gameObject.tag == "DoorLocker")
        {
            doorIsOpen = true;
            anim.SetTrigger("Open");
        }
    }


    void AwakeEnemy()
    {
        enemy.gameObject.SetActive(true);
    }

    public void Start_WalkOut(){
        cameraSwitch.changeCamera(1);
        playableDirector.Play();
        GameText.text = "Press the space bar to attack.";

    }

    //void OnTriggerStay(Collider other) {
    //    anim.SetTrigger("KeepOpen");
    //}

    //void OnTriggerExit(Collider other) {
    //        anim.SetTrigger("Close");
    //        doorIsOpen = false;
    //} 

}
