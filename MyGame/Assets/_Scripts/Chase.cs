using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : MonoBehaviour {

	public Transform player;
	public Transform head;
	Animator anim;

	string state = "patrol";
	public GameObject[] waypoints;
	int currentWP = 0;
	public float rotSpeed = 0.2f;
	public float speed = 1.5f;
	float accuracyWP = 2.0f;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

		// work out the direction the player is to gaurd
		Vector3 direction = player.position - this.transform.position;

		// looking at angle between player and guard on y axis
		direction.y = 0;
		float angle = Vector3.Angle(direction, head.up);


			if(state == "patrol" && waypoints.Length > 0)
			{ 
				// start walking
				anim.SetBool("isIdle", false);
				anim.SetBool("isAttacking", false);

				// checks distance between guard and waypoint
				if(Vector3.Distance(waypoints[currentWP].transform.position, transform.position) < accuracyWP)
				{
					currentWP++;
					if(currentWP >= waypoints.Length)
					{
						currentWP = 0;
					}
				}

					// rotate guard to waypoint
					direction = waypoints[currentWP].transform.position - transform.position;

					// move guard to waypoint
					this.transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), rotSpeed * Time.deltaTime);
					this.transform.Translate(0,0, Time.deltaTime * speed);
			}

			if(Vector3.Distance(player.position, this.transform.position) < 10 && angle < 90 || state == "persuing")
			{
				// start walking and chasing
				state = "persuing";

				this.transform.rotation = Quaternion.Slerp(this.transform.rotation,Quaternion.LookRotation(direction), 0.1f);

				// if close, attack
				if(direction.magnitude > 1.5)
				{
					this.transform.Translate(0,0,0.05f);
					anim.SetBool("isWalking", true);
					anim.SetBool("isAttacking", false);

				}
				else 
				{
					anim.SetBool("isAttacking", true);
					anim.SetBool("isWalking", false);
				}
			} 
			else 
			{	
				anim.SetBool("isWalking", true);
				anim.SetBool("isAttacking", false);
				state = "patrol";
			}
		}
	}
		

