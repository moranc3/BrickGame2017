﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {

	public Vector2 startingVelocity = new Vector2 (15, -20);

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D> ().velocity = startingVelocity;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < -3.5f) {
			GetOut ();
		}
	}

	void GetOut()
	{
		Debug.Log ("You are out");
	}
}
