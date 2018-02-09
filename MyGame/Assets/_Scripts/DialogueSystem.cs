using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueSystem : MonoBehaviour
{

    public Text nameText, dialogueText;
    public Button continueButton;

    Dialogue tsDialogue;

    int clickCounter;
    int clickCountIndex;
    int sentenceCount;
    int secondSentencesCount;
    int thirdSentencesCount;


    private void Start()
    {

        continueButton.onClick.AddListener(() => ButtonClick());

    }



    public void ButtonClick()
    {

        clickCounter++;
        clickCountIndex = clickCounter - 1;


            if (clickCountIndex < sentenceCount)
            {
                dialogueText.text = tsDialogue.setences[clickCountIndex];
                if (clickCountIndex == tsDialogue.setences.Length - 1)
                {
                    clickCounter = 0;

                    //if (MyDialogue.InteractionCounter == 2)
                    //{
                    //    dialogueText.text = "Would you like to enter?";
                    //    contBtnText.text = "No";
                    //    dialogueBox.SetActive(true);

                    //}
                    //else if (MyDialogue.InteractionCounter == 3)
                    //{
                    //    dialogueBox.SetActive(false);
                    //}
                    //else if (MyDialogue.InteractionCounter == 4)
                    //{
                    //    ActiveQuest = false;
                    //    dialogueBox.SetActive(false);
                    //}
                    //else
                    //{
                    //    dialogueBox.SetActive(false);
                    //}
                }
            }


        //    if (clickCountIndex < secondSentencesCount)
        //    {
        //        if (MyDialogue.InteractionCounter == 2)
        //        {
        //            clickCounter = 0;
        //            ActiveQuest = false;
        //            RevertToContinueState();
        //            hasEngaged = true;
        //        }
        //        dialogueText.text = tsDialogue.secondRoundSetences[clickCountIndex];
        //        if (clickCountIndex == tsDialogue.secondRoundSetences.Length - 1)
        //        {
        //            dialogueBox.SetActive(false);
        //            clickCounter = 0;
        //        }
        //    }




    } // Button click end



    public void StartDialogue(Dialogue dialogue)
    {
        tsDialogue = dialogue;

        nameText.text = dialogue.name;

        sentenceCount = tsDialogue.setences.Length;

        secondSentencesCount = tsDialogue.secondRoundSetences.Length;

        thirdSentencesCount = tsDialogue.thirdRoundSetences.Length;

    }




}
