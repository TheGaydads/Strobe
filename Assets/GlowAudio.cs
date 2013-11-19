using UnityEngine;
using System.Collections;

public class GlowAudio : MonoBehaviour {
	
	
	bool isMuted = true;
	// Use this for initialization
	void Start () {
	
		this.gameObject.audio.mute = true;
		this.gameObject.audio.Play();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
	}
	
}
