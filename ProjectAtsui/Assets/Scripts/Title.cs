﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			SceneChange_Main();
		}
	}
	
	void SceneChange_Main () {
		SceneManager.LoadScene("New Scene");
	}
}
