using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager instanse;
	bool gameOver;

	void Awake(){
		DontDestroyOnLoad (this.gameObject);
		if (instanse == null) {
			instanse = this;
		} else {
			Destroy (this.gameObject);
		}
	}


	// Use this for initialization
	void Start () {
		gameOver = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void GameStart(){
		UiManager.instance.GameStart ();
		GameObject.Find ("PipeSpawner").GetComponent<PipeSpawner> ().StartSpawningPipes ();
	}

	public void GameOver(){
		gameOver = false;
		GameObject.Find ("PipeSpawner").GetComponent<PipeSpawner> ().StopSpawningPipes ();
		ScoreManager.instance.StopScore ();
		UiManager.instance.GameOver ();
	}
}
