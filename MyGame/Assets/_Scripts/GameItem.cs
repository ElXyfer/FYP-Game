using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameItem : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		if(this.gameObject.tag == "Fruit"){
			Destroy(this.gameObject);
		}

		if(this.gameObject.tag == "Grape"){
			other.gameObject.SendMessage("BananaPickup");
			Destroy(gameObject);
		}
	}




	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
