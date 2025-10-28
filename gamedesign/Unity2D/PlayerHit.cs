using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHit : MonoBehaviour {

	public int PlayerLives = 5;
	public GameObject hitEffectAnim;
	private Renderer rend;
	private GameController gameControllerObj;

	void Start () {
		rend = GetComponent<Renderer> ();	

		GameObject gameControllerLocation = GameObject.FindWithTag ("GameController");
		if (gameControllerLocation != null) {
			gameControllerObj = gameControllerLocation.GetComponent<GameController> ();
		}
	}


	void OnCollisionEnter2D(Collision2D collision){
		if ((collision.gameObject.tag == "enemy") || (collision.gameObject.tag == "bulletEnemy")) {
			PlayerLives -= 1;
			gameControllerObj.LifeChange (-1);
			StopCoroutine("HitPlayer");
			StartCoroutine("HitPlayer");
		}
	}

	IEnumerator HitPlayer(){
		// color values are R, G, B, and alpha, each divided by 100
		rend.material.color = new Color(2.4f, 0.9f, 0.9f, 0.5f);
		if (PlayerLives < 1){
			GameObject animEffect = Instantiate (hitEffectAnim, transform.position, Quaternion.identity);
			Destroy(animEffect, 0.5f);
			Destroy(gameObject);
		}
		else yield return new WaitForSeconds(0.5f);
		rend.material.color = Color.white;
	}

}
