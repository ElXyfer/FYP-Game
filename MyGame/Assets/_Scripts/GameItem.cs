using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameItem : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		if(this.gameObject.tag == "Fruit"){
			Destroy(this.gameObject);
		}

		if(this.gameObject.tag == "Grape"){
			Destroy(this.gameObject);
		}
	}




}
