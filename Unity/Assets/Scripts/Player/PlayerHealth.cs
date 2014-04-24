using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

	//variables
	public int maxHealth = 100;
	public int curHealth = 100;

	public bool dead = false;

	public float healthBarLength;
	

	// Use this for initialization
	void Start () {
	
		healthBarLength = Screen.width / 2;
	}
	
	// Update is called once per frame
	void Update () {


	}

	void OnGUI(){
		GUI.color = Color.red;
		GUI.Box(new Rect(0,0,healthBarLength , 20),"Lifes left: " + curHealth);
		if (dead == true) {
			Dead();
		}
	}



	public void AdjustCurrentHealth(int h){
		curHealth = h;
		if (curHealth < 0) {
			curHealth = 0;
			dead = true;
		}
		if (curHealth > maxHealth) {
			curHealth = maxHealth;
		}

		healthBarLength = (Screen.width / 2) * (curHealth / (float) maxHealth); 
	}

	void Dead(){
		if (GUI.Button(new Rect(Screen.width/2,Screen.height/2, 400, 50), "GAME OVER. Press to restart")) {
			Application.LoadLevel ("test_scene");
				}
	}
}
