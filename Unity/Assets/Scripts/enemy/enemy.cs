using UnityEngine;
using System.Collections;
using System.Collections.Generic;



public class enemy : MonoBehaviour {
	

	public float height; // height of the Raycast
	private bool dead = false; // checks if enemy is alive
	public float bounceSpeed = 0.002f; // how fast is the enemy moving
	public bool itemBounceUp = false; // checks if the enemy is moving
	public int HP = 2; //enemy health point
	
	
	// Use this for initialization
	void Start () {
		StartCoroutine ("itemBounce", 1.5f);//how long between turns
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

		// makes the enemy turn when the itemBounceUp switch betwen true and false
		Vector3 myTransform = transform.position;
		if (itemBounceUp == true)
		{
			myTransform.x += bounceSpeed;
			transform.position = myTransform;
		}
		else if (itemBounceUp == false)
		{
			myTransform.x -= bounceSpeed;
			transform.position = myTransform;
		}

		// If the enemy has zero or fewer hit points and isn't dead yet...
		if(HP <= 0 && !dead)
			// ... call the death function.
			Death ();
	}

	// make the enemy loose 1 HP every time he is hit by a pizza
	public void Hurt()
	{
		// Reduce the number of hit points by one.
		HP--;
	}

	// kills the enemy and takes him out of the game
	public void Death()
	{
		dead = true;
		Destroy(this.gameObject);

	}
		// makes the enemy move
		IEnumerator itemBounce (float repeatAfter)
		{
			int i;
			for (i=1; i>0; i++)
			{
				if (itemBounceUp)
				{
					itemBounceUp = false;
					yield return new WaitForSeconds (repeatAfter);
				}
				else if (itemBounceUp == false)
				{
					itemBounceUp = true;
					yield return new WaitForSeconds (repeatAfter);
				}
			}
		}
	}
