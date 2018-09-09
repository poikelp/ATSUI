using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Japan : MonoBehaviour {

	[SerializeField]
	float basicScore;
	[SerializeField]
	GameObject scoreBoard;
	Score score_scoreBoard;

	// Use this for initialization
	void Start () {
		score_scoreBoard = scoreBoard.GetComponent<Score>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnTriggerStay2D(Collider2D other)	{
		if(other.tag.Equals("Typhoon")){
			AddScoreToBoard(other.transform);
		}
	}

	void AddScoreToBoard(Transform trans){
		float score_get = trans.localScale.x * Time.deltaTime * basicScore * 7;
		score_scoreBoard.AddScore(score_get);
	}
}
