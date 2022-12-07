using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class SleepingGrandpa : MonoBehaviour, ISoundable
{
    public AudioSource source { get; set; }
    
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponentInParent<AudioSource>();
        source.loop = true;
        source.Play();
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            pause();
        }
    }

    public void Play()
    {
        source.Play();
    }

    public void Stop()
    {
        source.Stop();
    }

    async Task pause()
    {
        Stop();
        await Task.Delay(5000);
        Start();
    }
}
