using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GVR_Color : MonoBehaviour {

	public Renderer rend;
	public Vector3 clrs;

	void Start (){
		rend = gameObject.GetComponent<Renderer>();
	}

	public void ChangeColor(){
		clrs.x = Random.Range (0.5f, 1f);
		clrs.y = Random.Range (0.5f, 1f);
		clrs.z = Random.Range (0.5f, 1f);
		rend.material.color = new Color(clrs.x, clrs.y, clrs.z); 
	}
}