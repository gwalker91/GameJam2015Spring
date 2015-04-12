using UnityEngine;
using System.Collections;

public class StairNPC : NPC {

	// Use this for initialization
	void Start () {
		this.dict.Add ("All the gold coins behind me would last a man a lifetime...", new string[] {});
		this.dict.Add ("It seems the only way to cross is through these stairs...", new string[] {});
		this.dict.Add ("The riches that lie past me are unbounded...", new string[] {});
	}
}
