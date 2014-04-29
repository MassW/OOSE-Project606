using UnityEngine;
using System.Collections;

public class CoinController : MonoBehaviour {
    
    // start coinCount at 0
    public static int coinCount;

	void Start()
	{
		coinCount = 0; 
	}
    
    // GUI interface
    void OnGUI(){
        string coinText = "Coins collected: " + coinCount + " / 10";
        GUI.Box(new Rect(Screen.width - 170, 20, 150, 20), coinText);
    }
}