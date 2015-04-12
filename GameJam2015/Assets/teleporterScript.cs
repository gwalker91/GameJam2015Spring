using UnityEngine;
using System.Collections;

public class teleporterScript : MonoBehaviour {

	public Collider teleporter;
	public Transform player;
	GameObject[] locations;

	void Start() {
		locations = GameObject.FindGameObjectsWithTag ("Location");
	}

	void OnTriggerEnter(Collider teleporter){
		Vector3 position = player.position;
		Vector3 new_position = locations [Random.Range (0, locations.Length)].transform.position;
		transform.position = new_position;
	}
}
