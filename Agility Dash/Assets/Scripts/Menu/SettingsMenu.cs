using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{

    public AudioMixer audioMixer;
    public PlayerCam player1Cam;
    public PlayerCam player2Cam;

    public void SetVolume (float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }

    public void SetPlayer1 (float sensitivity)
    {
        player1Cam.sensX = sensitivity;
        player1Cam.sensY = sensitivity;

    }

    public void SetPlayer2 (float sensitivity)
    {
        player2Cam.sensX = sensitivity;
        player2Cam.sensY = sensitivity;
    }
}
