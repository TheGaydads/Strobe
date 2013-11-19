using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
	
public class PlayerController : MonoBehaviour {
	
	private bool isGrounded;
	public float deploymentHeight;
	private float jumpHeight = 150.0f;
	public GUIText youDiedText;
	
	// Use this for initialization
	void Start () {
		
		//Camera.main.audio.mute = true;
		//Camera.main.audio.Play();
		//Camera.main.audio.Play();
		//Camera.main.audio.mute = true;
		
		isGrounded = false;
		youDiedText.text = "";
	/*
	 * 
		collider = GetComponent<BoxCollider>();
		s = collider.size;
		c = collider.center;*/
		
	}
	
	
	// Update is called once per frame
	void LateUpdate () {
		
		
		//CharacterController controller = GetComponent<CharacterController>();
		
		
		
		
		RaycastHit hit;
		Ray groundedRay = new Ray(transform.position, Vector3.down);

		if (Physics.Raycast(transform.position, -Vector3.up, out hit)) {
            float distanceToGround = hit.distance;
			if( distanceToGround <= 0.5f) {
				isGrounded = true;
				//Debug.Log("It's Grounded!!!");
			}
			else {
				isGrounded = false;	
			}
			//Debug.Log("D to G" + distanceToGround);
		}
		
		
		Debug.DrawRay(groundedRay.origin, groundedRay.direction);
		
		
		// Tracks horizontal input from controller
		float moveHorizontal = Input.GetAxis("Horizontal");
		
		
		//Adds horizontal input into vector's x movement
		Vector2 movement = new Vector2(moveHorizontal, 0.0f);
		
		//if ((movement.x * 1000 * Time.deltaTime) <= 15.0f && (movement.x * 1000 * Time.deltaTime) >= -15.0f) {
		
		/**
		 * Pretty alright movement using AddForce
		 * */
		
		//if ((rigidbody.velocity.magnitude <= 10.0f) && (rigidbody.velocity.magnitude >= -10.0f) ) {
			
		
		
		
		//float xPosBeforeMove = transform.position.x;
		
		
		
		//rigidbody.AddForce(movement * 100 * Time.deltaTime);
		
		//Debug.Log("Horizontal = " + moveHorizontal + " Position(" + transform.position.x 
			//+ ", " + transform.position.y + ", " + transform.position.z + ")");
		
		float xPosBeforeMove = transform.position.x;
		
		transform.Translate(moveHorizontal * 5 * Time.deltaTime,0,0,Space.World);
		
		float xPosAfterMove = transform.position.x;
		
		
		transform.Rotate(0, 0,(xPosBeforeMove - xPosAfterMove) * 90.0f,Space.World);
		
		//if (isGrounded) {
		//	rigidbody.velocity.Set(0,0,0);	
		//}
		
		//Debug.Log("1st");
			//}
		
		//if (rigidbody.velocity.magnitude <= -10.0f) {
		//	rigidbody.velocity.Set(0.0f, 0.0f, 0.0f); 
		//	rigidbody.AddForce(-movement * 1000 * Time.deltaTime);
			//Debug.Log("2nd");
		//}
		
		//if (rigidbody.velocity.magnitude >= 10.0f) {
		//	rigidbody.velocity.Set(0.0f, 0.0f, 0.0f);
			//rigidbody.velocity.Normalize();
		//	rigidbody.AddForce(-movement * 1000 * Time.deltaTime);
			//Debug.Log("3rd");
		//}
		
		//}new Vector3(15.0f, -15.0f)....>= new Vector3(-15.0f, 15.0f
		//transform.TransformDirection(movement*5);
		
		
		//Vector3 movementVector = new Vector3(movement.x, movement.y);
		//controller.Move(movementVector * Time.deltaTime);
		
		//rigidbody.AddTorque
		/*if (rigidbody.velocity.x < 5 && rigidbody.velocity.x >= 0) {
		rigidbody.AddForce(movement * 200 * Time.deltaTime);
		}
		if (rigidbody.velocity.x > -5 && rigidbody.velocity.x <= 0) {
		rigidbody.AddForce(movement * 200 * Time.deltaTime);
		}*/
		//transform.Translate(moveHorizontal * 0.25f, 0,0);
		
		/*if (isGrounded) {
			transform.Translate(moveHorizontal * 0.25f, 0,0);
		}
		else {
			rigidbody.AddForce(movement * 200 * Time.deltaTime);
		}
		*/
		
		/*if (Input.GetAxis("Horizontal") == 0 && isGrounded) {
			//Debug.Log("Stop Ball!!!");
			
				rigidbody.velocity = Vector3.zero;
			//rigidbody.velocity = Vector3.zero;

			rigidbody.angularVelocity = Vector3.zero;
		}*/
		
		if(Input.GetButtonDown("Space")) {
			
			if(isGrounded) {
				Vector3 jump = new Vector3(0.0f, jumpHeight);
				rigidbody.AddForce(jump * 3 );

				
			}
		}
		
		
	}
	
	 void OnTriggerEnter (Collider other) {
		
		if(other.gameObject.tag == "PickUp") {
			
			
			other.renderer.enabled = false;
			(other.gameObject.GetComponent("Halo") as Behaviour).enabled = false;
			other.gameObject.audio.mute = false;
			//Camera.main.audio.mute = false;
			
			
			//Debug.Log("WHAT THE HELL!!!!????");
			//other.gameObject.SetActive(false);
			//other.renderer.enabled = false;
			//(other.gameObject.GetComponent("Halo") as Behaviour).enabled = false;
			
			//other.gameObject.renderer.material.color = new Color(0.0f,0.0f,0.0f,0.0f);
			//other.gameObject.renderer.light.enabled = false;
			//other.gameObject.audio.mute = false;
			//Camera.main.audio.mute = false;
			//Destroy (other.gameObject);
			
		}
		
		if (other.gameObject.tag == "Death") {
			//Debug.Log("WHAT THE HELL!!!!????");
			Application.LoadLevel(Application.loadedLevel);
			//youDiedText.text = "You Died!!!";
			
			//Destroy (other.gameObject);
			
		}
		
		if(other.gameObject.tag == "BouncePad") {
			
		//	Debug.Log("BouncePad!!!");
		//Vector3 jump = new Vector3(0.0f, jumpHeight);
		//		rigidbody.AddForce(jump * 6);
			
		}
			
			
		}
	
	void OnTriggerStay(Collider other) {
	
		if(other.gameObject.tag == "AntiGravityLift") {
			Debug.Log("I'm in a trigger! AntiGravity");
			if(transform.position.x < 40) {
				
				rigidbody.AddForce(new Vector3(0, 10));
				Debug.Log("I'm in a trigger! AntiGravity TRANSLATING!!!!!!!!!");
				//transform.Translate(0,10 * Time.deltaTime,0,Space.World);
				
			}
	}
		
		
	}
	
	
	
	}