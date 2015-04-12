using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

//This is meant to be an abstract class.
public class NPC : MonoBehaviour {
	protected Dictionary<string,string[]> dict = new Dictionary<string, string[]>();
	protected bool isIdle = true;

	//Crappy seeding with truncating time seed.
	public string getLine() { return this.dict.Keys.ElementAt(new System.Random((int)Time.realtimeSinceStartup).Next (0,dict.Keys.Count-1)); }
	public string[] getAnswers(string line) { return this.dict[line]; }

	public static void killPlayer() {
		// EDIT! Temporary filler, meant to restart to beginning of level as well as any necessary premable interactions.
		Application.LoadLevel ("jhScene");
	}
}

