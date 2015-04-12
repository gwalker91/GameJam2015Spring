using UnityEngine;
using System.Collections;

public class Star : MonoBehaviour 
{

	public GameObject starCollection;

	// Use this for initialization
	void Start () {

		starCollection = GameObject.Find ("StarCollection");

	}

	void OnTriggerEnter(Collider col) 
	{
		if (col.tag == "Player") 
		{
			starCollection.GetComponent<StarCollection>().AddStar();

			gameObject.SetActive(false);
		}

	}
}
