﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleePlayerAttack : MonoBehaviour {

	public Animator animator;
	public Transform attackPoint;
	public float attackRange = 0.5f;
	public float attackRate = 2f;
	private float nextAttackTime = 0f;
	public int attackDamage = 40;
	public LayerMask enemyLayers;

	void Update(){
		if (Time.time >= nextAttackTime){
			if (Input.GetKeyDown(KeyCode.Space)){
				Attack();
				nextAttackTime = Time.time + 1f / attackRate;
			}
		}
	}

	void Attack(){
		animator.SetTrigger ("Attack");
		Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers); //2D
		//Collider[] hitEnemy = Physics.OverlapSphere(AttackPoint.position, attackRange, enemyLayers); //3D version

		foreach(Collider2D enemy in hitEnemies){ //2D, change Collider2D to Collider for 3D
			Debug.Log("We hit " + enemy.name);
			enemy.GetComponent<MeleeEnemyDamage>().TakeDamage(attackDamage);
		}
	}

	//to help see the attack sphere in editor:
	void OnDrawGizmosSelected(){
		if (attackPoint == null) return;
		Gizmos.DrawWireSphere(attackPoint.position, attackRange);
	}
}