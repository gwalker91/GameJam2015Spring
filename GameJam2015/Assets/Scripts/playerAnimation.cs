using UnityEngine;
using System.Collections;

public class playerAnimation : MonoBehaviour {

	Animator anim;

	// Use this for initialization
	void Start () {
		anim = gameObject.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		anim.SetBool ("w_pressed", Input.GetKey (KeyCode.W));
		anim.SetBool ("s_pressed", Input.GetKey (KeyCode.S));
		anim.SetBool ("d_pressed", Input.GetKey (KeyCode.D));
		anim.SetBool ("a_pressed", Input.GetKey (KeyCode.A));
		anim.SetBool ("ctrl_pressed", Input.GetKey (KeyCode.LeftControl));
		anim.SetBool ("space_pressed", Input.GetButton("Jump"));

	}

}
