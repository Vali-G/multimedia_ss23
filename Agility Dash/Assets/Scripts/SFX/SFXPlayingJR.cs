using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXPlayingJR : MonoBehaviour
{
    public AudioSource beginGameSound;
    public AudioSource wonGameSound;
    public AudioSource respawnSound;

    public void PlayBeginGameSound()
    {
        beginGameSound.Play();
    }

    public void PlayWonGameSound()
    {
        wonGameSound.Play();
    }

    public void PlayRespawnSound()
    {
        respawnSound.Play();
    }
}
