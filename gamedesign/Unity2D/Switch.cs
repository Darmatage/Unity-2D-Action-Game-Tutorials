using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour {

	private GameController gameControllerObj;
	public GameObject OffSwitch;

	// Use this for initialization
	void Start () {
		GameObject gameControllerLocation = GameObject.FindWithTag ("GameController");
		if (gameControllerLocation != null) {
			gameControllerObj = gameControllerLocation.GetComponent<GameController> ();
		}
	}

	// if the player hits the switch, reduce # of switches remaining in HUD, display the off-switch and remove the on-switch
	void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.tag == "Player") {
			gameControllerObj.AddSwitch (-1);
			//Instantiate (OffSwitch, transform.position, Quaternion.identity);
			Instantiate (OffSwitch, transform.position, transform.rotation);
			Destroy(gameObject);
		}
	}

}
