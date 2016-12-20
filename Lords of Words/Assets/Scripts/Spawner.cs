using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
	
	public GameObject wordContainer;

	// Groups
	public GameObject[] groups;

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
		Instantiate(wordContainer, new Vector3(transform.position.x + delta, transform.position.y), Quaternion.identity);

	}
}
