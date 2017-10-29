using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	Animator anim;

	 float vert;
	 float hori;
	 float run;
	 float runTurn;
//	/float speed = 3f;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		vert = Input.GetAxis("Vertical");
		hori = Input.GetAxis("Horizontal");

		Sprinting();
	}

	void FixedUpdate() {
		anim.SetFloat("Walk", vert);
		anim.SetFloat("Turn", hori);
		anim.SetFloat("Run", run);
		anim.SetFloat("RunTurn", runTurn);

	}

	void Sprinting() {
		if(Input.GetKey("space")) {
			run = 0.2f;
			if(run >= 0.2){
				anim.SetFloat("RunTurn", hori);
			}
		} else {
			run = 0.0f;
		}
	}
}
