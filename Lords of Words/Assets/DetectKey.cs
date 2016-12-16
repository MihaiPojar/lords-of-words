using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DetectKey : MonoBehaviour {

	private KeyCode[] desiredKeys = {KeyCode.A, KeyCode.B, KeyCode.C, KeyCode.D, KeyCode.E, KeyCode.F, KeyCode.G, KeyCode.H, KeyCode.I, KeyCode.J, KeyCode.K, KeyCode.L, KeyCode.M, KeyCode.N, KeyCode.O, KeyCode.P, KeyCode.Q, KeyCode.R, KeyCode.S, KeyCode.T, KeyCode.U, KeyCode.V, KeyCode.W, KeyCode.X, KeyCode.Y, KeyCode.Z};
	public string k;
	// Use this for initialization
	void Start (){
	}

	// Update is called once per frame
	void Update (){
		k = Input.inputString;
			Debug.Log (k);
			if (detectLetter (k)) {
				keyPressed (k);
			}

		if (Input.GetKeyDown (KeyCode.A)) {
			keyPressed ("a");
		}
		/*lse*/
	}


	public bool detectLetter (string k){
		/*foreach (KeyCode i in desiredKeys) {
			if (Input.GetKeyDown (i))
				return true;
			}
		return false;*/
		return false;
	}


	public void keyPressed(string k){

	}
}






