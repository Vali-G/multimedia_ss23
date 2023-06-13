using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;


public class WinningScreen : MonoBehaviour
{

    public GameObject winningScreenUI;
    public bool GameIsPaused = false;
    public GameControllerJR gameController;
    public GameObject winFirstButton;

    // Start is called before the first frame update
    void Start()
    {
        winningScreenUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(gameController.gameOver && !GameIsPaused)
        {
            activate();
        }
    }

    void activate()
    {
        winningScreenUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(winFirstButton);
    }

    public void BackToHub()
    {
        SceneManager.LoadScene("Hub");
        Time.timeScale = 1f;
        GameIsPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void Restart()
    {
        SceneManager.LoadScene("JumpAndRun");
        Time.timeScale = 1f;
        GameIsPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
