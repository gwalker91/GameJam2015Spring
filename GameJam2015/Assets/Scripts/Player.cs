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
				int j = (i==0) ? 1 : 0;
				addListener(buttons[i],buttons[j],answers[i]);
			}
	}

	//Trash method to handle onClickListeners for buttons based on the line/answers generated.
	//This involves manually checking strings and determining the NPC actions for each.
	void addListener(Button b, Button b2, string answer) {
		b.onClick.AddListener (() => handleButtonClick (b, b2, answer));
	}

	void handleButtonClick(Button b, Button b2, string answer) {
		b.gameObject.SetActive (false);
		b2.gameObject.SetActive (false);
		switch(answer) {
		case "buffalo": dialogCanvas.GetComponent<Text>().text = "yes bufaloo"; break;
		case "2": NPC.killPlayer(); break;
		case "cory baxter": dialogCanvas.GetComponent<Text>().text = "u a busta"; break;
		case "Yes": dialogCanvas.GetComponent<Text>().text = "ok"; break;
		case "9": dialogCanvas.GetComponent<Text>().text = "There is a man on the roof..."; break;
		case "72": dialogCanvas.GetComponent<Text>().text = "no shit sherlock"; break;
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
