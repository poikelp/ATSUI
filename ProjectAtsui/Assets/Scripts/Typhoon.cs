using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Typhoon : MonoBehaviour {

	[SerializeField]
	float growSpeed;
	[SerializeField]
	float spinSpeed;

	Transform transform_this;

	// Use this for initialization
	void Start () {
		transform_this = transform;
	}
	
	// Update is called once per frame
	void Update () {
		SpinTyphoon();
		GrowTyphoon();
	}

	void GrowTyphoon () {
		transform_this.localScale = transform_this.localScale * (1 + growSpeed * Time.deltaTime);
	}

	void SpinTyphoon () {
		Vector3 torque = new Vector3(0, 0, spinSpeed * Time.deltaTime);
		transform_this.Rotate(torque);
	}
}
