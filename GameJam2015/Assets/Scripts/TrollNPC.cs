using UnityEngine;
using System;
using System.Collections;

public class TrollNPC : NPC {
	private string[] goodbyes;
	private AudioClip[] dialog;

	public string[] getGoodbyes() { return this.goodbyes; }

	// Use this for initialization
	void Start () {
		this.goodbyes = new string[] {
			"cya nub",
			"get rekt"
		};
	}
}
