using UnityEngine;
using System.Collections;

// code references to: http://unity3d.com/learn/tutorials/modules/beginner/2d/2d-controllers

public class Controller_improved : MonoBehaviour {
	// instance of PlayerHealth
	private PlayerHealth playerHealth;
	
	//hit is a bool used to control health is not drawn every time we enter or hit a enemy. Must only be once pr. hit.
	private bool hit = false;
	
	//how fast the character can go by maximum
	public float maxSpeed = 10f;
	// tells us where our character is facing
	public bool facingRight = true;
	// player is first not grounded 
	bool grounded = false;
	// checks is player is on the ground
	public Transform groundCheck;
	// ground radius
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
		
		
		//control how much to move player- we use Horizontal controls
		float move = Input.GetAxis ("Horizontal");
		
		rigidbody2D.velocity = new Vector2 (move * maxSpeed, rigidbody2D.velocity.y);
		
		// Automatically flip the player when facing left and right
		if (move > 0 && !facingRight)
			Flip ();
		else if (move < 0 && facingRight)
			Flip ();
	}
	
	void Update()
	{
		// Jump when space is pressed
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
	
	//when player hit an enemy, 10 is drawn from his life bar
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
