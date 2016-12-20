using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
	
	public WordContainerController wordContainer;
	public GameUIController gameUI;
	
	//- fara efect -> cod: 0
	//- litere culcate la stanga -> cod: 1
	//- litere culcate la dreapta -> cod: 2
	//- litere cu susul in jos -> cod: 3
	//- litere oglindite -> cod: 4
	//- litere micsorate -> cod: 5
	
	int [] C10 = { 1, 2, 3, 4, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
	int [] C20 = { 1, 2, 3, 4, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
	int [] C30 = { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
	int [] C40 = { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
	int [] C50 = { 1, 2, 3, 4, 5, 0, 0, 0, 0, 0 };
	int [] C60 = { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
	int [] C70 = { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
	int [] C80 = { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
	int [] C90 = { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 0, 0, 0, 0, 0 };
	int [] C99 = { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5 };
	private int wordsSpawned;
	private float spawnSpeed;
	private float spawnDelay;

	// Use this for initialization
	void Start () {
		wordsSpawned = 0;
		spawnDelay = 2f;
		spawnSpeed = 2f;
		spawnNext ();
		StartCoroutine ("TimerEvent");
	}

	private IEnumerator TimerEvent()
	{
		while(true)
		{
			yield return new WaitForSeconds(spawnDelay); // wait for two seconds
			spawnNext();
		}
	}
		
	// Update is called once per frame
	void Update () {
	}

	private void spawnNext() {
		int[] chance;
		if (wordsSpawned < 2) {
			// Runda 1
			chance = C10;
		} else if (wordsSpawned < 4) {
			// Runda 2
			chance = C20;
			spawnDelay = 1.9f;
		} else if (wordsSpawned < 6) {
			// Runda 3
			chance = C30;
			spawnSpeed = 2.2f;
		} else if (wordsSpawned < 8) {
			// Runda 4
			chance = C40;
			spawnDelay = 1.8f;
		} else if (wordsSpawned < 10) {
			// Runda 5
			chance = C50;
			spawnSpeed = 2.5f;
		} else if (wordsSpawned < 12) {
			// Runda 6
			chance = C60;
			spawnDelay = 1.7f;
		} else if (wordsSpawned < 14) {
			// Runda 7
			chance = C70;
			spawnSpeed = 2.8f;
		} else if (wordsSpawned < 17) {
			// Runda 8
			chance = C80;
			spawnDelay = 1.6f;
		} else if (wordsSpawned < 20) {
			// Runda 9
			chance = C90;
			spawnSpeed = 3.2f;
		} else {
			// Runda inf
			chance = C99;
			spawnSpeed += 0.09f;
			spawnDelay = Mathf.Max (spawnDelay - 0.01f, 0.8f);
		}

		int specialEffect = chance [Random.Range (0, chance.Length)];
		float delta = Random.Range(-5.0f, 0);

		// Spawn Container at current Position
		WordContainerController container = Instantiate(wordContainer, new Vector3(transform.position.x + delta, transform.position.y), Quaternion.identity) as WordContainerController;
		container.SetGameUI (gameUI);
		container.SetSpeed (spawnSpeed);
		container.SetEffect (specialEffect);
		container.SetValue (100 + specialEffect * 20);
		wordsSpawned++;
	}

	public void GameOver() {
		// what to do on game over
		StopCoroutine("TimerEvent");
		foreach(GameObject container in GameObject.FindGameObjectsWithTag ("WordContainer")) {
			//container.SetInactive ();
			container.GetComponent<WordContainerController>().SetInactive();
		};
	}
}
