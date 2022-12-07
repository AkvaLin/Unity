using System;
using System.Collections;
using Redcode.Extensions;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed = 4;
    [SerializeField] private KeyCode upButton = KeyCode.W;
    [SerializeField] private KeyCode downButton = KeyCode.S;
    [SerializeField] private KeyCode rightButton = KeyCode.D;
    [SerializeField] private KeyCode leftButton = KeyCode.A;

    private Rigidbody2D rigidBody;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Vector2 newPosition = transform.position;
        if (Input.GetKey(upButton)) { newPosition.y += speed; } else
        if (Input.GetKey(downButton)) { newPosition.y -= speed; }

        if (Input.GetKey(rightButton)) { newPosition.x += speed; } else
        if (Input.GetKey(leftButton)) { newPosition.x -= speed; }
        transform.position = newPosition;
    }
}
