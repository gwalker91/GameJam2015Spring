using UnityEngine;
using System;
using System.Collections;

public class TrollNPC : NPC {
	private String[] greetings = {
		"Good morning scrub",
		"Hello skrob"
	}, goodbyes = {
		"cya nub",
		"get rekt"
	};

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public override void converse() {
		System.Random r = new System.Random ();
		Debug.Log (greetings[r.Next(0,greetings.Length)]); //placeholder greeting
		//conversation...
		Debug.Log (goodbyes [r.Next (0,goodbyes.Length)]); //placeholder goodbye
	}
}
