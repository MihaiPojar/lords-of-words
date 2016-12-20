using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainController : MonoBehaviour {

	public Text scoreText;

	public int score;

	// Use this for initialization
	public void Start () {
		score = 0;
		showScore ();
	}
	
	// Update is called once per frame
	public void Update () {
		if (Input.GetKeyDown ("space")) {
			score++;
			showScore ();
		}
	}
		
	public void showScore() {
		scoreText.text = "Your score: " + score;
	}
}
