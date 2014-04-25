using UnityEngine;
using System.Collections;

// Instantiate the player when it spawns

public class GameManager : MonoBehaviour {

	public GameObject NewPlayer;
	private GameCamera cam;

	// Use this for initialization
	void Start () {
		cam = GetComponent<GameCamera>();
		SpawnPlayer();

	}
	
	private void SpawnPlayer(){
		cam.SetTarget((Instantiate(NewPlayer,Vector3.zero, Quaternion.identity) as GameObject).transform);
	}
}
