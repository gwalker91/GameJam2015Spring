using UnityEngine;
using System.Collections;
//hello
public class model_mover : MonoBehaviour {

	private model_mover character;
	public Rigidbody rb;
	public Rigidbody rb2;
	public Transform cam;
	private Vector3 camforward;
	private Vector3 move;
	private bool jump2;
	// Use this for initialization
	void Start () {
		if (Camera.main != null) 
		{
			cam=Camera.main.transform;
		}
	
		else
		{
			Debug.LogWarning(
				"Warning: no main camera found. Third person character needs a Camera tagged \"MainCamera\", for camera-relative controls.");
			// we use self-relative controls in this case, which probably isn't what the user wants, but hey, we warned them!
		}
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
	//public Vector3 dir;
	// Update is called once per frame
	void FixedUpdate () 
	{

		float horizontal = Input.GetAxis ("Horizontal");
		float vertical = Input.GetAxis ("Vertical");
		//transform.rotation = Quaternion.LookRotation(dir);
		//if (dir != Vector3.zero) 
		//{
			//transform.rotation=Quaternion.Slerp(transform.rotation,Quaternion.LookRotation(dir),Time.deltaTime);
		//}
		if (cam != null) 
		{
			camforward = Vector3.Scale(cam.forward, new Vector3(1, 0, 1)).normalized;
			move = vertical*camforward + horizontal*cam.right;
		}
		else
		{
			// we use world-relative directions in the case of no main camera
			move = vertical*Vector3.forward + horizontal*Vector3.right;
		}
		//transform.position = transform.position + Camera.main.transform.forward  * Time.deltaTime;//does NOT  WORK
		Vector3 jumper = new Vector3 (0.0f, jumpforce, 0.0f);//works
		transform.Rotate (0, Input.GetAxis ("Horizontal") * 60, 0);//works
		//Vector3 movement = new Vector3 (horizontal, 0.0f, vertical);//works sort of
		rb.AddForce (move * speed*Time.deltaTime);

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