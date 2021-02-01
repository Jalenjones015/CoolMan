using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    public string Sn;

    public void Start()
    {
        SceneManager.LoadScene(Sn);
    }

    public void close()
    {
        Application.Quit();
        Debug.Log("quit");
    }

    public void back()

    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        Debug.Log("back");
    }
}
