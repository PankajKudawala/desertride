using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OnClick : MonoBehaviour {

	public GameObject settings;
	public GameObject highscorePanel;
	public Text highScore;

	public GameObject item1;


	void Update(){
		if (Input.GetKeyDown (KeyCode.Escape)) {
			if (settings.active == true) {
				settings.SetActive (false);
				item1.SetActive (true);
			}
			if (highscorePanel.active == true) {
				highscorePanel.SetActive (false);
				item1.SetActive (true);
			}
		}
		highScore.text = "High Score : " + PlayerPrefs.GetInt ("highscore");
	}

	public void Play(){
		SceneManager.LoadScene ("loading2");
	}

	public void OpenSettings(){
		item1.SetActive (false);
		settings.SetActive (true);
	}

	public void OpenHighScore(){
		item1.SetActive (false);
		highscorePanel.SetActive (true);
	}
}
