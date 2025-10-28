using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunBox : MonoBehaviour {

	public ParticleSystem impactParticles;
	public Vector3 SpawnParticlesHere;

	private float hits = 0;
	private AudioSource audioClip;
	private float clipStartPitch;
	private float clipPitch;
	private float clipVolume;

	private float r ;  // red component
	private float g ;  // green component
	private float b ;  // blue component

	void Awake() {
		audioClip = GetComponent<AudioSource>();
		clipStartPitch = audioClip.pitch;
		clipPitch = audioClip.pitch;
		clipVolume = audioClip.volume;
	}

	void OnCollisionEnter(Collision other){

		//if the impact has enough force
		if (other.relativeVelocity.magnitude > 5) {
			//get impact location
			SpawnParticlesHere = other.contacts[0].point;
			//make particles
			Instantiate (impactParticles, SpawnParticlesHere, other.transform.rotation);
			//play audio
			audioClip.Play();

			//increment hits #
			hits += 1;
			//if pitch is above 0, lower pitch per hits
			if (clipPitch > 0){
				clipPitch = (clipStartPitch - (hits/10));
				print ("Pitch = " + clipPitch);
				audioClip.pitch = clipPitch;
				audioClip.volume = clipVolume / 2;
			}

			//randomize colors, but go from warm to cool 
			if (hits <= 4) {
				r = Random.Range (0.3f, 1f);
				g = Random.Range (0.1f, 0.5f);
				b = Random.Range (0f, 0.2f);
			}
			if (hits > 4) {
				r = Random.Range (0f, 0.3f);
				g = Random.Range (0f, 0.3f);
				b = Random.Range (0.3f, 1f);
			}
			//print ("rgb = " + r + " " + g + " " + b);

			var cubeRenderer = GetComponent<Renderer>();
			cubeRenderer.material.color = new Color(r,g,b);
			//print ("material = " + cubeRenderer.material.color);
		}
	}

}


//https://forum.unity.com/threads/how-to-instantiate-gameobject-at-the-point-of-collision.531014/
//spawn particles at a location in space
//SpawnParticlesHere = new Vector3 (transform.position.x, 0, transform.position.z);
//Instantiate(impactParticles, SpawnParticlesHere, other.transform.rotation);


//https://answers.unity.com/questions/794718/how-to-get-transform-of-contactpoint-in-oncollisio.html
//spawn particles at impact location

//https://docs.unity3d.com/ScriptReference/Collision-relativeVelocity.html
//make a condition on impact relative velocity