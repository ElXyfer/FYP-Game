﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovePuzzle : MonoBehaviour {

    public GameObject puzzleBoard;
    public static float speed = 165f;
    public List<Image> myImages = new List<Image>();
    public static int puzzleisComplete;
    public GameObject Player;
    public GameObject WalkInOffice;
    public Text GameText;

    public GameObject[] path;

    PlayerController playerController;
    CutSceneOfficeWalkIn csOfficeWalkIn;

    void Awake()
    {
        csOfficeWalkIn = WalkInOffice.GetComponent<CutSceneOfficeWalkIn>();
        playerController = Player.GetComponent<PlayerController>();


    }


    void Update()
    {
        var move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        transform.position += move * speed * Time.deltaTime;
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("MiniGame1"))
        {
            foreach (Image image in myImages)
            {
                image.color = Color.blue;
             }
        } else if (other.gameObject.CompareTag("Fruit"))
        {
            this.gameObject.transform.localPosition = new Vector2(-455f, 217f);
            puzzleisComplete++;
            puzzleBoard.SetActive(false);
            if(puzzleisComplete == 1) {
                callWalkInScene();
            } else if (puzzleisComplete == 3) {
                playerController.enabled = true;
                GameText.text = "Safe unlocked ! and there was a book inside! Press B to read it";
                print("safe unlocked");
            }


             Debug.Log("Fruity");
        }

    }


    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("MiniGame1"))
        {
            foreach (Image image in myImages)
            {
                image.color = Color.red;
                this.gameObject.transform.localPosition = new Vector2(-455f, 233f);
                Debug.Log("out");
            }
        }
    }

    void callWalkInScene() {
        csOfficeWalkIn.Start_OfficeWalkIn();
    }

    public void firstMaze() {
            path[1].SetActive(false);
    }

    public void secondMaze()
    {
        path[0].SetActive(false);
        path[1].SetActive(true);
    }


} // x -445 y 233
