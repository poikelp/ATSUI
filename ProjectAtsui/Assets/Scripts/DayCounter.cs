using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DayCounter : MonoBehaviour {

	float day_float;
	int day_int;
	int viewedDay_int;
	string viewedDay_string;
	TextMeshProUGUI textMesh;

	// Use this for initialization
	void Start () {
		DayReset();
		textMesh = gameObject.GetComponent<TextMeshProUGUI>();
	}
	
	// Update is called once per frame
	void Update () {
		DayUpdate();
		SetText(viewedDay_string);
	}

	void DayUpdate () {
		day_float += Time.deltaTime;
		day_int = (int)(day_float * 7);

		if(day_int > 365){
			DayReset();
		}

		viewedDay_string = day_int.ToString();

	}

	void DayReset(){
		day_float = 0;
		day_int = 0;

	}

	void SetText(string text){
		textMesh.SetText(text);
	}
}
