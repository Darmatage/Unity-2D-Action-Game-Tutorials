using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeEnemyDamage : MonoBehaviour {

	public Animator animator;
	public int maxHealth = 100;
	public int currentHealth;

	void Start(){
		currentHealth = maxHealth;
	}

	public void TakeDamage(int damage){
		currentHealth -= damage;
		animator.SetTrigger ("Hurt");
		if (currentHealth <= 0){
			Die();
		}
	}

	void Die(){
		animator.SetBool ("isDead", true);
		GetComponent<Collider2D>().enabled = false; //2D, change Collider2D to Collider for 3D
		this.enabled = false;
	}
}