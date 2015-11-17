using UnityEngine;
using System.Collections;

public class collisoinListener : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider otherObject ) {

	}

	void OnCollisionEnter( Collision thisCollision ) {

		if (thisCollision.gameObject.tag == "Player" ){

			print( "Hit it!" );

		}

	}
}
