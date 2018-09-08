﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacificHigh : MonoBehaviour {

	Vector3 newPos;
	Transform transform_this;

	// Use this for initialization
	void Start () {
		newPos = new Vector3(11.0f, 0.0f, 0.0f);
		transform_this = transform;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate () {
		MoveHigh();
	}

	void MoveHigh () {
		newPos.x = 11.0f + GetSinTime() * 5;
		transform_this.position = newPos;
	}

	float GetSinTime () {
		return Mathf.Sin(Time.time);
	}
}
