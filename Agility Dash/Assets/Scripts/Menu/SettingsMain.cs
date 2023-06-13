using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;



public class SettingsMain : MonoBehaviour
{

    public AudioMixer audioMixer;
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
}
