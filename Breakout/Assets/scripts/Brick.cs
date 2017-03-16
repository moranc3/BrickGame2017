using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

	public int health = 1;
	public int points = 1;

	// Use this for initialization
	void Start () {
		
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		
		health -= 1; // the same as saying health = health-1
		Debug.Log (health);

		GetComponent<SpriteRenderer> ().color = new Color (1,1,1, health * .2f);

		if (health == 0) {
			gameObject.SetActive (false);
			FindObjectOfType<ball> ().YouBrokeABrick (points); //worth = points
		}

	}
}
