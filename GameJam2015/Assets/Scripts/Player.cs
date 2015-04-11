using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour {
	private bool isIdle;
	private GameObject dialogCanvas;
	// Use this for initialization
	void Start () {
		isIdle = true;
		dialogCanvas = GameObject.Find ("Canvas");
		dialogCanvas.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void converse(Collider coll) {
		NPC obj = coll.gameObject.GetComponent<NPC> ();
		string line = obj.getLine();

		//conversation...
		dialogCanvas.SetActive (true);
		Text t = dialogCanvas.GetComponent<Text> ();
		t.text = line;

		//We assume only 2 answers.
		Button[] buttons = dialogCanvas.GetComponentsInChildren<Button> ();
		string[] answers = obj.getAnswers (line);
		if (answers.Length == 0) {
			buttons[0].gameObject.SetActive(false);
			buttons[1].gameObject.SetActive(false);
		} else
			for (int i = 0; i < answers.Length; i++) {
				Text[] buttonTexts = buttons[i].GetComponentsInChildren<Text>();
				buttonTexts[0].text = answers [i];
			}
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
		dialogCanvas.SetActive (false);
	}
}
