using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobFloat : MonoBehaviour {
	
	public float bobAmplitude = 0.5f;
	public float bobFrequency = 1f;

	public float degreesPerSecondX = 0f;
	public float degreesPerSecondY = 0f;
	public float degreesPerSecondZ = 0f;

	Vector3 posOffset = new Vector3 ();
	Vector3 tempPos = new Vector3 ();

	void Start () {
		posOffset = transform.position;
	}

	void Update () {
		transform.Rotate(new Vector3(degreesPerSecondX * Time.deltaTime, degreesPerSecondY * Time.deltaTime, degreesPerSecondZ * Time.deltaTime), Space.World);

		// Float up/down with a Sin()
		tempPos = posOffset;
		tempPos.y += Mathf.Sin (Time.fixedTime * Mathf.PI * bobFrequency) * bobAmplitude;
		transform.position = tempPos;
	}
}
