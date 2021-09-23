using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSounds : MonoBehaviour
{
    [SerializeField] PlayerController playerController;
    Dictionary<string, AudioClip> audioClips;
    AudioSource audioSource;

    void Start(){
        playerController = GetComponent<PlayerController>();
        audioSource = GetComponent<AudioSource>();
        audioClips = new Dictionary<string, AudioClip>();
        initAudioClips();
    }

    private void initAudioClips(){
        audioClips.Add("Jump",Resources.Load<AudioClip>("Sounds/Player/Jump.wav"));

    }

    public void PlayJump()
    {

        audioSource.clip = audioClips["Jump"];
        audioSource.Play();

    }
}
