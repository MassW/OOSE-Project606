using UnityEngine;
using System.Collections;

public class croissantBomb : MonoBehaviour {
	PlayerHealth playerHealth;
	// Use this for initialization
	void Start () {
		playerHealth = GameObject.Find("NewPlayer").gameObject.GetComponent<PlayerHealth>();
		Destroy (gameObject,3);
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(-0.3f,0.02f,0);

	}
	void OnCollisionEnter2D(Collision2D collision){
		if(collision.gameObject.tag == "Player"){
			PlayerHealth.curHealth -= 15;

		}
		if(collision.gameObject.tag != "Boss"){
			Destroy(this.gameObject);
		}
	}
}
