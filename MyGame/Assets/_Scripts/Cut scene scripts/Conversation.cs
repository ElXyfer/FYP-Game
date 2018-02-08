using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;

public class Conversation : MonoBehaviour
{

    public PlayableDirector conversationScene;
    bool isPlaying;
    public Button myBtn;
    public Text myText;
    int clickCounter;
    CameraSwitch cameraSwitch;

    // Use this for initialization
    void Awake()
    {
        cameraSwitch = GetComponent<CameraSwitch>();
    }


    public void Start_Conversation()
    {
        isPlaying = true;
        conversationScene.Play();


        if (isPlaying == true)
        {

            //GameObject.Find("Button").GetComponentInChildren<Text>().text = "svgihshj";
            myBtn.gameObject.SetActive(true);


        }


    }

    //public void ClickTest(){

    //}


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1) || Input.GetMouseButtonDown(2))
        {
            myText.text = "Omg please help me";
            clickCounter++;
        }

        DialogScene();

    }

    void DialogScene()
    {
        if (clickCounter == 2)
        {
            myText.text = "Wait who are you?";
        }
        else if (clickCounter == 3)
        {
            myText.text = "Never mind your name, can you help me get out of here?";
        }
        else if (clickCounter == 4)
        {
            myText.text = "Me and the others have been stuck here for god knows how long !";
        }
        else if (clickCounter == 5)
        {
            myText.text = "...";
        }
        else if (clickCounter == 6)
        {
            myText.text = "Why won't you answer me?";
        }
        else if (clickCounter > 6)
        {
            myText.text = "";
            EndScene();
           
        }

    }

    void EndScene()
    {
        isPlaying = false;
        if (isPlaying == false)
        {
            myBtn.gameObject.SetActive(false);
        }
        cameraSwitch.changeCamera(1);

    }

} // trying again