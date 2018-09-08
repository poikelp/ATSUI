using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Typhoon : MonoBehaviour {

	[SerializeField]
	float speed_grow;
	[SerializeField]
	float speed_spin;
	[SerializeField]
	float speed_goNoth;
	[SerializeField]
	float speed_westerlies;
	

	GameObject westerlies;
	Transform transform_this;
	Transform transform_westerlies;
	Vector3 velocity;

	// Use this for initialization
	void Start () {
		westerlies = GameObject.FindGameObjectWithTag("Westerlies");
		transform_this = transform;
		transform_westerlies = westerlies.transform;
	}
	
	// Update is called once per frame
	void Update () {
		SpinTyphoon();
		GrowTyphoon();
	}

	void FixedUpdate () {
		ResetVelocity();
		GoingNorth();
		EffectByWesterlies();
		PositionUpdate();
	}

	void GrowTyphoon () {
		transform_this.localScale = transform_this.localScale * (1 + speed_grow * Time.deltaTime);
	}

	void SpinTyphoon () {
		Vector3 torque = new Vector3(0, 0, speed_spin * Time.deltaTime);
		transform_this.Rotate(torque);
	}

	void PositionUpdate (){
		transform_this.position = transform_this.position + velocity;
	}

	void ResetVelocity () {
		velocity = Vector3.zero;
	}

	void GoingNorth () {
		velocity.y += speed_goNoth * Time.deltaTime;
	}

	void EffectByWesterlies () {
		velocity.x += GetReciprocal(GetDistanceToWesterlies()) * speed_westerlies * Time.deltaTime;
	}

	float GetDistanceToWesterlies () {
		return Mathf.Abs(transform_westerlies.position.y - transform_this.position.y) + 3;
	}

	float GetReciprocal (float num) {
		return 1 / num;
	}

	void OnTriggerStay2D (Collider2D other) {
		if(other.tag.Equals("High"))
			EffectByHigh();
	}

	void OnTriggerExit2D(Collider2D other) {
		if(other.tag.Equals("Ocean"))
			ExitOcean();
	}

	void ExitOcean () {
		Destroy(this.gameObject);
	}

	void EffectByHigh () {

	}
}
