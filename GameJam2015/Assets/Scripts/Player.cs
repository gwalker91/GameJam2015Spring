using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour {
	private bool isIdle;
	private GameObject dialogCanvas, leftButton, rightButton;
	public GameObject jailDoorClosed, key;

	// Use this for initialization
	void Start () {
		isIdle = true;
		dialogCanvas = GameObject.Find ("Canvas");
		leftButton = GameObject.Find ("leftButton");
		rightButton = GameObject.Find ("rightButton");
		dialogCanvas.SetActive (false);
	}
	
	public void converse(Collider coll) {
		NPC obj = coll.gameObject.GetComponent<NPC> ();
		string line = obj.getLine();
		
		dialogCanvas.SetActive (true);
		Text t = dialogCanvas.GetComponent<Text> ();
		t.text = line;
		
		//We assume only 2 answers.
		string[] answers = obj.getAnswers (line);
		if (answers.Length == 0) {
			leftButton.gameObject.SetActive (false);
			rightButton.gameObject.SetActive (false);
		} else {
			leftButton.gameObject.SetActive (true);
			rightButton.gameObject.SetActive (true);
			leftButton.GetComponentInChildren<Text>().text = answers[0];			
			rightButton.GetComponentInChildren<Text>().text = answers[1];
			
			Button[] buttons = dialogCanvas.GetComponentsInChildren<Button> ();
			addListener (buttons[0],buttons[1],answers[0]);
			addListener (buttons[1],buttons[0],answers[1]);
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
		if (coll.tag == "NPC") {
			if (isIdle) {
				isIdle = false;
				converse (coll);
			} 
		}
	}
	
	void OnTriggerExit(Collider coll) {
		isIdle = true;
		dialogCanvas.SetActive (false);
		if (coll.tag == "ShiftyJailDoor") {
			Destroy (GameObject.Find ("JailDoorOpen"));
			GameObject clonedDoor = Instantiate (jailDoorClosed,new Vector3(-11f,.5f,40f),Quaternion.identity) as GameObject;
			clonedDoor.transform.Rotate(0,90,0);

			for(int i = 0; i < 5; i++)
				Instantiate(key,new Vector3(-10f,1.5f,40f),Quaternion.identity);
		}
	}
}
