using UnityEngine;
using System.Collections;

public class ConveyorBeltLeft : MonoBehaviour {
 
    public float speed = 30.0f;
 
   void OnCollisionStay(Collision collision) {
        if (collision.gameObject.tag != "Player")
            return;
 
        // Assign velocity based upon direction of conveyor belt
        // Ensure that conveyor mesh is facing towards its local Z-axis
 
        float conveyorVelocity = speed * Time.deltaTime;
 
		//collision.rigidbody
        Rigidbody rigidbody = collision.gameObject.rigidbody;
        //rigidbody.velocity = (rigidbody.velocity * conveyorVelocity) + transform.right* 2;
		
		
		collision.transform.Translate(-4 * Time.deltaTime,0,0,Space.World);
		
		Vector2 movement = new Vector2(-1.0f, 0.0f);
		//rigidbody.AddForce(movement * 1000 * Time.deltaTime);
		
		
		//rigidbody.AddForce(rigidbody.velocity * conveyorVelocity);
		//float x = rigidbody.velocity.x;
		
		//rigidbody.velocity = rigidbody.velocity * 2;
    }
	
	
	
 
}