using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour{

	public int rotX;
	public int rotY=30;
	public int rotZ;
	
	void Update () {
        transform.Rotate (new Vector3 (rotX, rotY, rotZ) * Time.deltaTime);
         }

}