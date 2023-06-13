using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{


    public Transform spawnPoint;

    [Header("Ground Check")]
    public float playerHeight;
    public LayerMask whatIsLava;
    public bool respawn;

    [Header("Audio")]
    public SFXPlayingJR sfxPlaying;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        respawn = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f + 0.2f, whatIsLava);
        if(respawn)
        {
            transform.position = spawnPoint.position;
            sfxPlaying.PlayRespawnSound();
        }
    }
}
