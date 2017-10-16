using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent (typeof(AudioSource))]

public class Inventory : MonoBehaviour {

	public static int FruitAmount = -1;
	public GameObject inventoryPanel;
	public GameObject[] inventoryIcons;
	public GameObject fruitIcon;
	public List<GameObject> fruits = new List<GameObject>();

	public GameObject bananaPrefab;
	private GameObject bananaGUI;

	public bool haveBanana = false;

	// Use this for initialization
	void Start () {
		FruitAmount = 0;
	}

	void OnTriggerEnter(Collider fruit) {
		// look through all icons in inventory 
		if(fruit.gameObject.tag == "Fruit") {
			TriggerTing(fruit);
		}
	}


	void TriggerTing(Collider fruit){
		foreach(Transform child in inventoryPanel.transform) {

			// if item in inventory has same tag as collected item
			if(child.gameObject.tag == fruit.gameObject.tag) {

				// gets the next in the child (number)
				string c = child.Find("Text").GetComponent<Text>().text;
				// Turns said text into an intiger
				int tcount = System.Int32.Parse(c) + 1;
				// value is then put back into text object
				child.Find("Text").GetComponent<Text>().text = "" + tcount;
				return;

			}
		}


		if(fruit.gameObject.tag == "Fruit") {

			FruitAmount++;
			print("fruit amount is " + FruitAmount);

			for(int count = 1; count <= inventoryIcons.Length; count++) {

				// if charge and counter are the same 
				if (FruitAmount == count) {
					// add an icon from the array 
					fruitIcon = Instantiate(inventoryIcons[count - 1]);
					fruitIcon.transform.SetParent(inventoryPanel.transform);

					// turns baticon into list
					fruits.Add(fruitIcon);
				}
			}
		} 




	}

	void BananaPickup() {

		haveBanana = true;
		GameObject bananaHUD = Instantiate(bananaPrefab);
		bananaHUD.transform.SetParent(inventoryPanel.transform);

		bananaGUI = bananaHUD;

		if(haveBanana == true) 
		{
			foreach (var fruit in fruits)
			{
				fruit.SetActive(false);
			}
		}	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
