using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellExtractorScript : MonoBehaviour {

	public Transform shellExtractor;
	public Rigidbody2D shell;
	float randomExtractionForce, randomTorque;

	// Update is called once per frame
	void Update () {
		Fire ();
	}

	public void Fire ()
	{
		if (Input.GetButtonDown ("Fire1")) {
			randomExtractionForce = Random.Range (300f, 400f);
			randomTorque = Random.Range (500f, 1000f);
			ExtractShell ();
		}
	}

	void ExtractShell()
	{
		var extractedShell = Instantiate (shell, shellExtractor.position, shellExtractor.rotation);
		extractedShell.AddForce (shellExtractor.up * randomExtractionForce, ForceMode2D.Force);
		extractedShell.AddTorque (randomTorque);
	}

}
