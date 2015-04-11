using UnityEngine;
using System.Collections;

public class InventoryNPC : NPC {
	// Use this for initialization
	void Start () {
		this.dict.Add ("Answer my question: What is the order of the group of generators for the finite cyclic group Z*197?",new string[] {
			"2","buffalo"
		});
		this.dict.Add ("Answer my question: Is the Twin ElGamal encryption scheme CCA secure?", new string[] { 
			"cory baxter","Yes"
		});
		this.dict.Add ("Answer my question: What is 7 + 2?", new string[] { "72", "9" });
	}
}
