using UnityEngine;
using System.Collections;

public class forceonit : MonoBehaviour {

	private float xForce;
//	private GameObject otherThing;
	private int zTourqe;


	// Use this for initialization
	void Start () {

		xForce = 150;
		zTourqe = 230;

	}
	
	// Update is called once per frame
	void Update () {

		// hit the key to move the object.
		// if I space key
		//if (the space key is pressed--true thing) {

		Rigidbody rb = gameObject.GetComponent<Rigidbody >();

		if ( Input.GetKey ( KeyCode.Space ) == true ){

//			gameObject.GetComponent<Rigidbody>().AddForce ( new Vector3 ( xForce, 5, 5 ) );
//			gameObject.GetComponent<Rigidbody>().AddTorque ( new Vector3 ( 0, 0, 100 ) );

			rb.AddForce ( new Vector3 ( xForce, 0,0 ) );
			rb.AddTorque (new Vector3 ( 0, 0, zTourqe ) );
		}

		if ( Input.GetKey( "+" )) {
			rb.transform.localScale = new Vector3 ( 5, 5, 5 );

		}
	
	}
}
