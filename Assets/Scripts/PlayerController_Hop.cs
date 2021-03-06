using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_Hop : MonoBehaviour {

	public float moveSpeed = 2f;
	public float jumpHeight = 7f;
	public float walkJumpHeight = 2f;

	public bool grounded;
	public Transform groundProb;
	public float groundProbRadius = 0.1f;
	public LayerMask groundLayer;

	public Animator anim, anim_Hop;
	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		//anim = GetComponent<Animator> ();
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		anim.SetFloat ("SpeedY", rb.velocity.y);
		anim.SetBool ("Land", grounded);
		anim.SetBool ("Hop", false);
		anim.SetBool ("Jump", false);
		anim.SetBool ("Grounded", grounded);

		if (Input.GetKey (KeyCode.D)) {
			transform.localScale = new Vector3 (.07f, .07f, 1);
			rb.velocity = new Vector2 (moveSpeed, rb.velocity.y);
			anim.SetBool ("Hop", true);
			anim_Hop.SetBool ("Hopping", true);
		} else if (Input.GetKey (KeyCode.A)) {
			transform.localScale = new Vector3 (-.07f, .07f, 1);
			rb.velocity = new Vector2 (-moveSpeed, rb.velocity.y);
			anim.SetBool ("Hop", true);
			anim_Hop.SetBool ("Hopping", true);
		} else {
			anim_Hop.SetBool ("Hopping", false);
		}

		if (Input.GetKeyDown(KeyCode.Space) && grounded){
			rb.velocity = new Vector2 (rb.velocity.x, jumpHeight);
			anim.SetBool ("Jump", true);
		}
		grounded = Physics2D.OverlapCircle (groundProb.position, groundProbRadius, groundLayer);
	}
}
