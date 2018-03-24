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
    public GameObject WalkOut;
    public GameObject WalkInOffice;

    CutSceneController fpScript;
    CameraSwitch cameraSwitch;
    PlayerController playerController;
    CutScene cutScene;

    // Use this for initialization
    void Awake()
    {
        anim = GetComponent<Animator>();
        fpScript = Player.GetComponent<CutSceneController>();
        cutScene = WalkOut.GetComponent<CutScene>();
        playerController = Player.GetComponent<PlayerController>();
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
                cutScene.Start_WalkOut();
                anim.SetTrigger("KeepOpen");
                doorIsOpen = false;
            }

        } else if(this.gameObject.tag == "OfficeDoor") {
            print("Talking to friend");
        } 
    }

	private void OnTriggerStay(Collider other)
	{
        if (this.gameObject.tag == "Test")
        {
            if (Input.GetKeyDown(KeyCode.U))
            {
                playerController.enabled = false;
            }
        }
	}


	void AwakeEnemy()
    {
        enemy.gameObject.SetActive(true);
    }

    //void OnTriggerStay(Collider other) {
    //    anim.SetTrigger("KeepOpen");
    //}

    //void OnTriggerExit(Collider other) {
    //        anim.SetTrigger("Close");
    //        doorIsOpen = false;
    //} 

}
