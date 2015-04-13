using UnityEngine;
using System.Collections;

public class resetPlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider x)
	{
		if (x.tag == "Player") 
		{
			x.GetComponent<KillOnFalling> ().reset ();
		}
	}
}
