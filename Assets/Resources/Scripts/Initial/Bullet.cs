using System;
using System.Collections;
using Redcode.Extensions;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    [SerializeField] private float speed = 5;

    private Rigidbody2D rb = null;

    public void Launch(Vector2 direction)
    {
        if (rb == null) { rb = GetComponent<Rigidbody2D>(); }
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 perpendicular = mousePos - transform.position;
        rb.AddForce(perpendicular * speed);
    }
    
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject whoCollide = collision.gameObject;
        if (whoCollide.name == "Block")
        {
            Destroy(gameObject);
        }
    }
}
