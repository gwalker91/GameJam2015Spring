using UnityEngine;
using System.Collections;

public class view : MonoBehaviour {

	public Canvas canvas;

	void Start () {
		canvas = gameObject.GetComponent ("Canvas") as Canvas;
		gameObject.SetActive(false);
	}

}
