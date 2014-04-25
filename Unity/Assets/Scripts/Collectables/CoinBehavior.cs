using UnityEngine;
using System.Collections;

public class CoinBehavior : MonoBehaviour {


	void Start(){

		print("wuhu");
	}

	void OnCollisionEnter2D(Collision2D collider){

		if (collider.transform.name == "NewPlayer") {
			CoinController.coinCount++;
			Destroy(this.gameObject);
			print ("hit");
		}
		/*switch(collider2D.gameObject.name){

			//to destroy coin
		case "NewPlayer":

			CoinController.coinCount++;
			Destroy(this.gameObject);
			print("wuhu");

			break;
		}*/
	}
}
