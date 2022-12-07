using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gramophone : MonoBehaviour, ISoundable
{
    public AudioSource source { get; set; }
    [SerializeField] private List<AudioClip> songs;
    private int currentSong = 0;

    private bool isPlaying = false;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponentInParent<AudioSource>();
        if (songs.Count > 0)
        {
            source.clip = songs[0];
        }
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (isPlaying)
            {
                Stop();
            }
            else
            {
                Play();
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            Stop();
            if (currentSong == songs.Count - 1)
            {
                currentSong = 0;
                source.clip = songs[0];
            }
            else
            {
                currentSong++;
                source.clip = songs[currentSong];
            }
            Play();
        }
    }

    public void Play()
    {
        source.Play();
        isPlaying = true;
    }

    public void Stop()
    {
        source.Pause();
        isPlaying = false;
    }
}
