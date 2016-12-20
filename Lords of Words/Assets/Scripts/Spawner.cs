using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
	
	public WordContainerController wordContainer;
	public GameUIController gameUI;

	// Use this for initialization
	void Start () {
		spawnNext ();
		StartCoroutine ("TimerEvent");
	}

	private IEnumerator TimerEvent()
	{
		while(true)
		{
			yield return new WaitForSeconds(2f); // wait for two seconds
			spawnNext();
		}
	}
		
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")) {
			spawnNext ();
		}
	}

	private void spawnNext() {
		float delta = Random.Range(-10.0f, 0);

		// Spawn Container at current Position
		WordContainerController container = Instantiate(wordContainer, new Vector3(transform.position.x + delta, transform.position.y), Quaternion.identity) as WordContainerController;
		container.SetGameUI (gameUI);
	}

	public void GameOver() {
		// what to do on game over
		StopCoroutine("TimerEvent");
		Time.timeScale = 0;
		foreach(GameObject container in GameObject.FindGameObjectsWithTag ("WordContainer")) {
			//container.SetInactive ();
			container.GetComponent<WordContainerController>().SetInactive();
		};
	}
}
