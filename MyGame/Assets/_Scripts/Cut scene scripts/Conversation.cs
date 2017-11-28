using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;

public class Conversation : MonoBehaviour {

    public PlayableDirector conversationScene;
    bool isPlaying;
    public Button myBtn;
    public Text myText;

	// Use this for initialization
	void Awake () {
        
	}

  
    public void Start_Conversation()
    {
        isPlaying = true;
        conversationScene.Play();


        if(isPlaying == true) {

            //GameObject.Find("Button").GetComponentInChildren<Text>().text = "svgihshj";
            myBtn.gameObject.SetActive(true);


        }
       
            
    }

    //public void ClickTest(){
        
    //}

	
	// Update is called once per frame
	void Update () {
        if(Input.GetMouseButtonDown(0)) {
            myText.text = "ffs finally";
        }
	}
}
