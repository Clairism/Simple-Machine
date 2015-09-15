using UnityEngine;
using System.Collections;

public class ForestSound : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if ( Input.GetKey("f") ) {
			
			gameObject.GetComponent<AudioSource>().enabled = true;
			
		}

		if ( Input.GetKey("q") ) {
			
			gameObject.GetComponent<AudioSource>().enabled = false;
			
		}

	}

	//void OnTriggerEnter(Collider other) {
		//if ( Input.GetKey ("p") ) {

			//gameObject.GetComponent<AudioSource>().enabled = false;
		
		//}
	//}

}

