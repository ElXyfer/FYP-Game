using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookScript : MonoBehaviour {

    public GameObject CameraPivot;
    public GameObject Book;
    public Transform overShoulder;
    Book BookController;
    bool BookIsActive;

    Animator anim;
    PlayerController playerController;

	// Use this for initialization
	void Awake () {
        BookController = Book.GetComponent<Book>();
        anim = GetComponent<Animator>();
        playerController = GetComponent<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
      //  LookAtBook();
        if(BookIsActive) {
            ResetBookState();
        }
    }

    public void LookAtBook() {
        CameraPivot.transform.localEulerAngles = new Vector3(38.16f, -16.84f, 0f);
        CameraPivot.transform.position = overShoulder.position;
        Book.SetActive(true);
        BookIsActive = true;
        playerController.enabled = false;
        print("Done");
    }

    //public void PlayBookAnimation(){
    //   // Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
    //   // print(mousePosition);
    //    ResetBookState();
    //}

    public void ResetBookState() {
        if (BookController.currentPage == 2)
        {
            BookIsActive = false;
            BookController.currentPage = 0;
            playerController.enabled = true;
            Book.SetActive(false);
            anim.enabled = true;
            anim.SetBool("bookisOpen", false);
            CameraPivot.transform.localPosition = new Vector3(0f, 1.9f, -3.42f);
            CameraPivot.transform.localEulerAngles = new Vector3(0f, 0f, 0f);
            print("Book status" + BookIsActive);
        }
    }
}
