using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlayerController : MonoBehaviour
{
    [Header("Input")]
    public KeyCode interact;

    [Header("References")]
    public GameObject player1;
    public GameObject player1CamHolder;
    public Transform player1Orientation;
    public GameObject player2;
    public GameObject player2CamHolder;
    public Transform player2Orientation;
    public GameObject controllerSign;
    public GameObject keyboardSign;
    public bool controlsAreChanging;
    public SFXPlaying sfxPlaying;

    private bool toogleStatePlayer1 = true;
    private bool toggleStatePlayer2 = false;

    void Update()
    {
        if (Input.GetKeyDown(interact))
            controlsAreChanging = true;

        if (controlsAreChanging)
            ChangePlayer();
    }

    private void OnMouseDown() 
    {
        controlsAreChanging = true;
    }

    private void ChangePlayer()
    {
        if (toogleStatePlayer1)
        {
            player2.transform.position = player1.transform.position;
            player2CamHolder.transform.position = player1CamHolder.transform.position;
        }
        
        else
        {
            player1.transform.position = player2.transform.position;
            player1CamHolder.transform.position = player2CamHolder.transform.position;
        }

        toogleStatePlayer1 = !toogleStatePlayer1;
        toggleStatePlayer2 = !toggleStatePlayer2;

        player1.SetActive(toogleStatePlayer1);
        player1CamHolder.SetActive(toogleStatePlayer1);

        player2.SetActive(toggleStatePlayer2);
        player2CamHolder.SetActive(toggleStatePlayer2);

        sfxPlaying.Play();

        controllerSign.SetActive(!toogleStatePlayer1);
        keyboardSign.SetActive(!toggleStatePlayer2);

        controlsAreChanging = false;
    }
}
