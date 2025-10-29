using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GVR_Rotate : MonoBehaviour {

	public float spinForce = 40;

	void Update(){
		transform.Rotate(0, spinForce * Time.deltaTime, 0);
	}

	public void ChangeSpin(){
		spinForce = -spinForce;
	}
}