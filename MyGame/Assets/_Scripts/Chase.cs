using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Chase : MonoBehaviour {

	public Transform player;
	Animator anim;

	string state = "patrol";
	public GameObject[] waypoints;
	int currentWP = 0;
	float accuracyWP = 2.0f;
    NavMeshAgent agent;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {

        if(HitDetection.EnemyHealth <= 0) return;

		// work out the direction the player is to gaurd
		Vector3 direction = player.position - this.transform.position;

		// looking at angle between player and guard on y axis
		direction.y = 0;
        float angle = Vector3.Angle(direction, this.gameObject.transform.forward);

			if(state == "patrol" && waypoints.Length > 0)
			{ 
				// start walking
				anim.SetBool("isWalking", true);
				anim.SetBool("isIdle", false);
				anim.SetBool("isAttacking", false);
				anim.SetBool("isHit", false);

				// checks distance between guard and waypoint
				if(Vector3.Distance(waypoints[currentWP].transform.position, transform.position) < accuracyWP)
				{
					// goes through waypoints
                    currentWP = Random.Range(0, waypoints.Length);
				}

                agent.SetDestination(waypoints[currentWP].transform.position);
			}

			// if distance between gaurd and player is < 10 and the angle is < 90 Degre or persuing is active 
			if(Vector3.Distance(player.position, this.transform.position) < 2 && (angle < 90 || state == "persuing"))
			{
				// start walking and chasing
				state = "persuing";

				// calculate rotaion to the player and start turning
				this.transform.rotation = Quaternion.Slerp(this.transform.rotation,Quaternion.LookRotation(direction), 0.1f);

				// if close, attack
				if(direction.magnitude > 0.9)
				{
                this.transform.Translate(0,0, Time.deltaTime * agent.speed);
                    if (agent.isActiveAndEnabled)
                    {
                        agent.SetDestination(player.transform.position);
                    }

				}
				else 
				{
					anim.SetBool("isAttacking", true);
					anim.SetBool("isWalking", false);
				}
			} 
			else 
			{	
				state = "patrol";
			}
		}
	}
		

