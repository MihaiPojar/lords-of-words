using UnityEngine;
using System.Collections;

public class ScoreController : MonoBehaviour
{

	public string addScoreURL = "http://localhost:8080/highscores_post";
	public string gethighscoreURL = "http://localhost:8080/highscores_get";

	// Use this for initialization
	void Start ()
	{
		StartCoroutine(GetScores());
	}


	IEnumerator PostScores(string name, int score)
	{

		string post_url = addScoreURL + "name=" + WWW.EscapeURL(name) + "&score=" + score;

		WWW highscore_post = new WWW(post_url);
		yield return highscore_post;

		if (highscore_post.error != null)
		{
			print("There was an error updating the high score: " + highscore_post.error);
		}
	}


	IEnumerator GetScores()
	{
		gameObject.GetComponent<GUIText>().text = "Loading Scores";
		WWW highscore_get = new WWW(gethighscoreURL);
		yield return highscore_get;

		if (highscore_get.error != null)
		{
			print("There was an error getting the high score: " + highscore_get.error);
		}
		else
		{
			gameObject.GetComponent<GUIText>().text = highscore_get.text;
		}
	}


}

