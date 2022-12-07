using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float speed;
    
    private Player player;
    private Rigidbody2D rb;
    private Vector2? playerPosition = null;

    private void Start()
    {
        player = FindObjectOfType<Player>();
        rb = GetComponentInParent<Rigidbody2D>();
        TrapChest.OnOpenEvent.AddListener(GoToPlayer);
    }

    public void GoToPlayer()
    {
        playerPosition = player.transform.position;
    }

    private void FixedUpdate()
    {
        if (playerPosition != null)
        {
            rb.MovePosition(
                Vector3.Lerp
                (
                rb.position, 
                playerPosition.Value, 
                speed/(playerPosition.Value - rb.position).magnitude
                )
            );
            if (playerPosition == rb.position)
            {
                playerPosition = null;
            }
        }
    }
}
