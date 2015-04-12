using UnityEngine;
using System.Collections;

public class KillOnFalling : MonoBehaviour 
{
	Vector3 playerInitPos;

	// Use this for initialization
	void Start () 
	{
		playerInitPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (transform.position.y < -10.0f) 
		{
			reset ();
		}
	}

	public void reset()
	{
		gameObject.transform.position = playerInitPos;
	}
}
