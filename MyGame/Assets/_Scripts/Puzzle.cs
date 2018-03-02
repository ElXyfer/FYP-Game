using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Puzzle : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {

    public Image[] myImages;

    private void Update()
    {
        //Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
       // print(mousePosition);
    }

    public void OnPointerEnter(PointerEventData data)
    {
        Debug.Log("OnPointerEnter called.");
        //myImage.color = Color.blue;

        foreach(Image image in myImages) {
            image.color = Color.blue;
        }


    }

    public void OnPointerExit(PointerEventData data)
    {
        Debug.Log("OnPointerExit called.");
        //myImage.color = Color.red;
        foreach (Image image in myImages)
        {
            image.color = Color.red;
        }

        Vector2 mousePosition = new Vector2(195.0f, 591.7f);

    }
}
