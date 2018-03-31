using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent (typeof(AudioSource))]

public class Inventory : MonoBehaviour
{

    public static int ItemAmmount; // why -1?
    public GameObject inventoryPanel;
    public GameObject[] inventoryIcons;
    public GameObject pointLight;
    public Text GameText;

    void OnTriggerEnter(Collider item)
    {
        GameObject gameItem;
        if (item.gameObject.tag == "Fruit")
        {
            ItemAmmount = 1;
            gameItem = Instantiate(inventoryIcons[0]);
            gameItem.transform.SetParent(inventoryPanel.transform);
            print("The item ammount is " + ItemAmmount);
        }
        else if (item.gameObject.tag == "Grape")
        {
            ItemAmmount = 2;
            gameItem = Instantiate(inventoryIcons[1]);
            gameItem.transform.SetParent(inventoryPanel.transform);
            print("The item ammount is " + ItemAmmount);
            GameText.text = "Pick up ting bruh";

        }
        else if (item.gameObject.tag == "fish")
        {
            ItemAmmount = 3;
            gameItem = Instantiate(inventoryIcons[2]);
            print("The item ammount is " + ItemAmmount);
            gameItem.transform.SetParent(inventoryPanel.transform);
        }

    }

	private void OnTriggerExit(Collider other)
	{
        GameText.text = "";
	}
}