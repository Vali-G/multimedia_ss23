using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXPlaying : MonoBehaviour
{
    public AudioSource audio;

    public void Play()
    {
        audio.Play();
    }
}
