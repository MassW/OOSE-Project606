using UnityEngine;
using System.Collections;

public class boss : MonoBehaviour {
	
	// Use this for initialization

	public GameObject croissaint;
	GameObject clone;
	Vector3 croissantVelocity;
	bool bossAlive;
	
	
	void Start () {
		bossAlive = true;

		InvokeRepeating ("LaunchProjectile", 3,2);

	}
	void LaunchProjectile (){
		clone = Instantiate(croissaint, transform.position, transform.rotation) as GameObject;
		print("croissant fired");
	}

	// Update is called once per frame
	void Update () {




			
		
	}
	
}
