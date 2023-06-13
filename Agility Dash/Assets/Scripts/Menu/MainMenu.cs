using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;


public class MainMenu : MonoBehaviour
{

    public GameObject mainMenuUI;
    public GameObject settingsMenuUI;

    public GameObject firstButtonSelected, optionsFirstButton, optionsClosedButton;

    private void Start() {
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(firstButtonSelected);
    }

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
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(optionsFirstButton);
    }

    public void closeSettings()
    {
        mainMenuUI.SetActive(true);
        settingsMenuUI.SetActive(false);
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(optionsClosedButton);
    }
}
