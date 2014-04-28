///<summary>
/// Main menu
/// Attached to main camera.
/// </summary>
using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {
	public GUIStyle MenuItemStyle;
	public Texture2D backgroundTexture;
	public GUIStyle StartButton;


	

		

	void OnGUI(){
//Display our background texture
		GUI.DrawTexture(new Rect(0,0,Screen.width, Screen.height), backgroundTexture);

//Display our buttons and put them at dynamic locations that adjust with the ammount that they are multiplied with.


		//start game button
		if(GUI.Button(new Rect(Screen.width * 0.15f, Screen.height * 0.6f, Screen.width * 0.2f, Screen.height * 0.1f), "Start the game",StartButton)){
			print("Let the GAME begin...");
			Application.LoadLevel ("test_scene");
		}

		//Quit button
		if(GUI.Button(new Rect(Screen.width * 0.15f, Screen.height * 0.75f, Screen.width * 0.2f, Screen.height * 0.1f), "Go home!",StartButton)){
			print("Bye bye...");
			Application.Quit();
		}

		//Here is the stylization of the buttons
		StartButton = new GUIStyle(GUI.skin.button);
		StartButton.normal.textColor = Color.green;
		StartButton.hover.textColor  = Color.red;

		


	}
}
