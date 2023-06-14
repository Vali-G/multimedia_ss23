using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.EventSystems;


public class EscMenu : MonoBehaviour
{


    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    public GameObject settingsMenuUI;
    public GameControllerJR gameController;
    public GameObject HUD;
    public TextMeshProUGUI countdownDisplay;
    public TextMeshProUGUI timer;
    public KeyCode pauseKey = KeyCode.Escape;
    public KeyCode altPauseKey;
    public AudioSource music;
    public AudioSource sfx;

    public GameObject pauseFirstButton, optionsFirstButton, optionsClosedButton;


    // Start is called before the first frame update
    void Start()
    {
        pauseMenuUI.SetActive(false);
        settingsMenuUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(pauseKey) || Input.GetKeyDown(altPauseKey)) && !gameController.gameOver)
        {
            if(GameIsPaused)
            {
                Resume();
            } else 
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        settingsMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        HUD.SetActive(true);
        music.Play();
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        HUD.SetActive(false);
        music.Pause();
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(pauseFirstButton);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Hub");
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }

    public void openSettings()
    {
        pauseMenuUI.SetActive(false);
        settingsMenuUI.SetActive(true);
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(optionsFirstButton);
    }

    public void closeSettings()
    {
        pauseMenuUI.SetActive(true);
        settingsMenuUI.SetActive(false);
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(optionsClosedButton);
    }

    
}
