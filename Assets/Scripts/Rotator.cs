using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {
	
	public float rotateSpeed = 50.0f;
	
	void Update () {
		transform.Rotate (new Vector3(15 * Time.deltaTime, rotateSpeed * Time.deltaTime,0));
	}
}
