using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
	
public class CubeController : MonoBehaviour {
	
	private bool isGrounded;
	public float deploymentHeight;
	private float jumpHeight = 150.0f;
	
	
	// Use this for initialization
	void Start () {
		isGrounded = false;
	/*
	 * 
		collider = GetComponent<BoxCollider>();
		s = collider.size;
		c = collider.center;*/
		
	}
	
	
	// Update is called once per frame
	void Update () {
		
		RaycastHit hit;
		Ray groundedRay = new Ray(transform.position, Vector3.down);

		if (Physics.Raycast(transform.position, -Vector3.up, out hit)) {
            float distanceToGround = hit.distance;
			if( distanceToGround <= 0.5f) {
				isGrounded = true;
				Debug.Log("It's Grounded!!!");
			}
			else {
				isGrounded = false;	
			}
			Debug.Log("D to G" + distanceToGround);
		}
		
		
		Debug.DrawRay(groundedRay.origin, groundedRay.direction);
		
		
		// Tracks horizontal input from controller
		float moveHorizontal = Input.GetAxis("Horizontal");
		
		//Adds horizontal input into vector's x movement
		Vector2 movement = new Vector2(moveHorizontal, 0.0f);
		
		//rigidbody.AddTorque
		rigidbody.AddForce(movement * 100 * Time.deltaTime);
		
		
		if(Input.GetButtonDown("Space")) {
			
			if(isGrounded) {
			Vector3 jump = new Vector3(0.0f, jumpHeight);
			rigidbody.AddForce(jump * 3);
			}
		}
		
		
	}
}
