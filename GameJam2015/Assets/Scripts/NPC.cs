using UnityEngine;
using System;
using System.Collections;

//This is meant to be an abstract class.
public class NPC : MonoBehaviour {
	private System.Random r;
	protected bool isIdle;
	protected int damage;

	// Use this for initialization
	void Start () {
		r = new System.Random ();
		isIdle = true;
	}
	
	// Update is called once per frame
	void Update () {

	}

	public virtual void converse() { }

	void OnTriggerEnter(Collider coll) {
		if(coll.tag == "NPC")
			if (isIdle) {
				isIdle = false;
				converse ();
			}
	}

	void OnTriggerExit(Collider coll) {
		//just in case...
	}
}

