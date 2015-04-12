using UnityEngine;
using System.Collections;

public class RoofNPC : NPC {

	// Use this for initialization
	void Start () {
		this.dict.Add ("i am a roof", new string[] {});
		this.dict.Add ("Often times I look up in the sky and ask myself... \"am I a roof?\"", new string[] {});
	}
}
