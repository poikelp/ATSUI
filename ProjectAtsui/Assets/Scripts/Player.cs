using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	GameObject typhoon;
	Camera gameCamera;

	// Use this for initialization
	void Start () {
		typhoon = (GameObject)Resources.Load("Prefab/typhoon");
		gameCamera = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void MakeTyphoon (){
		Vector3 mousePos = Input.mousePosition;
		mousePos.z = 10.0f;
		Vector3 spownPos = gameCamera.ScreenToWorldPoint(mousePos);

		Instantiate(typhoon, spownPos, Quaternion.identity);
	}
}
