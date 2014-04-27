﻿using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour {

	// Use this for initialization
	public int pizzaAmmount;
	public GameObject pizza;


	void Start () {
		pizzaAmmount = 5;

	}
	void OnGUI(){
		string pizzaText = "Pizzas: " + pizzaAmmount;
		GUI.Box(new Rect(Screen.width - 150, 40, 130, 20), pizzaText);
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1")){
			if (pizzaAmmount > 0){
				GameObject clone = Instantiate(pizza, transform.position, transform.rotation) as GameObject;

				pizzaAmmount--;
		    	print(pizzaAmmount);
			}
		}
	}

}
