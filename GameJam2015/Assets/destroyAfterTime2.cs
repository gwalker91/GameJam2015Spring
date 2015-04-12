using UnityEngine;
using System.Collections;

public class destroyAfterTime2 : MonoBehaviour 
{
	int counter;

	// Use this for initialization
	void Start () 
	{
		counter = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(counter > 20)
		{
			Destroy (gameObject);
		}
		counter++;
	}

	void OnTriggerEnter(Collider x)
	{
		if (x.tag == "Player") 
		{
			GameObject.Find ("Player").GetComponent<KillOnFalling>().reset ();
		}
	}
}
