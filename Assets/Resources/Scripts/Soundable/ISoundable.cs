using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISoundable
{
    AudioSource source { get; set; }
    void Play();
    void Stop();
}
