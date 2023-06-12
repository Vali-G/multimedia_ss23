using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlayerController : MonoBehaviour
{
    [Header("Input")]
    public KeyCode interact;

    [Header("References")]
    public GameObject player1;
    public GameObject player1Cam;
    public Transform player1Orientation;
    public GameObject player2;
    public GameObject player2Cam;
    public Transform player2Orientation;
    public GameObject controllerSign;
    public GameObject keyboardSign;
    public bool controlsAreChanging;

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
            player2Cam.transform.position = player1Cam.transform.position;
        }
        
        else
        {
            player1.transform.position = player2.transform.position;
            player1Cam.transform.position = player2Cam.transform.position;
        }

        toogleStatePlayer1 = !toogleStatePlayer1;
        toggleStatePlayer2 = !toggleStatePlayer2;

        player1.SetActive(toogleStatePlayer1);
        player1Cam.SetActive(toogleStatePlayer1);

        player2.SetActive(toggleStatePlayer2);
        player2Cam.SetActive(toggleStatePlayer2);

        controllerSign.SetActive(toogleStatePlayer1);
        keyboardSign.SetActive(toggleStatePlayer2);

        controlsAreChanging = false;
    }
}
