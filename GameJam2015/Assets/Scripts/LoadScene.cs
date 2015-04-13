using UnityEngine;
using System.Collections;

public class LoadScene : MonoBehaviour {

	public void LoadLevel() {
		Application.LoadLevel ("Zach C2");
	}

	public void ExitToMenu() {
		Application.LoadLevel ("trash title");
	}

}
