using UnityEngine;
using System.Collections;

public class addAmmo : MonoBehaviour {

	// Use this for initialization
	private int ammoInBox;
	Weapon weapon;

	void Start () {

		ammoInBox = Random.Range(1,5);
		print ("ammo in box " + ammoInBox);
		weapon = GameObject.FindWithTag("Player").gameObject.GetComponent<Weapon>();
	}

	void Update(){

	
	}
	
	void OnCollisionEnter2D (Collision2D collision){
		if(collision.transform.tag == "Player"){
			print ("collide");
			weapon.pizzaAmmount+=ammoInBox;
			Destroy(this.gameObject);

		}
	}
}
