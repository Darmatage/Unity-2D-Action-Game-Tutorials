using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PowerBoostBar : MonoBehaviour {

	public float fullPower = 100f;
	public float fullPowerPause = 1.5f;
	private float power;
	//public GameObject deathEffect;
	public Image PowerBoostImageBar;
	public Color highColor = new Color(0.3f, 0.8f, 0.3f);
	public Color lowColor = new Color(0.8f, 0.3f, 0.3f);

	//temporary time variables:
	private bool atFullPower = false;
	private bool timerPaused = false;
	private float theTimer;
	private float increaseAmt = 1f;
	public float speedUp = 1f;

	private void Start () {
		power = 0;
		theTimer= 0;
	}

	// this timer is just to test damage. Comment-out when no longer needed
	void FixedUpdate () {
		if (timerPaused == false) {
			ChangePower(increaseAmt);
			theTimer += (Time.deltaTime * speedUp);
			if (atFullPower == true) {
				StartCoroutine(PauseAtFullBoost());

			}
		}
	}

	public void SetColor(Color newColor){
		PowerBoostImageBar.GetComponent<Image>().color = newColor;
	}

	public void ChangePower (float amount){
		power += amount;
		PowerBoostImageBar.fillAmount = power / fullPower;
		//change color at high power:
		if (PowerBoostImageBar.fillAmount >= 1){
			atFullPower = true;
		}
		else if (power <= (fullPower/50) * 49){
			SetColor(lowColor);
		}
		else {
			SetColor(highColor);
		}
	}

	IEnumerator PauseAtFullBoost(){
		timerPaused = true;
		yield return new WaitForSeconds(fullPowerPause);
		ChangePower(-fullPower);
		theTimer = 0;
		atFullPower = false;
		timerPaused = false;
	}

} 