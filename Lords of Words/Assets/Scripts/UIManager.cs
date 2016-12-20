using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class UIManager : MonoBehaviour {

	public Button button;
	public Button RetryButton;
	public Button ExitButton;
	
	public InputField Field;
    public Text TextBox;

	private int score;	

	void Start () {
		getScore ();
		TextBox.text = score.ToString();	
	}
	
	public void SubmitName(string arg0){
		Debug.Log(arg0);
    }
	
     public void CopyText() {
         TextBox.text = Field.text + "             " + score;
     }

	public void getScore(){
		GameObject myObject = GameObject.FindWithTag ("GameUI");
		GameUIController controller = myObject.GetComponent<GameUIController>();
		score = controller.GetCurrentScore() ;
		myObject.SetActive (false);
		Destroy (myObject);
	}
	
	 public void LoadOn()
    {
        Application.LoadLevel(1);
    }
	public void ExitOn()
    {
        Application.Quit();
    }
	
}