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
		GrowUpCharacter();
		ScaleUpdate();
	}

	void GrowUpCharacter () {
		scale_character.x += growSpeed;
		scale_character.z += growSpeed;
	}

	void ScaleUpdate () {
		transform_character.localScale = scale_character;
	}

}
