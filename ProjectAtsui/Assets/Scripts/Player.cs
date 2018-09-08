using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	GameObject typhoon;

	// Use this for initialization
	void Start () {
		typhoon = (GameObject)Resources.Load("Prefab/typhoon");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void MakeTyphoon (){
		Vector2 mousePos = Input.mousePosition;
		Vector3 spownPos = new Vector3(mousePos.x, mousePos.y, 0);

		Instantiate(typhoon, spownPos, Quaternion.identity);
	}
}
