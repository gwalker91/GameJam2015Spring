using UnityEngine;
using System.Collections;

public class playermovement : MonoBehaviour {

	public Rigidbody rb;
	public Rigidbody rb2;
	void start()
	{
		rb = GetComponent<Rigidbody> ();
		rb2 = GetComponent < Rigidbody> ();
	}




	public Collider collision;
	public float jumpforce;
	public float speed;
	public bool canjump=false;
	public bool isgrounded;
	public int jumpcount=0;
	public float jumpheight;
	// Update is called once per frame
	void FixedUpdate () 
	{

		float horizontal = Input.GetAxis ("Horizontal");
		float vertical = Input.GetAxis ("Vertical");

		//float jump= Input.GetAxis("Jump");
		Vector3 jumper=new Vector3(0.0f,jumpforce,0.0f);

		Vector3 movement = new Vector3 (horizontal, 0.0f, vertical);
		rb.AddForce (movement * speed * Time.deltaTime);
		//Input.GetButtonDown ("Jump");
		//rb2.AddForce (jumper*jumpforce);


		if (Input.GetButtonDown ("Jump")&&jumpcount==0) {
			rb2.velocity=jumper;
			//rb2.AddForce (jumper*jumpforce);
			jumpcount=1;
		}
		if (rb2.velocity.y == 0) 
		{
			jumpcount=0;
		}


	}
	void OnCollisionEnter(Collision coll)
	{
		/*if (coll.gameObject.tag == "ground") 
		{
			jumpcount=0;
		}*/
	}
}
