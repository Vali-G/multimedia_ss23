using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JoinLevel : MonoBehaviour
{
    public GameObject joinLevelJRScreenUI;
    public GameObject joinLevelCatchScreenUI;
    public GameObject joinLevelPuzzleScreenUI;
    public Teleport teleporterJR;
    public GameObject HUD;
    public bool gameIsPaused = false;

    Rigidbody rb;

    public void BackToHub()
    {
        Time.timeScale = 1f;
        joinLevelJRScreenUI.SetActive(false);
        joinLevelCatchScreenUI.SetActive(false);
        joinLevelPuzzleScreenUI.SetActive(false);
        HUD.SetActive(true);
        teleporterJR.joinLevel = false;
        gameIsPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Invoke("EnableTeleporter", 2);
    }

    private void EnableTeleporter() 
    {
        teleporterJR.enabled = true;
    }
}
