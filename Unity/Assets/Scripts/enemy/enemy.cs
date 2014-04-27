using UnityEngine;
using System.Collections;
using System.Collections.Generic;



public class enemy : MonoBehaviour {
	
	public List<GameObject> wayPoints;
	public int nextWayPoint = 0;
	public float speed = 10.0f;
	public string state = "patrol";
	public float height;
	private bool dead;
	
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
		// Allows for the player to kill enemy by jumping on top of the enemy 
		RaycastHit hit;
		Ray killRay = new Ray(transform.position, Vector3.up);
		
		if(!dead){
			if(Physics.Raycast(killRay, out hit, height)){
				if(hit.collider.tag == "Player")
				{
					Destroy(this.gameObject);
				}
			}
		}
		
		switch(state){
		case "patrol": // lets enemy partol between two waypoints in the environment
			if (wayPoints.Count > 0){
				transform.LookAt(wayPoints[nextWayPoint].transform.position);
				transform.position += transform.forward * speed * Time.deltaTime;
				
				if (Vector3.Distance(transform.position,wayPoints[nextWayPoint].transform.position) < 0.5){
					nextWayPoint = (nextWayPoint+1) % wayPoints.Count;
				}
			}
			
			break;
		}
	}
}
