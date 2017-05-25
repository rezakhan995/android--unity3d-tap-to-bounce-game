using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour {

	public float maxYPos;
	public float spawnTime;
	public GameObject pipe;

	// Use this for initialization
	void Start () {
		//StartSpawningPipes ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void StartSpawningPipes(){
		InvokeRepeating ("SpawnPipes", 0.2f, spawnTime);
	}

	public void StopSpawningPipes(){
		CancelInvoke ("SpawnPipes");
	}

	public void SpawnPipes(){
		Instantiate (pipe, new Vector3(transform.position.x, Random.Range(-maxYPos, maxYPos), 0), Quaternion.identity);
	}
}
