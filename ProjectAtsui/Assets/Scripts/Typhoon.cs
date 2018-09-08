using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Typhoon : MonoBehaviour {

	[SerializeField]
	float growSpeed;
	[SerializeField]
	float spinSpeed;
	[SerializeField]
	float goNothSpeed;

	Transform transform_this;
	Vector3 velocity;

	// Use this for initialization
	void Start () {
		transform_this = transform;
	}
	
	// Update is called once per frame
	void Update () {
		SpinTyphoon();
		GrowTyphoon();
	}

	void FixedUpdate () {
		ResetVelocity();
		GoingNorth();
		PositionUpdate();
	}

	void GrowTyphoon () {
		transform_this.localScale = transform_this.localScale * (1 + growSpeed * Time.deltaTime);
	}

	void SpinTyphoon () {
		Vector3 torque = new Vector3(0, 0, spinSpeed * Time.deltaTime);
		transform_this.Rotate(torque);
	}

	void PositionUpdate (){
		transform_this.position = transform_this.position + velocity;
	}

	void ResetVelocity () {
		velocity = Vector3.zero;
	}

	void GoingNorth () {
		velocity.y += goNothSpeed * Time.deltaTime;
	}

	void OnTriggerStay2D (Collider2D other) {
		if(other.tag.Equals("High"))
			EffectByHigh();
	}

	void EffectByHigh () {
		
	}
}
