using UnityEngine;
using System.Collections;

public class PlayerMode : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Rigidbody Player = gameObject.GetComponent<Rigidbody>();

		if (Input.GetKey ( KeyCode.W) == true ) {

		Player.AddForce(new Vector3 ( 0, 20, 5) ) ;

		}
	

	}
	

}
