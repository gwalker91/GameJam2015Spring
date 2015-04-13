using UnityEngine;
using System.Collections;

public class teleporterScript : MonoBehaviour {

	public Collider teleporter;
	GameObject[] locations;

	void Start() {

		locations = GameObject.FindGameObjectsWithTag ("Location");
	}

	void OnTriggerEnter(Collider teleporter){
		if (teleporter.tag == "Teleporter" || teleporter.tag == "Location") {
			Vector3 new_position = locations [Random.Range (0, locations.Length)].transform.position;
			transform.position = new_position;
			teleporter.transform.gameObject.tag = "Location";
		}
	}
}
