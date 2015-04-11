using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	private bool isIdle;
	private System.Random r;
	// Use this for initialization
	void Start () {
		isIdle = true;
		r = new System.Random ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void converse(Collider coll) {
		TrollNPC obj = coll.gameObject.GetComponent<TrollNPC> ();
		string[] goodbyes = obj.getGoodbyes ();
		//conversation...
		Debug.Log (goodbyes [r.Next (0,goodbyes.Length)]); //placeholder goodbye

		GameObject dialogObj = new GameObject ();
		Dialog dialog = dialogObj.AddComponent<Dialog> ();
		dialog.open (new string[]{"LOL"},new string[]{"nope"});
	}

	void OnTriggerEnter(Collider coll) {
		if(coll.tag == "NPC")
			if (isIdle) {
				isIdle = false;
				converse (coll);
			}
	}
	
	void OnTriggerExit(Collider coll) {
		isIdle = true;
	}
}
