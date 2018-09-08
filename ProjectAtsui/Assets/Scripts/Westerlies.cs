using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Westerlies : MonoBehaviour {

	Vector3 newPos;
	Transform transform_this;

	// Use this for initialization
	void Start () {
		newPos = new Vector3(0.0f, 7.0f, 0.0f);
		transform_this = transform;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate () {
		MoveWesterlies();
	}

	void MoveWesterlies () {
		newPos.y = 7.0f + GetSinTime() * 5;
		transform_this.position = newPos;
	}

	float GetSinTime () {
		return Mathf.Sin(Time.time);
	}
}
