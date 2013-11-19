using UnityEngine;
using System.Collections;

public class AntiGravityLift : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		gameObject.renderer.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	gameObject.renderer.enabled = false;
	}
}
