using UnityEngine;
using System.Collections;

public class activateGoal : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void goal(){
		if (CoinController.coinCount == 2){
			Debug.Log("WIN!!!!");
		}
	}
}
