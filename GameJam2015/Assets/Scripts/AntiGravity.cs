using UnityEngine;
using System.Collections;

public class AntiGravity : MonoBehaviour {

	public Collider antigrav;
	public Rigidbody player;

	Vector3 playerInitPos;
	
	void Start () {
		playerInitPos = transform.position;
	}

	void Update () {
		if (transform.position.y > 200.0f) {
			transform.position = playerInitPos;
			player.useGravity = true;
			player.velocity = Vector3.zero;
		}
	}

	void OnTriggerEnter(Collider antigrav){
		if (antigrav.tag == "Antigrav") {
			player.useGravity = false;
			player.AddForce (new Vector3 (0, 10000, 0));
		}
	}
}
