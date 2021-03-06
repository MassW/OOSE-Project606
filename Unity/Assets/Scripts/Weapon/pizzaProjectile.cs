﻿using UnityEngine;
using System.Collections;

public class pizzaProjectile : MonoBehaviour {

	// the variable that handles whether the pizza has hit something or not


	Controller_improved controller_improved;
	public AudioClip impact;
	float projectileSpeed;

	void Start(){

		controller_improved = GameObject.FindWithTag("Player").gameObject.GetComponent<Controller_improved>();
		if(controller_improved.facingRight)
			projectileSpeed = 0.3f;
		else
			projectileSpeed = -0.3f;

		Destroy (gameObject,2);
	}
	
	// Update is called once per frame
	void Update (){
		transform.Translate(projectileSpeed,0,0);

	}
	void OnCollisionEnter2D(Collision2D collision){

		if(collision.gameObject.tag == "Boss"){
			
			collision.gameObject.GetComponent<boss>().bossLife-=1;
		}
		if(collision.gameObject.tag != "Player"){

			AudioSource.PlayClipAtPoint(impact, transform.position);


			Destroy(gameObject);


		}
		
		if(collision.gameObject.tag == "Enemy"){
			
			collision.gameObject.GetComponent<enemy>().Hurt();

		}
	
	}
	
}

