using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class RobotScript : MonoBehaviour {

	public float healthRobot = 1000f;
	public Animator animR;

	void Start(){
	}

	void Update(){
		if (healthRobot == 0f || healthRobot < 0f) {
			animR.SetFloat ("healthRobot", -1f);
			Physics2D.IgnoreCollision (gameObject.GetComponent<Collider2D> (), GetComponent<Collider2D> ());
			Destroy (gameObject, 3f);
		}

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
