using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent (typeof(AudioSource))]

public class Inventory : MonoBehaviour
{

    public static int ItemAmmount = -1; // why -1?
    public GameObject inventoryPanel;
    public GameObject[] inventoryIcons;

    public GameObject pointLight;
    public Text GameText;


    // Use this for initialization
    void Start()
    {
        ItemAmmount = 0;
    }

    void OnTriggerEnter(Collider item)
    {

        GameObject gameItem;
        if (item.gameObject.tag == "Fruit")
        {
            ItemAmmount = 1;
            gameItem = Instantiate(inventoryIcons[0]);
            gameItem.transform.SetParent(inventoryPanel.transform);
            print(ItemAmmount);
        }
        else if (item.gameObject.tag == "Grape")
        {
            ItemAmmount = 2;
            gameItem = Instantiate(inventoryIcons[1]);
            gameItem.transform.SetParent(inventoryPanel.transform);
            print(ItemAmmount);
            GameText.text = "Pick up ting bruh";

        }
        else if (item.gameObject.tag == "fish")
        {
            ItemAmmount = 3;
            gameItem = Instantiate(inventoryIcons[2]);
            gameItem.transform.SetParent(inventoryPanel.transform);
        }

    }

	private void OnTriggerExit(Collider other)
	{
        GameText.text = "";

	}
}