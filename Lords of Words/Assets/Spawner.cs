using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public Canvas canvas;
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
		int delta = Random.Range (-200, 200);

		// Spawn Group at current Position
		//Instantiate(groups[i], new Vector3(transform.position.x + delta, transform.position.y, transform.position.z), Quaternion.identity);
		Object wContainer= Instantiate(wordContainer, new Vector3(canvas.transform.position.x + delta, canvas.transform.position.y, canvas.transform.position.z), Quaternion.identity, canvas.transform);


	}
}
