﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPaddle : MonoBehaviour {

	public Ball theBall;

	public float movementSpeed = 30;

	public float lerpTweak = 2f;

	private Rigidbody2D rigidBody;

	// Use this for initialization
	void Start () {
		rigidBody = GetComponent<Rigidbody2D>();
	}
	
	void FixedUpdate () {
		Vector2 dir;
		if (theBall.transform.position.y > transform.position.y) {
			dir = new Vector2(0, 1).normalized;
		} else if (theBall.transform.position.y < transform.position.y){
			dir = new Vector2(0, -1).normalized;
		} else {
			dir = new Vector2(0, -1).normalized;
		}
		rigidBody.velocity = Vector2.Lerp(rigidBody.velocity,
											  dir * movementSpeed,
											  lerpTweak * Time.deltaTime);
	}
}
