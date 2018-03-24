using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovePuzzle : MonoBehaviour {

    public float speed = 1.0f;
    //public Image[] myImages;
    public List<Image> myImages = new List<Image>();

    void Update()
    {
        var move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        transform.position += move * speed * Time.deltaTime;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Test"))
        {
            foreach (Image image in myImages)
            {
                image.color = Color.blue;
                Debug.Log("in");
            }
        }

        if(other.gameObject.CompareTag("Fruit")) {
            Debug.Log("Donezo");
        }
    }


    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Test"))
        {
            foreach (Image image in myImages)
            {
                image.color = Color.red;
                this.gameObject.transform.localPosition = new Vector2(-455f, 233f);
                Debug.Log("out");
            }

        }
    }
    //    

} // x -445 y 233
