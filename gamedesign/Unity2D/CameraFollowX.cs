using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowX : MonoBehaviour {
	// this script is aplied to a camera meant to folow the player, without LERP.

	public GameObject player; // reference to player object
	private Vector3 offset; // distance we want to maintain from the player

	void Start () {
		// get player by tag
		if (GameObject.FindGameObjectWithTag ("Player") != null) {
			player = GameObject.FindGameObjectWithTag ("Player");
		}
		// camera position - object position before first frame
		offset = transform.position - player.transform.position; 
	}

	// LateUpdate is called after all other Scene Object scripts finish their Updates
	void LateUpdate () {
		Vector3 newPos = new Vector3 ((player.transform.position.x + offset.x), transform.position.y, transform.position.z);
		transform.position = newPos;
	}
}
