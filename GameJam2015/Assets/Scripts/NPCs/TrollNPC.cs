using UnityEngine;
using System;
using System.Collections;

public class TrollNPC : NPC {
	private AudioClip[] dialog;

	// Use this for initialization
	void Start () {
		this.dict.Add ("Press E to open your inventory",new string[] {});
		this.dict.Add ("Walk through the wall to the left of you", new string[] {});
	}
}
