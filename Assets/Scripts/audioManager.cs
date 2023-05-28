using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioManager : MonoBehaviour
{

    public static audioManager aud;
    public AudioClip[] clips;
    AudioSource AS;

    private void Awake()
    {
        aud = this;
        AS = GetComponent<AudioSource>();
    }

    public void Play(int clipIDX)
    {
        AS.PlayOneShot(clips[clipIDX]);
        AS.volume = 0.20f;
    }

    public void StopSong()
    {
        AS.Stop();
    }

}
