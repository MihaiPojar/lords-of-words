using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WordContainerController : MonoBehaviour {

	private string[] words = { "Andra", "Cristina", "Daniel", "Diana", "Mihai" };

	public Text word;

	private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
		rb2d.velocity = new Vector2 (0, -15);

		int i = Random.Range (0, words.Length);
		word.text = words [i];

	}
	
	// Update is called once per frame
	void Update () {
	}
}
