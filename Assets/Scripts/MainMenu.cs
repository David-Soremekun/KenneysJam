using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Main Level");
    }
    public void GoToSettings()
    {
        SceneManager.LoadScene("Settings Menu");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
