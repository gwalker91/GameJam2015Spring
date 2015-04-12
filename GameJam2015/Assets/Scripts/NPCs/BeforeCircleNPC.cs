using UnityEngine;
using System.Collections;

public class BeforeCircleNPC : NPC {

	// Use this for initialization
	void Start () {
		this.dict.Add ("Within the inner circle rests the key to escaping this prison...",new string[] {});
		this.dict.Add ("The inner circle holds the great endurance test known to man, but houses the greatest riches of all time.", new string[] {});
	}
}
