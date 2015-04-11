using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

//This is meant to be an abstract class.
public class NPC : MonoBehaviour {
	protected Dictionary<string,string[]> dict = new Dictionary<string, string[]>();
	protected System.Random r = new System.Random();
	protected bool isIdle = true;

	public string getLine() { return this.dict.Keys.ElementAt(r.Next (0,dict.Keys.Count-1)); }
	public string[] getAnswers(string line) { return this.dict[line]; }

	//Additional NPC behaviors...
}

