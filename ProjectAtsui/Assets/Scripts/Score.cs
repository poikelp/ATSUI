using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour {

	float score_float;
	int score_int;
	string score_string;
	TextMeshProUGUI textMesh;

	// Use this for initialization
	void Start () {
		score_float = 0;
		textMesh = gameObject.GetComponent<TextMeshProUGUI>();
		SetScoreInt();
		SetScoreString();
		SetText();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void SetScoreInt(){
		score_int = (int)score_float;
	}
	void SetScoreString(){
		score_string = score_int + "おくえん";
	}
	void SetText(){
		textMesh.SetText(score_string);
	}

	public void AddScore(float score){
		score_float += score;
		SetScoreInt();
		SetScoreString();
		SetText();
	}


}
