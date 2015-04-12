using UnityEngine;
using System.Collections;

public class MilesNPC : NPC {

	// Use this for initialization
	void Start () {
		this.dict.Add ("You are trash.", new string[] {});
		this.dict.Add ("Everyone around me is trash.", new string[] {});
		this.dict.Add ("Everything around me is trash.", new string[] {});
	}
}
