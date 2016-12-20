using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DetectKey : MonoBehaviour {

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






