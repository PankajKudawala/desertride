using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		InvokeRepeating ("LoadScene", 3f, 3f);
	}

	void LoadScene(){
		SceneManager.LoadScene ("sceneMenu");
	}
}
