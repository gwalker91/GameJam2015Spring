using UnityEngine;
using System.Collections;

public class collisionDetectAdvance : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.transform.root.CompareTag("Player"))
		{
			Application.LoadLevel("level 2");
		}
	}


}
