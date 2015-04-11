using UnityEngine;
using System.Collections;

public class LoadScene : MonoBehaviour {

	public void Testing() {
		Application.LoadLevel ("other scene");
	}

	public void Menu() {
		Application.LoadLevel ("menu test");
	}
}
