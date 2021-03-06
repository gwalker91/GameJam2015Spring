﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StarCollection : MonoBehaviour {

	public GameObject[] stars;
	public int totalStars;
	public int starsCollected;

	public GameObject ui;

	// Use this for initialization
	void Start () 
	{
		stars = GameObject.FindGameObjectsWithTag ("Star");
		totalStars = stars.Length;
		ui = GameObject.Find ("UI");
		ui.transform.Find("Count").GetComponent<Text>().text = "Stars: " + starsCollected + "/" 
			+ totalStars;
	}

	public void AddStar()
	{
		starsCollected++;
		ui.transform.Find("Count").GetComponent<Text>().text = "Stars: " + starsCollected + "/" 
			+ totalStars;
	}

	public void ResetStars()
	{
		if (starsCollected > 0) 
		{
			foreach (GameObject g in stars) {
				g.SetActive (true);
				starsCollected = 0;
				ui.transform.Find ("Count").GetComponent<Text> ().text = "Stars: " + starsCollected + "/" 
					+ totalStars;
				GameObject.FindGameObjectWithTag ("Player").GetComponent<KillOnFalling> ().reset ();
			}
		}
	}
}
