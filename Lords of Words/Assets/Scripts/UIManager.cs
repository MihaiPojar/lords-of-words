using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class UIManager : MonoBehaviour {

	
	// Use this for initialization

	public Button button;
	public Button RetryButton;
	public Button ExitButton;
	
	public InputField Field;
    public Text TextBox;
	
	
	public void SubmitName(string arg0){
		Debug.Log(arg0);
    }
	
     public void CopyText() {
         TextBox.text = Field.text;
		
     }
	
	
	public void getScore(){
		GameObject myObject = GameObject.Find("ThePlayer");
		MainController getScore = myObject.GetComponent<MainController>();
		getScore.showScore() ;
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