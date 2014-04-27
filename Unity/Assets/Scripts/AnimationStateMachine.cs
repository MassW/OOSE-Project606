using UnityEngine;
using System.Collections;

public class AnimationStateMachine : MonoBehaviour {
	Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		float move = Input.GetAxis ("Horizontal");
		print (move);
		if (move < -0.01f || move > 0.01f)
			animator.SetBool("move",true);
			else	
			animator.SetBool("move",false);
	}
}
