	using UnityEngine;
	using System.Collections;
	
	// Code reference to: https://www.youtube.com/watch?v=6HG_oAYDY2Y
	// has been modified to fit our game
	
	public class PlayerHealth : MonoBehaviour
	{
		
		//variables
		public int maxHealth = 100;
		public static int curHealth = 100;
		public bool dead = false;
		public float healthBarLength;
		
		
		// Use this for initialization
		void Start()
		{   
			healthBarLength = Screen.width / 2;
		}
		
		// Update is called once per frame
		void Update()
		{
			// if current health is under 0, the player is dead and curHealth set to 0. 
			// curHealth can be above maxHealth (100).
			if (curHealth < 0)
			{
				curHealth = 0;
				dead = true;
			}
			if (curHealth > maxHealth)
			{
				curHealth = maxHealth;
			}
			// sets our heathbar length 
			healthBarLength = (Screen.width / 2) * (curHealth / (float)maxHealth); 
			
		}
		// health bar GUI. Indicates lives left. Calls Dead() if dead is true
		void OnGUI()
		{
			GUI.color = Color.red;
			GUI.Box(new Rect(0, 0, healthBarLength, 20), "Lives left: " + curHealth);
			if (dead == true)
			{
				Dead();
			}
		}
		// sets curHealth to 0
		public void killed()
		{
			dead = true;
			curHealth = 0;
			
		}
		// handles GUI for GameOver. Loads "test_scene" if buttons is pressed. 
		void Dead()
		{
			gameObject.GetComponent<Controller_improved>().enabled = false;
			if (GUI.Button(new Rect(Screen.width / 2, Screen.height / 2, 400, 50), "GAME OVER. Press to restart"))
			{
				curHealth = 100;
				Application.LoadLevel("test_scene");
			}
		}
	}
