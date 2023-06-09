using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.Video;



public class EscMenuHub : MonoBehaviour
{


    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    public GameObject settingsMenuUI;
    public GameObject HUD;
    public KeyCode pauseKey = KeyCode.Escape;
    public KeyCode altPauseKey;
    public AudioSource music;
    public VideoPlayer videoJrPlayer;
    public StartStopVideo videoPlayerScript;

    public GameObject pauseFirstButton, optionsFirstButton, optionsClosedButton;

    public Teleport teleporter;


    // Start is called before the first frame update
    void Start()
    {
        pauseMenuUI.SetActive(false);
        settingsMenuUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(pauseKey) || Input.GetKeyDown(altPauseKey)) && !(teleporter.isTeleporter))
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
        if (videoPlayerScript.videoPlaying) 
        {
            videoJrPlayer.Play();
        }
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
        videoJrPlayer.Pause();
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
