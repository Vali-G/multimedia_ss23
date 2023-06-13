using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{

    public AudioMixer audioMixer;
    public PlayerCam player1Cam;
    public PlayerCam player2Cam;
    public GameObject settings;

    private void Start() {
        audioMixer.GetFloat("volume", out float volume);
        Debug.Log(volume);
        settings.GetComponent<Slider>().value = volume; 
    }

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
