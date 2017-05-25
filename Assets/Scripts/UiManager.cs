using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour {

	public static UiManager instance;
	public Text scoreText;
	public Text highScoreText;
	public GameObject gameOverPanel;
	public GameObject startUi;
	public GameObject gameOverText;

	void Awake(){
		if( instance == null ){
			instance = this;
		}
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = ScoreManager.instance.score.ToString();
	}

	public void GameOver(){
		gameOverText.SetActive (true);
		highScoreText.text = "HIGH SCORE : " + PlayerPrefs.GetInt ("HighScore");
		gameOverPanel.SetActive (true);
	}

	public void Replay(){
		SceneManager.LoadScene ("level1");
	}

	public void Menu(){
		SceneManager.LoadScene ("Menu");
	}

	public void GameStart(){
		startUi.SetActive (false);
	}
}
