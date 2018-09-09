using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DayCounter : MonoBehaviour {

	float passedDay_float;
	int passedDay_int;
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
		passedDay_float += Time.deltaTime;
		passedDay_int = (int)(passedDay_float * 7);

		if(passedDay_int > 365){
			DayReset();
		}

		viewedDay_string = GetMonthAndDayByPassedDays(passedDay_int);
	}

	void DayReset(){
		passedDay_float = 0;
		passedDay_int = 0;

	}

	void SetText(string text){
		textMesh.SetText(text);
	}

	string GetMonthAndDayByPassedDays(int passed){
		int tsuki = 0;
		int day = 0;
		if(passedDay_int <= 31){
			tsuki = 1;
			day = passed;
		}else if(passedDay_int <= 59){
			tsuki = 2;
			day = passed - 31;
		}else if(passedDay_int <= 90){
			tsuki = 3;
			day = passed - 59;
		}else if(passedDay_int <= 120){
			tsuki = 4;
			day = passed - 90;
		}else if(passedDay_int <= 151){
			tsuki = 5;
			day = passed - 120;
		}else if(passedDay_int <= 181){
			tsuki = 6;
			day = passed - 151;
		}else if(passedDay_int <= 212){
			tsuki = 7;
			day = passed - 181;
		}else if(passedDay_int <= 243){
			tsuki = 8;
			day = passed - 212;
		}else if(passedDay_int <= 273){
			tsuki = 9;
			day = passed - 243;
		}else if(passedDay_int <= 304){
			tsuki = 10;
			day = passed - 273;
		}else if(passedDay_int <= 334){
			tsuki = 11;
			day = passed - 304;
		}else{
			tsuki = 12;
			day = passed - 334;
		}
		return tsuki + "がつ\n" + day + "にち";
	}
}
