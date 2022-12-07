using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour, ISoundable
{
    public AudioSource source { get; set; }

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponentInParent<AudioSource>();
        rb = GetComponentInParent<Rigidbody2D>();
        Play();
        Move();
    }

    // Update is called once per frame
    private void Update()
    {
        if (GetComponentInParent<Transform>().position.x >= 400)
        {
            Destroy(transform.gameObject);
        }
    }

    private void Move()
    {
        rb.AddForce(new Vector2(2000, 0));
    }

    public void Play()
    {
        source.Play();
    }

    public void Stop() { }
}
