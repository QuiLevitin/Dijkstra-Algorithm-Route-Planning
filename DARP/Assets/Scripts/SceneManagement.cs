using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public void ActiveFront()
    {
        Path.foundLines.Clear();
        SceneManager.LoadScene("FrontScene");
    }

    public void ActiveMain()
    {
        Path.foundLines.Clear();
        SceneManager.LoadScene("MainScene");
    }

    public void ActiveCreateMainWithBG()
    {
        Path.foundLines.Clear();
        SceneManager.LoadScene("MainWithBG");
    }

    public void ActiveLoad()
    {
        Path.foundLines.Clear();
        SceneManager.LoadScene("LoadScene");
    }


    public void ActiveDefault()
    {
        Path.foundLines.Clear();
        SceneManager.LoadScene("default");
    }
    
    public void ExitGame()
    {
        Path.foundLines.Clear();
        Application.Quit();
    }

    public void ResetPrefs()
    {
        Path.foundLines.Clear();
        PlayerPrefs.DeleteAll();
    }

    public void ClearCacheApp()
    {
        Path.foundLines.Clear();
        Caching.ClearCache();
    }
}
