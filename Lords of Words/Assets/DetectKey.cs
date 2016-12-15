using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DetectKey : MonoBehaviour {

	private KeyCode[] desiredKeys = {KeyCode.A, KeyCode.B, KeyCode.C, KeyCode.D, KeyCode.E, KeyCode.F, KeyCode.G, KeyCode.H, KeyCode.I, KeyCode.J, KeyCode.K, KeyCode.L, KeyCode.M, KeyCode.N, KeyCode.O, KeyCode.P, KeyCode.Q, KeyCode.R, KeyCode.S, KeyCode.T, KeyCode.U, KeyCode.V, KeyCode.W, KeyCode.X, KeyCode.Y, KeyCode.Z};
	public KeyCode k;
	// Use this for initialization
	void Start (){
	}

	// Update is called once per frame
	void Update (){
		k = Input.anyKey;
		if (detectLetter (KeyCode k)){
			keyPressed (KeyCode k);
		}
	}


	public bool detectLetter (){
		foreach (KeyCode i in desiredKeys) {
			if (Input.GetKeyDown (i))
				return true;
			}
		return false;
		
	}


	public void keyPressed(KeyCode k){

	}
}






