using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	// public var so you can make eddits in the controller
	public float speed;
	public Text countText;
	public Text winText;
	// Private var creates "rb" which calls on Rigidbody
	private Rigidbody rb;

	private int count;

	//private GameObject pickup;

	void Start () {
		// 
		rb = GetComponent<Rigidbody>();

		count = 0;
		SetCountText();
		winText.text = "";
	}

	void FixedUpdate () {

		// This gets input from keyboard 
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		// moveHor(x) & moveVer(z) will determain the direction of the force to move in
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f,moveVertical);


		rb.AddForce(movement * speed);

	}

		void OnTriggerEnter (Collider other) {
			if(other.gameObject.CompareTag("PickUp")) 
				other.gameObject.SetActive (false);
				count = count + 1;
				SetCountText();
			}


		void SetCountText () {
			countText.text = "Count: " + count.ToString();
			if(count >= 12) {
				winText.text = "You win";
			}
		}

		}


