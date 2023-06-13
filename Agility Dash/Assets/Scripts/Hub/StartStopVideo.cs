using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class StartStopVideo : MonoBehaviour
{


    [Header("Input")]
    public KeyCode interact;

    [Header("References")]
    public bool videoPlaying;
    public VideoPlayer videoPlayer;

    private void Start() {
        videoPlaying = false;
    }


    void Update()
    {
        if (Input.GetKeyDown(interact))
            if(videoPlaying)
            {
                videoPlaying = false;
                toggleVideo();
            }
            else
            {
                videoPlaying = true;
                toggleVideo();
            }
    }

    private void OnMouseDown() 
    {
        if(videoPlaying)
        {
            videoPlaying = false;
            toggleVideo();

        }
        else
        {
            videoPlaying = true;
            toggleVideo();
        }
        
    }

    private void toggleVideo()
    {
        if(videoPlaying)
        {
            videoPlayer.Pause();

        }
        else
        {
            videoPlayer.Play();
        }
    }
}
