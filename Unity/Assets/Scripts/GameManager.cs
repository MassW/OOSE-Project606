using UnityEngine;
using System.Collections;

// Instantiate the player when it spawns

public class GameManager : MonoBehaviour {
	
	public GameObject NewPlayer;
	private GameCamera cam;
	public bool won = false;
	
	// Use this for initialization
	void Start () {
		cam = GetComponent<GameCamera>();
		SpawnPlayer();
		
	}
	
	// Obsolete
	private void SpawnPlayer(){
		cam.SetTarget((Instantiate(NewPlayer,Vector3.zero, Quaternion.identity) as GameObject).transform);
	}
	
	void win()
	{
		
		print("WIN");
		// handles GUI for "Win" (10 collected coins). Loads "test_scene" if buttons is pressed. 
		if (GUI.Button(new Rect(Screen.width / 2-200, Screen.height / 2, 400, 50), "YOU WON. Press to restart"))
		{
			Application.LoadLevel("test_scene");
		}
		
	}
	
	void OnGUI()
	{
		if (won)
		{
			win();
		}
		
	}
	
}

