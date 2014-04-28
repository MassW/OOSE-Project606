using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour
{
	public float bounceSpeed = 0.002f;// how fast is the enemy moving
	
	public bool itemBounceUp = false;//checks if the platform is moving up
	
	void Start ()
	{
		StartCoroutine ("itemBounce", 0.8f); // how fast does the platform switch direction
	}
	
	void Update ()
	{
		// makes the enemy turn when the itemBounceUp switch betwen true and false
		Vector3 myTransform = transform.position;
		
		if (itemBounceUp == true)
		{
			myTransform.y += bounceSpeed;
			transform.position = myTransform;
		}
		
		else if (itemBounceUp == false)
		{
			myTransform.y -= bounceSpeed;
			transform.position = myTransform;
		}
	}
	// makes the platform move
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