using UnityEngine;
using System.Collections;

public class LargeBouncePad : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter (Collider other) {
	
		if(other.gameObject.tag == "Player") {
			
				Debug.Log("BouncePad!!!");
		Vector3 jump = new Vector3(0.0f, 150.0f);
				other.rigidbody.AddForce(jump * 6);
			
		}
		
	}
}
