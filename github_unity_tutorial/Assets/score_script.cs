using UnityEngine;
using System.Collections;

public class score_script : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	float score = 0;
	// Update is called once per frame
	void Update () {
		this.guiText.text = "Score = " + score;
	}
	void increaseScore()
	{
		score ++;
	}
}
