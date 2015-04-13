using UnityEngine;
using System.Collections;

public class CheckPoint : MonoBehaviour {

	GameObject starCollection;

	// Use this for initialization
	void Start () 
	{
		starCollection = GameObject.Find ("StarCollection");
	}


	void OnTriggerEnter(Collider col) 
	{
		if (col.tag == "Player") 
		{
			starCollection.GetComponent<StarCollection>().ResetStars();
            GameObject.Find("AudioManager").GetComponent<AudioManager>().Changeclip("MetalStar", true);
		}

	}
}
