using UnityEngine;
using System.Collections;

public class killfloor : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
		void OnTriggerEnter2D (Collider2D col) 
		{
			// If it hits an enemy...
			if(col.tag == "Player")
			{
				// ... find the Enemy script and call the Hurt function.
				col.gameObject.GetComponent<PlayerHealth>().killed();
		
			}
	
	
	
		}
}
