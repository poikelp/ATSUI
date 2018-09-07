using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtsuiCharacter : MonoBehaviour {

	[SerializeField]
	private float growSpeed;
	
	private Vector3 scale_character;
	private Transform transform_character;

	// Use this for initialization
	void Start () {
		transform_character = transform;
		scale_character = transform_character.localScale;
	}
	
	// Update is called once per frame
	void Update () {
		GrowUpCharacter());
		ScaleUpdate();
	}

	//キャラクターを決められた値だけ大きくする
	void GrowUpCharacter () {
		scale_character.x += growSpeed;
		scale_character.z += growSpeed;
	}

	//キャラクターの大きさを更新する
	void ScaleUpdate () {
		transform_character.localScale = scale_character;
	}

	//キャラクターを決められた値だけ小さくする
	void GrowDownCharacter () {
		scale_character.x -= growSpeed * 2;
		scale_character.z -= growSpeed * 2;
		
		SizeCheck();
	}

	//キャラクターの大きさがマイナスにならないように修正する
	void SizeCheck () {
		if(scale_character.x < 0)
			scale_character.x = 0;
		if(scale_character.z < 0)
			scale_character.z = 0;
	}
}
