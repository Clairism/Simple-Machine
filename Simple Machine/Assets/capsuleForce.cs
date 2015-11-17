using UnityEngine;
using System.Collections;

public class capsuleForce : MonoBehaviour {

	private GameObject Capsule;

	// Use this for initialization
	void Start () {

		Capsule = GameObject.Find ("Capsule");

	
	}
	
	// Update is called once per frame
	void Update () {

		Rigidbody cp = gameObject.GetComponent<Rigidbody >();


		if ( Input.GetKey( "1" ) == true ) {

			Capsule.transform.localScale = new Vector3 (2,5,5) ;
		
		}

		Input.GetAxis("Horizontal");
		
		cp.AddForce( new Vector3 ( 5, 0, 0 ) * Input.GetAxis("Horizontal") );
		

	}
}
