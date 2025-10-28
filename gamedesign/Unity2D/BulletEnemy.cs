using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy : MonoBehaviour {

	public float speed = 10f;
	private Transform playerTrans;
	private Vector2 target;
	public GameObject hitEffectAnim;

	void Start() {
		//transform gets location, but we need Vector2 to get direction, so we can moveTowards.
		playerTrans = GameObject.FindGameObjectWithTag("Player").transform;
		target = new Vector2(playerTrans.position.x, playerTrans.position.y);
	}

	void Update () {
		transform.position = Vector2.MoveTowards (transform.position, target, speed * Time.deltaTime);
	}

	//if the bullet hits a collider, play the explosion animation, then destroy the effect and the bullet
	void OnTriggerEnter2D(Collider2D collision){
		if (collision.gameObject.tag != "enemyShooter") {

			GameObject animEffect = Instantiate (hitEffectAnim, transform.position, Quaternion.identity);
			Destroy (animEffect, 0.5f);
			Destroy (gameObject);
		}
	}
}