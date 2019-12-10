using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void GotoGameScene()
    {
        SceneManager.LoadScene("3Game");
    }

    public void GotoIntroScene()
    {
        SceneManager.LoadScene("1Intro");
    }

    public void GotoScoreScene()
    {
        SceneManager.LoadScene("2HighScores");
    }

    public void GotoExitScene()
    {
        SceneManager.LoadScene("4Exit");
    }

    public void Quitgame()
    {
        Debug.Log("Game quit");
        Application.Quit();
    }
}
