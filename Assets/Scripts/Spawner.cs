using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class Spawner : MonoBehaviour {

	public GameObject enemy1;
	public GameObject enemy2;
	public GameObject enemy3;
	public GameObject enemy4;

	public Transform target;

	private Vector3 offset;
	private Vector3 offsetR;

	void Start () {
		offset.x = 40;
		offset.y = 5;
		InvokeRepeating ("SpawnEnemy",3f,3f);
	}

	void SpawnEnemy(){
		int random = Random.Range (0 , 5);
		if (random == 0) {
			Instantiate (enemy1, target.position + offset, Quaternion.identity);
		}
		if (random == 1) {
			offsetR.x = 50;
			offsetR.y = 4;
			Instantiate (enemy2,target.position + offsetR,Quaternion.identity);
		}
		if (random == 2) {
			offsetR.x = 50;
			offsetR.y = 4;
			Instantiate (enemy3,target.position + offsetR,Quaternion.identity);
		}
		if (random == 3) {
			offsetR.x = 50;
			offsetR.y = 4;
			Instantiate (enemy4,target.position + offsetR,Quaternion.identity);
		}

	}
}
