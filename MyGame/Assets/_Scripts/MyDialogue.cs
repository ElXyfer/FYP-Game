using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyDialogue : MonoBehaviour
{

    public GameObject dialogueBox;
    public Dialogue dialogue;
    public static int InteractionCounter;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay(Collider other)
    {
        dialogueBox.SetActive(true);
        if (this.gameObject.tag == "Test")
        {
            FindDialogueSystem();

        }

    }

    void OnTriggerExit(Collider other)
    {
        if (this.gameObject.tag == "Test")
        {
            dialogueBox.SetActive(false);
        }
    }

    void FindDialogueSystem()
    {
        FindObjectOfType<DialogueSystem>().StartDialogue(dialogue);
    }
}
