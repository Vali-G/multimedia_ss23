using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlayerController : MonoBehaviour
{
    [Header("References")]
    public GameObject player1;
    public GameObject player1CamHolder;
    public GameObject player2;
    public GameObject player2CamHolder;
    public GameObject controllerSign;
    public GameObject keyboardSign;
    public bool controlsAreChanging;
    public SFXPlaying sfxPlaying;
    public Transform camP1;
    public Transform camP2;

    public bool toggleStatePlayer1 = true;
    private bool toggleStatePlayer2 = false;


    [Header("Detection")]
    public LayerMask whatIsButton;
    public float buttonCheckDistance;
    private bool buttonAhead;
    private RaycastHit buttonHit;
    public KeyCode buttonActivateP1;
    public KeyCode buttonActivateP2;

    void Update()
    {
        checkForButton();
        if(toggleStatePlayer1)
        {
            if (buttonAhead && Input.GetKeyDown(buttonActivateP1))
            {
                ChangePlayer();
            }
        }
        else
        {
            if (buttonAhead && Input.GetKeyDown(buttonActivateP2))
            {
                ChangePlayer();
            }
        }

    }

    private void ChangePlayer()
    {
        if (toggleStatePlayer1)
        {
            player2.transform.position = player1.transform.position;
            player2CamHolder.transform.position = player1CamHolder.transform.position;
        }
        
        else
        {
            player1.transform.position = player2.transform.position;
            player1CamHolder.transform.position = player2CamHolder.transform.position;
        }

        toggleStatePlayer1 = !toggleStatePlayer1;
        toggleStatePlayer2 = !toggleStatePlayer2;

        player1.SetActive(toggleStatePlayer1);
        player1CamHolder.SetActive(toggleStatePlayer1);

        player2.SetActive(toggleStatePlayer2);
        player2CamHolder.SetActive(toggleStatePlayer2);

        sfxPlaying.Play();

        controllerSign.SetActive(!toggleStatePlayer1);
        keyboardSign.SetActive(!toggleStatePlayer2);

        controlsAreChanging = false;
    }

    private void checkForButton()
    {
        if(toggleStatePlayer1)
        {
            buttonAhead = Physics.Raycast(camP1.position, camP1.forward, out buttonHit, buttonCheckDistance, whatIsButton);
        }
        else
        {
            buttonAhead = Physics.Raycast(camP2.position, camP2.forward, out buttonHit, buttonCheckDistance, whatIsButton);
        }

    }
}
