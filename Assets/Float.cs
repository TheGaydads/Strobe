using UnityEngine;
using System.Collections;


public class Float : MonoBehaviour {
	private bool floatUp;
	
	// Use this for initialization
	void Start () {
	 floatUp = false;
	}
	
	// Update is called once per frame
	void Update () {
	if(floatUp)
        FloatingUp();
    else if(!floatUp)
        FloatingDown();
	}
	
	IEnumerator FloatingUp() {
		transform.Translate(0.0f, (1.0f * Time.deltaTime), 0.0f);
		//transform.position.y += 0.3 * Time.deltaTime;
    	 yield return new WaitForSeconds(1);
    	floatUp = false;
	}
	
	IEnumerator FloatingDown() {
		transform.Translate(0.0f, (-1.0f * Time.deltaTime), 0.0f);
		//transform.position.y -= 0.3 * Time.deltaTime;
   		 yield return new WaitForSeconds(1);
    	floatUp = true;
	}
}


