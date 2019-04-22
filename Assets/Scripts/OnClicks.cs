using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnClicks : MonoBehaviour {

	public GameObject pauseMenu;

	void Update(){
		if (Input.GetKeyDown (KeyCode.Escape)) {
			if (pauseMenu.active == true) {
				pauseMenu.SetActive (false);
				Time.timeScale = 1f;
			}
			else {
				pauseMenu.SetActive (true);
				Time.timeScale = 0f;
			}
		}
	}


	public void OpenPauseMenu(){
		pauseMenu.SetActive (true);
		Time.timeScale = 0f;
	}

	public void BacktoMainMenu(){
		Time.timeScale = 1f;
		SceneManager.LoadScene ("sceneMenu");
	}

	public void RestartGame(){
		SceneManager.LoadScene ("scene0");
		Time.timeScale = 1f;
	}

}
