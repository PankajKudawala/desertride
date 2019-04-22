using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using GoogleMobileAds.Api;
using UnityEngine.SceneManagement;

public class MainGameManager : MonoBehaviour {


	public Text scoreText;
	public Text scoreTextGO;
	public Text healthText;
	int score =0;
	int health = 100;
	public GameObject gameOverPanel;
	bool gameOver = false;
	public AdManager ad;

	void Start () {
		if (gameOver == false) {
			Time.timeScale = 1f;
			score = 0;
			PlayerPrefs.SetInt ("score", score);
			PlayerPrefs.SetInt ("health", health);
			scoreText.text = "Score: " + score.ToString ();
			healthText.text = "Health: " + health;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerPrefs.GetInt ("health") > 0) {
			scoreText.text = "Score: " + PlayerPrefs.GetInt ("score").ToString ();
			healthText.text = "Health: " + PlayerPrefs.GetInt ("health").ToString ();
		} else {
			int highscore = PlayerPrefs.GetInt ("highscore");

			if (highscore < PlayerPrefs.GetInt ("score")) {
				PlayerPrefs.SetInt ("highscore",PlayerPrefs.GetInt ("score") );
			}
			gameOver = true;
			gameOverPanel.SetActive (true);
			scoreTextGO.text = "Score : " + PlayerPrefs.GetInt ("score");
			Time.timeScale = 0f;
			ad.LoadAdd ();
			ad.showADD ();
		}
	}
}
