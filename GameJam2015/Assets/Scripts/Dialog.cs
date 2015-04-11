using UnityEngine;
using System.Collections;

public class Dialog : MonoBehaviour {
	private Rect windowRect = new Rect((Screen.width-200)/2,(Screen.height-300)/2,200,300);
	private string[] playerResponses, npcResponses;

	void DialogWindow(int windowID) {
		GUI.Label (new Rect(5,20,windowRect.width,100),"lol");
		if (GUI.Button (new Rect (5, 20, windowRect.width - 10, 50), "button test"))
			Debug.Log ("u dunnit");
	}

	public void open(string[] playerResponses, string[] npcResponses) {
		this.playerResponses = playerResponses;
		this.npcResponses = npcResponses;
	}
}
