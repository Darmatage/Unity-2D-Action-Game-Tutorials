using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pColorName : MonoBehaviour
{
	private int count;
	private Renderer pRen;
	private float startPosX;

	void Start (){

		count = GameObject.FindGameObjectsWithTag("Player").Length;
		pRen = this.GetComponent<Renderer>();

		if(count == 1){
			pRen.material.color = new Color(0.5f,0.5f,1f);
			this.name = "Player1";
			startPosX = 1;
			Debug.Log("players =" + count);
		}
		else if (count == 2){
			pRen.material.color = new Color(1f,0.5f,0.5f);
			this.name = "Player2";
			startPosX = -1;
			Debug.Log("players =" + count);
		}
		else if (count == 3){
			pRen.material.color = new Color(0.5f,1f,0.5f);
			this.name = "Player3";
			startPosX = 3;
			Debug.Log("players =" + count);
		}
		else if (count == 4){
			pRen.material.color = new Color(0.7f,0.2f,0.7f);
			this.name = "Player4";
			startPosX = -3;
			Debug.Log("players =" + count);
		}

		transform.position = transform.position + new Vector3(startPosX,0,0);
	} 
}