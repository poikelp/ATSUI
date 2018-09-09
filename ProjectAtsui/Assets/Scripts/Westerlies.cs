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

	//時間経過に応じて南北に移動する
	void MoveWesterlies () {
		newPos.y = 7.0f + GetSinTime() * 5;
		transform_this.position = newPos;
	}

	//時間に応じたサインを返す
	float GetSinTime () {
		return Mathf.Sin((Time.time + 90) * Mathf.PI / 365  * 2 * 7);
	}
}
