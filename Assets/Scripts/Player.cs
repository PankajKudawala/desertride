using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	public bool move = false;
	public Rigidbody2D rb;
	public float speed = 20f;
	public bool isGround = false;
	public float rotationSpeed = 2f;

	void Update(){
		if (Input.GetMouseButtonDown (0)) {
			move = true;
		}
		if (Input.GetButtonUp ("Fire1")) {
			move = false;
		}
	}

	void FixedUpdate(){
		if(move == true){
			if (isGround == true) {
				rb.AddForce (transform.right * speed * Time.fixedDeltaTime * 100f, ForceMode2D.Force);
			} else {
				rb.AddTorque (rotationSpeed * rotationSpeed * Time.fixedDeltaTime * 100f);
			}

		}
	}

	void OnCollisionEnter2D(){
		isGround = true;
	}

	void OnCollisionExit2D(){
		isGround = false;
	}
}
