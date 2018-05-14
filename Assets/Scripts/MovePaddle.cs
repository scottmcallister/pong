using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePaddle : MonoBehaviour {

	public float movingSpeed = 30;

	void FixedUpdate() {
		float vertPress = Input.GetAxisRaw("Vertical");
		GetComponent<Rigidbody2D>().velocity = new Vector2(0, vertPress) * movingSpeed;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
