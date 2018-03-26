using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class MyTestScript : MonoBehaviour
{


    public GameObject Player;
    public GameObject MiniGame;
    public Text GameText;

    PlayerController playerController;

    // Use this for initialization
    void Awake()
    {
        playerController = Player.GetComponent<PlayerController>();
    }
	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
			
	}

	private void OnTriggerStay(Collider other)
	{
        if (this.gameObject.tag == "Safe")
        {
            GameText.text = "Press 'U' you to lock pick the safe";
            if (Input.GetKeyDown(KeyCode.U))
            {
                MovePuzzle.speed = 500f;
                MiniGame.SetActive(true);
                playerController.enabled = false;
            }
        }
	}
}
