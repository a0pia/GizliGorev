using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepSoundController : MonoBehaviour
{
    public AudioClip[] footstepSounds;
    public AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private int stepCount = 0; // yürüme sayacı

    public void PlayFootstepSound()
    {
        if (footstepSounds.Length > 0)
        {
            stepCount++; // yürüme sayacını artır
            if (stepCount % 35 == 0) // her iki adımda bir ses oynat
            {
                AudioClip footstepSound = footstepSounds[Random.Range(0, footstepSounds.Length)];
                audioSource.PlayOneShot(footstepSound);
            }
        }
    }

}