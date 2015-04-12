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
			transform.position = playerInitPos;
			GameObject.Find("AudioManager").GetComponent<AudioManager>().Changeclip("Respawn", true);
		}
	}
}
