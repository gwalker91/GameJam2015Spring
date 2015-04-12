using UnityEngine;
using System.Collections;

public class StairNPC : NPC {

	// Use this for initialization
	void Start () {
		this.dict.Add ("At the top of these stairs rests a sack of dubloons.", new string[] {});
		this.dict.Add ("The only way out lies at the top of these stairs...", new string[] {});
		this.dict.Add ("A sheltered hermit lives up these stairs who may be able to help you escape...", new string[] {});
	}
}
