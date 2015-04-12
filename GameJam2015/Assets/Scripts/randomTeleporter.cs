using UnityEngine;
using System.Collections;

public class randomTeleporter : MonoBehaviour {
	public Collider teleporter;
	public Transform player;
	GameObject[] locations;
	
	void Start() {
		locations = GameObject.FindGameObjectsWithTag ("Location");
	}
	
	void OnTriggerEnter(Collider teleporter) {
		if(teleporter.tag == "Teleporter")
			if (Random.Range (0,2) == 0) {
				Vector3 new_position = locations [Random.Range (0, locations.Length)].transform.position;
				transform.position = new_position;
			}
	}
}