using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyeScenes : MonoBehaviour {


	void Start () {
		
	}

	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D coll){
		if (coll.gameObject.tag == "Ground" && coll.gameObject.tag == "Car") {
		}
		else {
			Destroy (coll.gameObject);
		}
	}

	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag == "Ground" && coll.gameObject.tag == "Car") {
		}
		else {
			Destroy (coll.gameObject);
		}
	}
}
