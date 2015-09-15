using UnityEngine;
using System.Collections;

public class BridgeSound : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if ( Input.GetKey("b") ) {
			
			gameObject.GetComponent<AudioSource>().enabled = true;
			
		}
		
		if ( Input.GetKey("q") ) {
			
			gameObject.GetComponent<AudioSource>().enabled = false;
			
		}
	
	}
}
