﻿using UnityEngine;
using System.Collections;

public class CurrentPlayerController : MonoBehaviour {
	public GameObject cueBall;
	public int multiplier;

	void Update () {
		if (Input.GetButton("Fire1") && cueBall.rigidbody.IsSleeping()) {
			Strike();
		}
	}

	void Strike() {
		float x = Input.GetAxis("Horizontal");
		float z = Input.GetAxis("Vertical");
	
		Debug.Log("x=" + x + " z="+z);

		Vector3 force = new Vector3(x, 0.0f, z) * multiplier;
		cueBall.rigidbody.AddForce(force, ForceMode.Acceleration);
	}
}
