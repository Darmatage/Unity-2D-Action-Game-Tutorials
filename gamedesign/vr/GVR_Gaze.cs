using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GVR_Gaze : MonoBehaviour {

	public Image imgGaze;

	public float totalTime = 1f;
	bool gvrStatus;
	float gvrTimer;

	public int distanceOfRay = 50;
	private RaycastHit rayHit;

	void Update () {
		//create a ray to check distance:
		Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));

		if (Physics.Raycast(ray, out rayHit, distanceOfRay)){
			//code to fill reticule
			if (gvrStatus){
				gvrTimer += Time.deltaTime;
				imgGaze.fillAmount = gvrTimer / totalTime;
			}

			//code to teleport player:
			if (imgGaze.fillAmount == 1 && rayHit.transform.CompareTag("TeleportHere")){
				rayHit.transform.gameObject.GetComponent<GVR_Teleport>().TeleportPlayer();
			}
			//code to activate transform in another object:
			if (imgGaze.fillAmount == 1 && rayHit.transform.CompareTag("RotateThis") && gvrStatus){
				rayHit.transform.gameObject.GetComponent<GVR_Rotate>().ChangeSpin();
				gvrStatus = false;
			}
			//code to change color in another object:
			if (imgGaze.fillAmount == 1 && rayHit.transform.CompareTag("ColorSwitch") && gvrStatus){
				rayHit.transform.gameObject.GetComponent<GVR_Color> ().ChangeColor();
				gvrStatus = false;
			}

		}
	}

	public void GVROn(){
		gvrStatus = true;
	}

	public void GVROff(){
		gvrStatus = false;
		gvrTimer = 0;
		imgGaze.fillAmount = 0;
	}
}