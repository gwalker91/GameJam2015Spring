using UnityEngine;
using System.Collections;


public class KillOnFalling : MonoBehaviour 
{
	Vector3 playerInitPos;
	// Use this for initialization
	void Start () 
	{
		Random.seed =(int)System.DateTime.Now.Ticks;
		playerInitPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (transform.position.y < -10.0f) 
		{
			reset ();
			int r = (int)Random.Range(0,2);
			switch (r)
			{
			case 0:
				GameObject.Find("AudioManager").GetComponent<AudioManager>().Changeclip("Respawn", true);
				break;
			case 1:
				GameObject.Find("AudioManager").GetComponent<AudioManager>().Changeclip("NarratorStory", true);
				break;
			}

		}
	}

	public void reset()
	{
		gameObject.transform.position = playerInitPos;
	}
}
