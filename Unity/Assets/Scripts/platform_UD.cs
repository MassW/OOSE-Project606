using UnityEngine;
using System.Collections;
using System.Collections.Generic;



public class platform_UD : MonoBehaviour {
	
	public List<GameObject> wayPoints;
	public int nextWayPoint = 0;
	public float speed = 10.0f;
	public string state = "move";

	
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	
		// switch ase that make the platform mve between waypoint, script was dropped
		// because the LookAt part did not work with 2D sprites
		switch(state){
		case "move": // lets enemy partol between two waypoints in the environment
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
