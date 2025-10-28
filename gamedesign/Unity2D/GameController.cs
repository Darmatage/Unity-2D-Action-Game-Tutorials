using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	public GameObject textGameObject;
	static public int score = 0;		// these variables are static so they get sent to the next scene
	static public int livesLeft = 5; 
	static public int switchesLeft = 5;

	void Start () {
		UpdateScore ();
	}

	void Update (){
		if (Input.GetKey ("escape")) {
			Application.Quit ();
		}

		if(switchesLeft < 1){
			//end the game
			SceneManager.LoadScene(1);
		}
	}

	public void AddScore (int newScoreValue) {
		score += newScoreValue;
		UpdateScore ();
	}

	public void LifeChange (int newLifeValue) {
		livesLeft += newLifeValue;
		UpdateScore ();
	}
		
	public void AddSwitch (int newSwitchValue) {
		switchesLeft += newSwitchValue;
		UpdateScore ();
	}
		
	void UpdateScore(){
		Text scoreTextB = textGameObject.GetComponent<Text> ();
		scoreTextB.text = "Bugs Killed: " + score + '\n' + "Player Lives: " + livesLeft + '\n' + "Switches left: " + switchesLeft;
	}


}
