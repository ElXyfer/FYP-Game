using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private Animator anim;

    public float speed;
	public float sprintSpeed;

	public float rotationSpeed = 100.0f;
	bool isMoving = false;
	
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}


	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown("space")) {
			anim.SetBool("isAttacking", true);
		}

        if (Input.GetKeyDown(KeyCode.B))
        {
            anim.SetBool("bookisOpen", true);
        }

		float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);

        if(translation != 0) {
			isMoving = true;
			//if(isMoving == true){
				speed = 1f;
        	anim.SetBool("isWalking", true);
            anim.SetBool("bookisOpen", false);
            anim.SetBool("isRunning", false);

        	if(Input.GetKey(KeyCode.Z)){
        		anim.SetBool("isRunning", true);
        		speed = sprintSpeed;
        	}
        	//}

        } else {
            anim.SetBool("isWalking", false);
        }
	}

	public void EnemyIsDead(){
        if(HitDetection.EnemyHealth <= 0){
			anim.SetBool("isIdle", true);
		}
	}

    void OpenBook() {
        

    }






}
