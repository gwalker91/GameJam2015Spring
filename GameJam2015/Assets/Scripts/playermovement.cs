using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float rotationDamping = 20f;
	public float runSpeed = 10f;
	public int gravity = 20;

	float moveSpeed;
	CharacterController controller;
	
	void Start()
	{
		controller = (CharacterController)GetComponent(typeof(CharacterController));
	}

	float UpdateMovement()
	{
		// Movement
		float x = Input.GetAxis("Horizontal");
		float z = Input.GetAxis("Vertical");
		
		Vector3 inputVec = new Vector3(x, 0, z);
		inputVec *= runSpeed;
		
		controller.Move((inputVec + Vector3.up * -gravity + new Vector3(0, 0, 0)) * Time.deltaTime);
		
		// Rotation
		if (inputVec != Vector3.zero)
			transform.rotation = Quaternion.Slerp(transform.rotation, 
			                                      Quaternion.LookRotation(inputVec), 
			                                      Time.deltaTime * rotationDamping);
		
		return inputVec.magnitude;
	}
	void Update()
	{
		moveSpeed = UpdateMovement();  
		if (Input.GetKeyDown (KeyCode.Space)) {
			this.GetComponent<Rigidbody>().AddForce (new Vector3 (0, 10, 0));
		}
	}
}
