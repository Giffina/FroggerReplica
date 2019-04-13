using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneSelector : MonoBehaviour
{
    public void EntryScene()
    {
        SceneManager.LoadScene("Entry");
    }
    public void MainScene()
    {
        SceneManager.LoadScene("Main");
        Frog.lives = 3;
        TotalScore.CurrentScore = 0;
        DisableButtonOnClick();

    }
    public void NextScene()
    {
        SceneManager.LoadScene("NextPage");
    }
    public void ExitScene()
    {
        SceneManager.LoadScene("Exit");
    }
    public void ExitGame()
    {
        // exit the game for real play
        //Application.Quit();
        //does not work in Unity since it would  lose all settings. so:
        UnityEditor.EditorApplication.isPlaying = false;
    }
    public Button button1;
    public void DisableButtonOnClick()
    {
        button1.interactable = true;
    }
}
