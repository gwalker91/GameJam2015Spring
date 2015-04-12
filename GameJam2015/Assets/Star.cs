using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Star : MonoBehaviour 
{
	public GameObject ui;
	public GameObject starCollection;

	// Use this for initialization
	void Start () {
		ui = GameObject.Find ("Canvas");
		starCollection = GameObject.Find ("StarCollection");
		ui.transform.Find("Count").GetComponent<Text>().text = "Stars: " + starCollection.GetComponent<StarCollection>().starsCollected + "/" 
			+ starCollection.GetComponent<StarCollection>().totalStars;
	}

	void OnTriggerEnter(Collider col) 
	{
		if (col.tag == "Player") 
		{
			starCollection.GetComponent<StarCollection>().AddStar();
			ui.transform.Find("Count").GetComponent<Text>().text = "Stars: " + starCollection.GetComponent<StarCollection>().starsCollected + "/" 
				+ starCollection.GetComponent<StarCollection>().totalStars;
			gameObject.SetActive(false);
		}

	}
}
