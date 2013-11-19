using UnityEngine;
using System.Collections;

public class MovePadTrigger : MonoBehaviour {
	
	
	float movePadXPosition;
	float movePadYPosition;
	float movePadZPosition;
	bool moveRight;
	bool moveLeft;
	// Use this for initialization
	void Start () {
	//moveRight = true;
	//moveLeft = false;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		// transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime);
		
		//Debug.Log("X Position ==" + transform.position.x);
		
		movePadXPosition = transform.position.x;
		movePadYPosition = transform.position.y;
		movePadZPosition = transform.position.z;
		
		float tempX = movePadXPosition;
		
		if (transform.position.x <= -38) {
			//Debug.Log("Moving Left");
			moveRight = true;
			moveLeft = false;
		}
		
		if (transform.position.x >= -12) {
			//Debug.Log("Moving Right");
			moveRight = false;
			moveLeft = true;
		}
		
		if (moveRight == true) {
			transform.Translate(new Vector3(2, 0, 0) * Time.deltaTime);
			//tempX = (tempX + 0.0000000000000000000001f) / 999999999999999.0f;
			//transform.Translate(tempX, movePadYPosition, movePadZPosition);
			//transform.position.x = (movePadXPosition + 1) * Time.deltaTime;	
		}
		
		else if (moveLeft == true) {
			transform.Translate(new Vector3(-2, 0, 0) * Time.deltaTime);
			//transform.Translate(tempX, movePadYPosition, movePadZPosition);
			//transform.position.x = (movePadXPosition - 1) * Time.deltaTime;	
		}
		
	}
}
