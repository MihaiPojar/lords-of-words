using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Menu : MonoBehaviour {

    public Canvas MainCanvas;
    public Canvas HighScore;

    void Awake()
    {
        HighScore.enabled = false;
    }

    public void HighscoreOn()
    {
        HighScore.enabled = true;
        MainCanvas.enabled = false;
    }

    public void ReturnOn()
    {
        HighScore.enabled = false;
        MainCanvas.enabled = true;
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
