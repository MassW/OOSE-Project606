using UnityEngine;
using System.Collections;

public class pizzaProjectile : MonoBehaviour {

	// the variable that handles whether the pizza has hit something or not
	private bool pizzaState;
	private GameObject playerData;
	public Vector3 projectileSpeed;
//	public 

	void Start(){
		playerData = GameObject.Find("Player");// GetComponent(GameObject.FindGameObjectWithTag("Player"));
		Destroy (gameObject,2);
	}
	
	// Update is called once per frame
	void Update (){
		transform.Translate(0.3f,0,0);

	}
	void OnCollisionEnter(Collision collision){
		if(collision.gameObject.tag != "Player"){
					
			Destroy(gameObject);
		}
	
	}
	
}

