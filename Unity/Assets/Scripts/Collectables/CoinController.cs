using UnityEngine;
using System.Collections;

public class CoinController : MonoBehaviour {
    
    // start coinCount at 0
    public static int coinCount = 0;
    
    // GUI interface
    void OnGUI(){
        string coinText = "Coins collected: " + coinCount;
        GUI.Box(new Rect(Screen.width - 150, 20, 130, 20), coinText);
    }
}