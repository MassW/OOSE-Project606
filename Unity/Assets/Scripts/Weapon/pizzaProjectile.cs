using UnityEngine;
using System.Collections;

public class pizzaProjectile : MonoBehaviour {

	// the variable that handles whether the pizza has hit something or not

	public Vector3 projectileSpeed;
	 

	void Start(){

		Destroy (gameObject,2);
	}
	
	// Update is called once per frame
	void Update (){
		transform.Translate(0.3f,0,0);

	}
	void OnCollisionEnter2D(Collision2D collision){
		if(collision.gameObject.tag != "Player"){
					
			Destroy(gameObject);
		}
	
	}
	
}

