using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickeringLight : MonoBehaviour {

	private Light thisLight;
	public float minWait = 0.05f;
	public float maxWait = 0.2f;
	public int brightMin = 1;
	public int brightMax = 5;
	public float lampDelay = 0.15f;

	private bool lampOn = false;
	private bool fireOn = false;

	public enum FlickerType { StreetLamp, OpenFlame, None }
	public FlickerType flickertype;


	void Start(){
		thisLight = GetComponent<Light>();
	}


	void Update (){
		switch(flickertype){
		case FlickerType.StreetLamp: 
			if (lampOn == false) {
				lampOn = true;
				fireOn = false;
				StartCoroutine(FlickerLamp());
			}
			break;
		case FlickerType.OpenFlame:
			if (fireOn == false) {
				fireOn = true;
				lampOn = false;
				StartCoroutine(FlickerFire());
			}
			break;
		case FlickerType.None:
			lampOn = false;
			fireOn = false;
			break;
		}
	}


	IEnumerator FlickerLamp () {
		while (lampOn == true){
			for (int counter = 0; counter < 10; counter++){
				if (counter == 9){
					yield return new WaitForSeconds(Random.Range(minWait,maxWait));
					thisLight.intensity=brightMin;
					yield return new WaitForSeconds(Random.Range(minWait,maxWait));
					thisLight.intensity=brightMax;
					yield return new WaitForSeconds(Random.Range(minWait,maxWait));
					thisLight.intensity=brightMin;
					yield return new WaitForSeconds(Random.Range(minWait,maxWait));
					thisLight.intensity=brightMax;
					yield return new WaitForSeconds(Random.Range(minWait,maxWait));
					thisLight.intensity=brightMin;
					yield return new WaitForSeconds(Random.Range(minWait,maxWait));
					thisLight.intensity=brightMax;
					yield return new WaitForSeconds(Random.Range(minWait,maxWait));
					thisLight.intensity=brightMin;
					yield return new WaitForSeconds(Random.Range(minWait,maxWait));
					thisLight.intensity=brightMax;
					//thisLight.enabled=true;
					//thisLight.enabled =! thisLight.enabled;
					Debug.Log("Lamp");
				}
				else {
					thisLight.enabled=true;
					yield return new WaitForSeconds(lampDelay);
				}
			}
		}
	}

	IEnumerator FlickerFire () {
		while (fireOn == true){
			yield return new WaitForSeconds(Random.Range(minWait,maxWait));
			thisLight.intensity=brightMin;
			yield return new WaitForSeconds(Random.Range(minWait,maxWait));
			thisLight.intensity=brightMax;
			Debug.Log("Fire");
		}
	}

}