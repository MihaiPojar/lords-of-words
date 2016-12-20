using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WordContainerController : MonoBehaviour {

	public Letter letterPrefab;
	public Sprite[] sprites;
	public GameUIController gameUI;

	static string[] words = { "andra", "cristina", "daniel", "diana", "mihai" };
	private Rigidbody2D rb2d;

	private Letter[] letters = new Letter[10];
	private int nextLetter;
	private string chosenWord;
	private bool active;

	public void SetGameUI(GameUIController gameUI) {
		this.gameUI = gameUI;
	}

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
		rb2d.velocity = new Vector2 (0, -1.5f);
		nextLetter = 0;
		WriteWord ();
		active = true;
	}

	void WriteWord() {
		int wordIndex = Random.Range(0, words.Length);
		chosenWord = words [wordIndex];
		for (int i = 0; i < chosenWord.Length; i++) {
			Letter l = Instantiate (letterPrefab, new Vector3 (transform.position.x + i, transform.position.y), Quaternion.identity, transform) as Letter;
			l.SetArtworkSprite (sprites [chosenWord[i] - 'a']);
			letters [i] = l;
		}
	}

	void KillWord() {
		gameObject.SetActive (false);
		Destroy (gameObject);
	}

	private IEnumerator DeathTimer()
	{
		while(true)
		{
			yield return new WaitForSeconds(1f); // wait for two seconds
			rb2d.Sleep();
			active = false;
			gameUI.DecreaseLives ();
		}
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.CompareTag ("Ground")) {
			Debug.Log ("Am ajuns jos");
			rb2d.AddTorque (Random.Range(-20f, 0f));
			StartCoroutine ("DeathTimer");
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.A)) {
			keyPressed ("a");
		}
		if (Input.GetKeyDown (KeyCode.B)) {
			keyPressed ("b");
		}
		if (Input.GetKeyDown (KeyCode.C)) {
			keyPressed ("c");
		}
		if (Input.GetKeyDown (KeyCode.D)) {
			keyPressed ("d");
		}
		if (Input.GetKeyDown (KeyCode.E)) {
			keyPressed ("e");
		}
		if (Input.GetKeyDown (KeyCode.F)) {
			keyPressed ("f");
		}
		if (Input.GetKeyDown (KeyCode.G)) {
			keyPressed ("g");
		}
		if (Input.GetKeyDown (KeyCode.H)) {
			keyPressed ("h");
		}
		if (Input.GetKeyDown (KeyCode.I)) {
			keyPressed ("i");
		}
		if (Input.GetKeyDown (KeyCode.J)) {
			keyPressed ("j");
		}
		if (Input.GetKeyDown (KeyCode.K)) {
			keyPressed ("k");
		}
		if (Input.GetKeyDown (KeyCode.L)) {
			keyPressed ("l");
		}
		if (Input.GetKeyDown (KeyCode.M)) {
			keyPressed ("m");
		}
		if (Input.GetKeyDown (KeyCode.N)) {
			keyPressed ("n");
		}
		if (Input.GetKeyDown (KeyCode.O)) {
			keyPressed ("o");
		}
		if (Input.GetKeyDown (KeyCode.P)) {
			keyPressed ("p");
		}
		if (Input.GetKeyDown (KeyCode.Q)) {
			keyPressed ("q");
		}
		if (Input.GetKeyDown (KeyCode.R)) {
			keyPressed ("r");
		}
		if (Input.GetKeyDown (KeyCode.S)) {
			keyPressed ("s");
		}
		if (Input.GetKeyDown (KeyCode.T)) {
			keyPressed ("t");
		}
		if (Input.GetKeyDown (KeyCode.U)) {
			keyPressed ("u");
		}
		if (Input.GetKeyDown (KeyCode.V)) {
			keyPressed ("v");
		}
		if (Input.GetKeyDown (KeyCode.W)) {
			keyPressed ("w");
		}
		if (Input.GetKeyDown (KeyCode.X)) {
			keyPressed ("x");
		}
		if (Input.GetKeyDown (KeyCode.Y)) {
			keyPressed ("y");
		}
		if (Input.GetKeyDown (KeyCode.Z)) {
			keyPressed ("z");
		}
	}

	public void keyPressed(string k){
		WriteLetter (k [0]);
	}

	void GoodLetter() {
		letters [nextLetter].Darken ();
		nextLetter++;
		if (nextLetter == chosenWord.Length) {
			//finish word
			foreach (var letter in letters) {
				if (letter != null) {
					//Destroy (letter);
				}
			}
			Debug.Log ("Destroy " + chosenWord);
			gameObject.SetActive (false);
			Destroy (gameObject);
			gameUI.IncreaseScore (100);
		}
	}

	void BadLetter() {
		for (int counter = 0; counter < nextLetter; counter++) {
			letters [counter].Brighten ();
		}
		nextLetter = 0;
	}

	void WriteLetter(char ch) {
		if (!active) {
			return;
		}
		Debug.Log (ch);
		if (chosenWord [nextLetter] == ch) {
			GoodLetter ();
		}
		else {
			BadLetter ();
		}
	}

	public void SetActive() {
		active = true;
	}

	public void SetInactive() {
		active = false;
	}
}
