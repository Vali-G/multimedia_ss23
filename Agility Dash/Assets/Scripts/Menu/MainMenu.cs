using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public GameObject mainMenuUI;
    public GameObject settingsMenuUI;

    public void PlayGame() 
    {
        SceneManager.LoadScene("Hub");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void openSettings()
    {
        mainMenuUI.SetActive(false);
        settingsMenuUI.SetActive(true);
    }

    public void closeSettings()
    {
        mainMenuUI.SetActive(true);
        settingsMenuUI.SetActive(false);
    }
}
