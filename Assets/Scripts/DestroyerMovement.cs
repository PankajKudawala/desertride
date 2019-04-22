using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class DestroyerMovement : MonoBehaviour {

	//public Rigidbody2D rb;
	//public float speed;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("MoveDestroyer", 0.3f, 0.3f);
	}
	
	// Update is called once per frame
	void Update () {
		//rb.AddForce (transform.right * speed*Time.fixedDeltaTime *100f,ForceMode2D.Force);

	}

	void MoveDestroyer(){
		transform.position += new Vector3(1f,0,0);
	}

}
