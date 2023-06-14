using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXPlaying : MonoBehaviour
{
    public AudioSource audioAll;

    public void Play()
    {
        audioAll.Play();
    }
}
