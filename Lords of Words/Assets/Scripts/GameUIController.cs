using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameUIController : MonoBehaviour {

	public Text gameScoreText;
	public Text gameLivesText;

	public Spawner spawner;

	private int gameScoreValue;
	private int gameLivesValue;

	// Use this for initialization
	void Start () {
		SetCurrentScore (0);
		SetLivesLeft (3);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("1")) {
			IncreaseScore (100);
		}

		if (Input.GetKeyDown ("2")) {
			DecreaseLives ();
		}

		if (Input.GetKeyDown ("escape")) {
			GameOver ();
		}
	}

	private void SetCurrentScore(int newScore) {
		gameScoreValue = newScore;
		gameScoreText.text = "Score: " + newScore;
	}

	private void SetLivesLeft(int livesLeft) {
		gameLivesValue = livesLeft;
		gameLivesText.text = "Lives left: " + livesLeft;
	}

	public int GetCurrentScore() {
		return gameScoreValue;
	}

	public int GetCurrentLives() {
		return gameLivesValue;
	}

	public void IncreaseScore(int value) {
		SetCurrentScore (gameScoreValue + value);
	}

	public void DecreaseLives() {
		SetLivesLeft (gameLivesValue - 1);
		if (gameLivesValue == 0) {
			GameOver ();
		}
	}

	void Awake() {
		DontDestroyOnLoad (transform.root.gameObject);
	}

	void GameOver() {
		// what to do on game over
		spawner.GameOver();
		// TODO: load next scene and pass the highscore
		Application.LoadLevel(2);
	}
}
