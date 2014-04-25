using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour {

	// Use this for initialization
	public int pizzaAmmount;
	public Vector3 projectileVelocity;
	public GameObject pizza;
	GameObject player;

	void Start () {
		pizzaAmmount = 5;
		projectileVelocity = new Vector3(0,1000);

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1")){
			if (pizzaAmmount > 0){
				GameObject clone = Instantiate(pizza, transform.position, transform.rotation) as GameObject;
				clone.transform.Translate(projectileVelocity);
				pizzaAmmount--;
		    	print(pizzaAmmount);
			}
		}
	
	}
}
