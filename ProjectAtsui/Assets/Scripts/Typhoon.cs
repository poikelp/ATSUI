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

	}

	void FixedUpdate () {
		ResetVelocity();
		GoingNorth();
		EffectByWesterlies();
		PositionUpdate();
		SpinTyphoon();
		GrowTyphoon();
	}

	//台風を巨大化させる関数
	void GrowTyphoon () {
		transform_this.localScale = transform_this.localScale * (1 + speed_grow * Time.deltaTime);
	}

	//台風を回す関数
	void SpinTyphoon () {
		Vector3 torque = new Vector3(0, 0, speed_spin * Time.deltaTime);
		transform_this.Rotate(torque);
	}

	//台風の座標を更新する関数
	void PositionUpdate (){
		transform_this.position = transform_this.position + velocity;
	}

	//台風の速度を初期化する
	void ResetVelocity () {
		velocity = Vector3.zero;
	}

	//台風の北向きの速度を決める
	void GoingNorth () {
		velocity.y += speed_goNoth * Time.deltaTime;
	}

	//偏西風にどれだけ流されるか決める
	void EffectByWesterlies () {
		velocity.x += GetReciprocal(GetDistanceToWesterlies()) * speed_westerlies * Time.deltaTime;
	}

	//台風と偏西風の中心との距離を返す
	float GetDistanceToWesterlies () {
		return Mathf.Abs(transform_westerlies.position.y - transform_this.position.y) + 3;
		// +3 という数字は距離が0になってGetReciprocal（）で無限を返さないようにするためのマジックナンバー
		// できることならなくしたい
	}

	//与えた値の逆数を返す
	float GetReciprocal (float num) {
		return 1 / num;
	}

	//台風がなにかと接触している限り呼ばれ続ける
	void OnTriggerStay2D (Collider2D other) {
		if(other.tag.Equals("High"))
			EffectByHigh();
	}

	//台風が何かから離れた時に呼ばれる
	void OnTriggerExit2D(Collider2D other) {
		if(other.tag.Equals("Ocean"))
			ExitOcean();
	}

	//大陸に上陸した台風は消滅する
	void ExitOcean () {
		Destroy(this.gameObject);
	}

	//高気圧の影響
	//	今のところなし
	void EffectByHigh () {

	}
}
