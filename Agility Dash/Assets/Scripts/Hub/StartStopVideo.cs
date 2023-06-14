using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class StartStopVideo : MonoBehaviour
{


    [Header("Input")]
    public float buttonCheckDistance;
    public KeyCode buttonActivateP1;
    public KeyCode buttonActivateP2;


    [Header("References")]
    public bool videoPlaying;
    public VideoPlayer videoPlayer;
    public Transform camP1;
    public Transform camP2;
    public LayerMask whatIsVideoButton;
    public ChangePlayerController changePlayerScript;

    private bool buttonAhead;
    private RaycastHit buttonHit;



    private void Start() {
        videoPlaying = true;
    }


    void Update()
    {
        checkForButton();
        if(changePlayerScript.toggleStatePlayer1)
        {
            if (buttonAhead && Input.GetKeyDown(buttonActivateP1))
            {
                toggleVideo();
            }
        }
        else
        {
            if (buttonAhead && Input.GetKeyDown(buttonActivateP2))
            {
                toggleVideo();
            }
        }
    }


    private void toggleVideo()
    {
        if(videoPlaying)
        {
            videoPlayer.Pause();
            videoPlaying = false;

        }
        else
        {
            videoPlayer.Play();
            videoPlaying = true;
        }
    }

    private void checkForButton()
    {
        if(changePlayerScript.toggleStatePlayer1)
        {
            buttonAhead = Physics.Raycast(camP1.position, camP1.forward, out buttonHit, buttonCheckDistance, whatIsVideoButton);
        }
        else
        {
            buttonAhead = Physics.Raycast(camP2.position, camP2.forward, out buttonHit, buttonCheckDistance, whatIsVideoButton);
        }
    }
}
