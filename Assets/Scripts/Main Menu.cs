using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string startSceneName;

    public void StartPressed()
    {
        SceneManager.LoadScene(startSceneName);
    }

    public void CloseGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

    public void Back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        Debug.Log("Back");
    }
}

