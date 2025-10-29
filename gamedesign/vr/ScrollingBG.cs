using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBG : MonoBehaviour{

	public float BGspeedX = 0.5f;
	public float BGspeedY = 0;
	public Renderer BGrend;

	void Start(){
		BGrend = GetComponent<Renderer>();
	}

	void Update () {
		Vector2 hOffset	= new Vector2 (Time.time * BGspeedX, Time.time * BGspeedY);
		BGrend.material.mainTextureOffset = hOffset;		
	}
}