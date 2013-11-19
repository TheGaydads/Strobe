using UnityEngine;
using System.Collections;

public class Crusher : MonoBehaviour {
	
	
	float movePadXPosition;
	float movePadYPosition;
	float movePadZPosition;
	bool moveUp;
	bool moveDown;
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
		
		if (transform.position.y <= 39.5) {
			//Debug.Log("Moving Up");
			moveUp = true;
			moveDown = false;
		}
		
		if (transform.position.y >= 43) {
			//Debug.Log("Moving Down");
			moveUp = false;
			moveDown = true;
		}
		
		if (moveUp == true) {
			transform.Translate(new Vector3(0, 4, 0) * Time.deltaTime);
			//tempX = (tempX + 0.0000000000000000000001f) / 999999999999999.0f;
			//transform.Translate(tempX, movePadYPosition, movePadZPosition);
			//transform.position.x = (movePadXPosition + 1) * Time.deltaTime;	
		}
		
		else if (moveDown == true) {
			transform.Translate(new Vector3(0, -4, 0) * Time.deltaTime);
			//transform.Translate(tempX, movePadYPosition, movePadZPosition);
			//transform.position.x = (movePadXPosition - 1) * Time.deltaTime;	
		}
		
	}
}
