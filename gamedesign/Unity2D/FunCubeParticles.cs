using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunCubeParticles : MonoBehaviour {

	public ParticleSystem impactParticles;
	public Vector3 SpawnParticlesHere;

	private float hits = 0;

	void OnCollisionEnter(Collision other){
		//if the impact has enough force
		if (other.relativeVelocity.magnitude > 5) {
			//get impact location
			SpawnParticlesHere = other.contacts[0].point;
			//make particles
			Instantiate (impactParticles, SpawnParticlesHere, other.transform.rotation);
	
			//increment hits #
			hits += 1;
			}
	}

}
