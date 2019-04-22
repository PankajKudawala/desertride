using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public Transform target;
	public Vector3 offset;
	public float smoothSpeed = 0.5f;

	void Start(){

	}


	void FixedUpdate(){
			offset.x = 7;
			Vector3 newPos = target.position + offset;
			Vector3 smoothedPosition = Vector3.Lerp(transform.position, newPos, smoothSpeed);
			smoothedPosition.y = transform.position.y;
			smoothedPosition.z = transform.position.z;
			transform.position = smoothedPosition;

	}

	void IncreaseRate(){
		if (offset.x != 7) {
			offset.x += 0.1f;
		} 
		if (offset.x == 7){
			CancelInvoke ("IncreaseRate");
		}
	}

	}

