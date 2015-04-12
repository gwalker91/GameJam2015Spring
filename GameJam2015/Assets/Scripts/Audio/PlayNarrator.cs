using UnityEngine;
using System.Collections;

public class PlayNarrator : MonoBehaviour
{
	public string audioClip;
	public GameObject audiomanager;
	public bool hasPlayed;
	public bool playRightAway;

	void Start()
	{
		hasPlayed = false;
		playRightAway = false;
	}

	void OnTriggerEnter(Collider col) 
	{
		if (col.tag == "Player") 
		{
			if(!hasPlayed)
			{
				audiomanager.GetComponent<AudioManager>().Changeclip(audioClip, playRightAway);
				hasPlayed = true;
			}
		}
	}
}
