using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Puzzle : MonoBehaviour, IPointerExitHandler, IPointerEnterHandler {

    public Image[] myImages;

    public void OnPointerEnter(PointerEventData data)
    {
        Debug.Log("OnPointerEnter called.");

        foreach(Image image in myImages) {
            image.color = Color.blue;
        }


    }


    public void OnPointerExit(PointerEventData data)
    {
        Debug.Log("OnPointerExit called.");
        foreach (Image image in myImages)
        {
            image.color = Color.red;
        }


        //Vector2 mousePosition = new Vector2(195.0f, 591.7f);  // trying to reset mouse position

    }
}
