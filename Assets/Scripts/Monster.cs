using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

public class Monster : MonoBehaviour {

	[SerializeField]
	GameObject bullet;
	public float healthRobot = 200f;

	public Transform monster;
	public Vector3 offsetM;


	float fireRate;
	float nextFire;


	void Start () {
		fireRate = 0.08f;
		nextFire = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		CheckIfTimeToFire ();
		if (healthRobot == 0f || healthRobot < 0f) {
			Destroy (gameObject, 1f);
		} else {
			Destroy (gameObject, 8f);
		}
	}

	void FixedUpdate(){
		//ChangeTransform ();
	}

	void CheckIfTimeToFire()
	{
		if (Time.time > nextFire && bullet !=null) {
			Instantiate (bullet, transform.position, bullet.transform.rotation);
			nextFire = Time.time + fireRate;
		}
		
	}

	void ChangeTransform(){
		monster.position += offsetM;
	}

	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag == "CarBullet") {
			if (healthRobot > 0f) {
				healthRobot -= 50f;
				int score = PlayerPrefs.GetInt ("score");
				score += 1;
				PlayerPrefs.SetInt ("score", score);
			}

		}
		if (coll.gameObject.tag == "Car") {
			if (healthRobot > 0f) {
				int health = PlayerPrefs.GetInt ("health");
				health -= 5;
				PlayerPrefs.SetInt ("health", health);
			}
		}
	}

}
