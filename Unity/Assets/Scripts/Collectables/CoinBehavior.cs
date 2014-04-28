using UnityEngine;
using System.Collections;

public class CoinBehavior : MonoBehaviour {

// controls the coinCounter goes one point up pr. coin collected
// destroy coin when collisioned by the player

	void Start(){

		print("wuhu");
	}

	void OnCollisionEnter2D(Collision2D collider){

		if (collider.transform.name == "NewPlayer") {
			CoinController.coinCount++;
			Destroy(this.gameObject);
			print ("hit");
		}

	}
}
