using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainController : MonoBehaviour {

	public Text scoreText;

	private int score;

	// Use this for initialization
	void Start () {
		score = 0;
		showScore ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")) {
			score++;
			showScore ();
		}
	}
		
	void showScore() {
		scoreText.text = "Your score: " + score;
	}
}
