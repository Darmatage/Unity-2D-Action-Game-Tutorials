using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.PlayerInput;  

public class PlayerControl : MonoBehaviour {

	Vector2 i_move;
	float moveSpeed =10f;
	float JumpSpeed = 500;
	private Vector3 startPosition;
	private Rigidbody rb;

	void Awake (){  
		startPosition = transform.position; 
		rb = GetComponent<Rigidbody>();  
	}

	void Update() {
		Move();
	}

	private void Move(){
		Vector3 moves = new Vector3(i_move.x, 0, i_move.y) * moveSpeed * Time.deltaTime;
		transform.Translate(moves);
	}

	private void OnMove (InputValue value) {
		i_move = value.Get<Vector2>();
		Debug.Log("Moving!");
	}


	private void OnJump(){
		if (transform.position.y <= (startPosition.y + 1)){
			rb.AddForce(Vector3.up * JumpSpeed);
			Debug.Log("I'm Jumping!");
		} else {
			Debug.Log("I'm too high to jump." + startPosition + transform.position);
		}
	}
}