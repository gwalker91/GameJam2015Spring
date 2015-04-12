using UnityEngine;
using System.Collections;
//hello
public class model_mover : MonoBehaviour {
	public Rigidbody rb;
	public Rigidbody rb2;
	// Use this for initialization
	void Start () {
		
		rb = GetComponent<Rigidbody> ();
		rb2 = GetComponent<Rigidbody> ();
	}
	public Collider collision;
	public float jumpforce;
	public float speed; 
	public bool canjump=false;
	public int jumpcount=0;
	public int stopper = 0;
	public float jumpheight;
	// Update is called once per frame
	void FixedUpdate () 
	{
		float horizontal = Input.GetAxis ("Horizontal");
		float vertical = Input.GetAxis ("Vertical");
		
		Vector3 jumper = new Vector3 (0.0f, jumpforce, 0.0f);
		transform.Rotate (0, Input.GetAxis ("Horizontal") * 90 * Time.deltaTime, 0);
		Vector3 movement = new Vector3 (0.0f, 0.0f, vertical);
		rb.AddForce (movement * speed*Time.deltaTime);
		
		if (Input.GetButtonDown ("Jump") && jumpcount == 0) 
		{
			rb2.velocity=jumper;
			jumpcount=1;
		}
		if ((Input.GetButtonDown("Horizontal")||Input.GetButtonDown("Vertical"))&&Input.GetButtonDown ("Jump")) 
		{
			rb2.velocity=jumper;
			jumpcount=1;
		}
		if (rb2.velocity.y == 0) 
		{
			jumpcount=0;
		}
	}
}