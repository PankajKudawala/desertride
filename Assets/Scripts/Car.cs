using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour {

	public GameObject track;
	private Vector3 offset;
	public Transform car;

	public bool move = false;
	public Rigidbody2D rb;
	public float speed = 20f;
	public bool isGround = false;
	public float rotationSpeed = 20f;

	public WheelJoint2D backWheel;
	public WheelJoint2D frontWheel;

	private float roatation = 25f;

	public GameObject tankHead;
	// Controls Here;
	public Swipe swipeControls;

	void Start(){
		offset = new Vector3(-100f, 0, 0);
	}

	void Update(){

		if (swipeControls.SwipeUp) {
			RotateLeft ();
		}
		if (swipeControls.SwipeDown) {
			RotateRight();
		}
		if (swipeControls.SwipeLeft) {
			if (speed != -7000)
				speed -= 100f;
		}
		if (swipeControls.SwipeRight) {
			while (speed != -3000) {
				speed += 100f;
			}
		}

	}

	void FixedUpdate(){
		if(move == true){
			if (isGround == true) {
				//rb.AddForce (transform.right * speed * Time.fixedDeltaTime * 100f, ForceMode2D.Force);
				backWheel.useMotor = true;
				frontWheel.useMotor = true;

				JointMotor2D motor = new JointMotor2D { motorSpeed  = speed, maxMotorTorque = 10000 };
				backWheel.motor = motor;
				frontWheel.motor = motor;

			} else {
				rb.AddTorque (rotationSpeed * rotationSpeed * Time.fixedDeltaTime * 100f);
			}

		}
	}

	void OnCollisionEnter2D(Collision2D coll){
			isGround = true;
		if (coll.gameObject.tag == "MTBullet") {
			int health = PlayerPrefs.GetInt ("health");
			health -= 3;
			PlayerPrefs.SetInt ("health", health);
		}
	}

	void OnTriggerEnter2D(Collider2D coll){
		if (coll.gameObject.tag == "TrackSpawner") {
			Vector3 newPos = car.position + offset;
			newPos.y = -13.35f;
			Instantiate (track , newPos,Quaternion.identity);
		}
	}

	void OnCollisionExit2D(){
		isGround = false;
	}

	void RotateLeft(){
		
		Vector3 tempRoatation = tankHead.transform.localEulerAngles;
		if (tempRoatation.z > 1f && tempRoatation.z < 90f) {
			tempRoatation.z += roatation * Time.deltaTime;
			tankHead.transform.localEulerAngles = tempRoatation;
		} else {
			tempRoatation.z -= 2f;
			tankHead.transform.localEulerAngles = tempRoatation;
		}
	
	}

	void RotateRight(){
		
		Vector3 tempRoatation = tankHead.transform.localEulerAngles;
		if (tempRoatation.z > 1f && tempRoatation.z < 90f) {
			tempRoatation.z -= roatation * Time.deltaTime;
			tankHead.transform.localEulerAngles = tempRoatation;
		}
		else {
			tempRoatation.z += 2f;
			tankHead.transform.localEulerAngles = tempRoatation;
		}

	}

	void Fire(){/*
		GameObject bulletHolder = Instantiate (bulletTank) as GameObject;
		bulletHolder.transform.position = shootingPoint.transform.position;
		bulletHolder.transform.rotation = shootingPoint.transform.rotation;
		Vector2 temp = shootingPoint.transform.localEulerAngles;
		temp.x = shootingPointSpeed * Time.deltaTime;
		temp.y = shootingPointSpeed * Time.deltaTime;
		bulletHolder.GetComponent<Rigidbody2D> ().AddRelativeForce (new Vector2(temp.x,temp.y),ForceMode2D.Force);
		*/
	}

}
