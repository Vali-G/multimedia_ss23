using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;


public class Teleport : MonoBehaviour
{
    [Header("Reference")]
    public LayerMask whatIsTeleporter;
    public Transform player1;
    public Transform player2;
    public JoinLevel joinScreenCanvas;
    public GameObject levelJoinScreen;
    public GameObject HUD;
    public bool joinLevel;
    public GameObject joinLevelFirstButton;

    [Header("Detection")]
    public float teleporterCheckDistance;
    private RaycastHit teleportHit;
    public float playerHeight;
    public string newScene; 

    public bool isTeleporter;

    void Start()
    {
        joinLevel = false;
        Time.timeScale = 1f;
    }

    void Update()
    {
        CheckForTeleporter();

        if (isTeleporter)
            AskToJoinLevel();

        if (joinLevel && !joinScreenCanvas.gameIsPaused)
            Activate();
    }

    private void CheckForTeleporter()
    {
        isTeleporter = Physics.Raycast(player1.position, Vector3.left, playerHeight * 0.5f + 0.2f, whatIsTeleporter) || Physics.Raycast(player2.position, Vector3.left, playerHeight * 0.5f + 0.2f, whatIsTeleporter);
    }

    private void AskToJoinLevel()
    { 
        HUD.SetActive(false);
        joinLevel = true;
        enabled = false;
    }

    void Activate()
    {
        levelJoinScreen.SetActive(true);
        Time.timeScale = 0f;
        joinScreenCanvas.gameIsPaused = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(joinLevelFirstButton);
    }

    public void Join()
    {
        SceneManager.LoadScene(newScene);
        Time.timeScale = 1f;
        joinScreenCanvas.gameIsPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
