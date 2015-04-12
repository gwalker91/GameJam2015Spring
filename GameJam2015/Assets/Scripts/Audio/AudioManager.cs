using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

[RequireComponent(typeof(AudioSource))]
public class AudioManager : MonoBehaviour 
{
	public AudioFile[] audioFiles;

	private AudioSource audioPlayer;
	private IEnumerator coroutine;

	private float timer;

	void Start()
	{
		audioPlayer = GetComponent<AudioSource> ();
		timer = 0.0f;

	}

	void FixedUpdate() 
	{
		if (audioPlayer.isPlaying)
			timer += Time.deltaTime;
	}

	public void Changeclip(string name, bool playRightAway = false)
	{
		if (playRightAway) {
			StopCoroutine (coroutine);
			audioPlayer.Stop ();
			FindFile (name);
		} else 
		{
			coroutine = Wait (name);
			StartCoroutine (coroutine);	
		}
	}
	
	IEnumerator Wait(string name) 
	{
		if (audioPlayer.isPlaying) 
		{
			yield return new WaitForSeconds (audioPlayer.clip.length - timer);
			audioPlayer.Stop();
		}
		FindFile (name);
	}

	void FindFile(string name)
	{
		foreach(AudioFile a in audioFiles)
		{
			if(a.name == name)
			{
				audioPlayer.clip = a.clip;
				audioPlayer.Play();
				timer = 0.0f;
			}
		}
	}
}

[Serializable]
public struct AudioFile 
{
	public string name;
	public AudioClip clip;
}


