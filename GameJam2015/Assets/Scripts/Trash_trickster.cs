using UnityEngine;
using System.Collections;

public class Trash_trickster : MonoBehaviour {

	// Use this for initialization
	/*void Start () {


	}*/
	public Transform target;
	public Transform target2;
	public float speed;
	public float hitcounter=0;
	// Update is called once per frame
	void FixedUpdate () {

		//obstacle.transform.Translate (Vector3.forward * Time.deltaTime);
		float step = speed * Time.deltaTime;
		if (hitcounter <=50 ) {
			transform.position = Vector3.MoveTowards (transform.position, target.position, step);

		}
		if (hitcounter >50) 
		{
			transform.position = Vector3.MoveTowards (transform.position, target2.position, step);

		}
		if (hitcounter > 100) {
			hitcounter=0;
		}
		hitcounter++;
	}
}
