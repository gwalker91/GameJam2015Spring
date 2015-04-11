using UnityEngine;
using System;
using System.Collections;

//This is meant to be an abstract class.
public class NPC : MonoBehaviour {
	protected System.Random r;
	protected bool isIdle;
	protected int damage;

	// Use this for initialization
	void Start () {
		r = new System.Random ();
		isIdle = true;
	}
}

