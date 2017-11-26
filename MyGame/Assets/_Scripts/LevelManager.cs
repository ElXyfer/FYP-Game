using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // from the end of the walk animation
	void AnimationComplete() {

		SceneManager.LoadScene("Basement");
	}

	void OnTriggerEnter(Collider col){
		
//	    if(col.gameObject.tag == "Character"){
//			SceneManager.LoadScene("CutScene_1");
//	  }

		if(this.gameObject.tag == "R2Door2"){
			SceneManager.LoadScene("Main");
	  }
	}

}
