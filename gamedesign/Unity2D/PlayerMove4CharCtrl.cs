using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove4CharCtrl : MonoBehaviour {

	public CharacterController2D controller;
	public float runSpeed = 40f;
	float horizontalMove = 0f;

	// Use this for initialization
	void Update () {
		//Horizontal axis: [a]/left arrow is -1, [d]/right arrow is 1
		horizontalMove = Input.GetAxisRaw ("Horizontal") * runSpeed;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//move player
		controller.Move(horizontalMove * Time.fixedDeltaTime, false, false);
	}
}
