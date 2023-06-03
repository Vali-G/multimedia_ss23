using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private GameObject settings;

    private void Start() {
        settings = GameObject.Find("SettingsMenu");
        //settings.SetActive(false);
    }

    public void PlayGame() 
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
