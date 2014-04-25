using UnityEngine;
using System.Collections;

public class pizzaProjectile : MonoBehaviour {

	// the variable that handles whether the pizza has hit something or not
	private bool pizzaState;
	private GameObject playerData;

	void Start(){
		playerData = GameObject.Find("Player");// GetComponent(GameObject.FindGameObjectWithTag("Player"));
	}
	
	// Update is called once per frame
	void Update () {

		if (playerData.transform.localScale.x>0){
			for(int i = 0; i>20; i++){

			}
		}
	
	}
}
