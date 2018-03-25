using UnityEngine;
using UnityEngine.Playables;

public class PlayerAwake : MonoBehaviour {

	private CameraSwitch cameraSwitch;
	public GameObject ethan;
	public PlayableDirector playableDirector;

	void Awake () {
	    playableDirector.Play();
	}
	// Use this for initialization
	void Start () {
		cameraSwitch = GetComponent<CameraSwitch>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void AnimationComplete1() {
		ethan.gameObject.SetActive(true);
		cameraSwitch.changeCamera(1);
	}

	
}
