using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveHit : MonoBehaviour {

	public float speed = 4f;
	private Transform target;

	public int EnemyLives = 3;
	private Renderer rend;
	private GameController gameControllerObj;

	void Start () {
		rend = GetComponent<Renderer> ();

		if (GameObject.FindGameObjectWithTag ("Player") != null) {
			target = GameObject.FindGameObjectWithTag ("Player").GetComponent<Transform> ();
		}
		GameObject gameControllerLocation = GameObject.FindWithTag ("GameController");
		if (gameControllerLocation != null) {
			gameControllerObj = gameControllerLocation.GetComponent<GameController> ();
		}
	}

	void Update () {
		if (target != null){
			transform.position = Vector2.MoveTowards (transform.position, target.position, speed * Time.deltaTime);
		}
	}

	void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.tag == "bullet") {
			EnemyLives -= 1;
			StopCoroutine("HitEnemy");
			StartCoroutine("HitEnemy");
		}
		else if (collision.gameObject.tag == "Player") {
			EnemyLives -= EnemyLives;
			rend.material.color = new Color(2.4f, 0.9f, 0.9f, 0.5f);
			Destroy(gameObject);
		}
	}

	IEnumerator HitEnemy(){
		// color values are R, G, B, and alpha, each divided by 100
		rend.material.color = new Color(2.4f, 0.9f, 0.9f, 0.5f);
		if (EnemyLives < 1){
			gameControllerObj.AddScore (1);
			Destroy(gameObject);
		}
		else yield return new WaitForSeconds(0.5f);
		rend.material.color = Color.white;
	}

}
