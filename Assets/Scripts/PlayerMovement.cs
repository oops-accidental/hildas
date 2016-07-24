﻿using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float ROTATION_MULTIPLIER = 40f;
	public float SPEED = 30f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton("Horizontal")) {
			var rotationDelta = Input.GetAxisRaw("Horizontal") * -ROTATION_MULTIPLIER * Time.deltaTime;
			transform.Rotate(0f, 0f, transform.rotation.z + rotationDelta);
		}

		if (Input.GetButton ("Vertical") && Input.GetAxis("Vertical") > 0) {
			var angle = transform.rotation.z;
			transform.Translate(0, SPEED * Time.deltaTime, 0);
		}
	}
}
