using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveSmooth : MonoBehaviour {

	private Rigidbody2D rb2D;
	private bool FaceRight = true;  // determine which way player is facing.
	private Vector3 charVelocity = Vector3.zero;
	private float moveSmooth = .01f;

	public float runSpeed = .01f;
	float horizontalMove = 0f;

	private void Awake(){
		rb2D = GetComponent<Rigidbody2D>(); 
	}
	
	void Update () {
		//Horizontal axis: [a]/left arrow is -1, [d]/right arrow is 1
		horizontalMove = Input.GetAxisRaw ("Horizontal") * runSpeed;
	}
	
	void FixedUpdate () {
		//move player
		Move(horizontalMove * Time.fixedDeltaTime);
	}



	public void Move (float move){
		// Move player by finding target velocity
		Vector3 targetVelocity = new Vector2(move * -.5f, rb2D.velocity.y);
		// then smooth it out and apply to player
		rb2D.velocity = Vector3.SmoothDamp(rb2D.velocity, targetVelocity, ref charVelocity, moveSmooth);

		// if input is moving player right and player faces left, turn
		if (move > 0 && !FaceRight){
			// ... flip the player.
			Turn();
		}

		// if input is moving player left and player faces right, turn
		else if (move < 0 && FaceRight){
			Turn();
		}

	}

	private void Turn()
	{
		// Switch the way the player is labelled as facing.
		FaceRight = !FaceRight;

		// Multiply the player's x local scale by -1.
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
		//transform.Rotate += 180;
	}


}
