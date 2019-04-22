using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelScript : MonoBehaviour {

	public Transform barrel;
	public Rigidbody2D bullet;
	public float fireSpeed = 500f;

	// Update is called once per frame
	public Swipe swipeBarrel;
	void Update () {
		Fire ();
	}

	void Fire ()
	{
		if (swipeBarrel.Tap) {
			var firedBullet = Instantiate (bullet, barrel.position, barrel.rotation);
			firedBullet.AddForce (barrel.up * fireSpeed);
		}
	}

}
