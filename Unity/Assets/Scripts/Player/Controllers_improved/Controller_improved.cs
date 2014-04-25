using UnityEngine;
using System.Collections;

public class Controller_improved : MonoBehaviour {

	private PlayerHealth playerHealth;
	private bool hit = false;


	//how fast the character can go by maximum
	public float maxSpeed = 10f;
	// tells us where our character is facing
	bool facingRight = true;

	bool grounded = false;
	public Transform groundCheck;
	float groundRadius = 0.2f;
	// what is ground? What can it land on :)
	public LayerMask whatIsGround;

	public float jumpForce = 700f;

	// Use this for initialization
	void Start () {
		playerHealth = new PlayerHealth ();
	}
	
	// Update is called once per frame
	// handles physics aswell 
	void FixedUpdate () {

		// check if we are on the ground, if we are hitting any colliders
		// will return true or false
		grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, whatIsGround);

	
		//control how much to move 
		float move = Input.GetAxis ("Horizontal");
		//print (grounded);

		rigidbody2D.velocity = new Vector2 (move * maxSpeed, rigidbody2D.velocity.y);

		if (move > 0 && !facingRight)
						Flip ();
				else if (move < 0 && facingRight)
						Flip ();
	}

	void Update()
	{
		if(grounded && Input.GetKeyDown(KeyCode.Space))
		{
			print ("jump");
			rigidbody2D.AddForce (new Vector2(0,jumpForce));

		}
	}


	// to flip our facing. Basically flipping the world 180 degrees, so er no longer need a left and right animation.
	void Flip()
	{
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	} 

	
	void OnCollisionEnter2D(Collision2D collision)
	{
		GameObject collidingObject = collision.gameObject;
		if (collidingObject.tag == "Enemy" && hit == false) {
			print ("hit enemy");
			//this.GetComponent<PlayerHealth>.AdjustCurrentHealth(10);
			PlayerHealth.curHealth -= 10;
			hit = true;
			//playerHealth.AdjustCurrentHealth(playerHealth.curHealth - 10);
		}
	}
	void OnCollisionExit2D(Collision2D col){
		hit = false;
	}

}
