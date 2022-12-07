using System;
using System.Collections;
using Redcode.Extensions;
using System.Collections.Generic;
using UnityEngine;

public abstract class GroundItem : MonoBehaviour
{

    [SerializeField] private string itemName;
    [SerializeField] protected Sprite playerSprite;

    public abstract void PickUp(GameObject whoCollide);

    protected void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject whoCollide = collision.collider.gameObject;
        if (whoCollide.name != "Player") { return; }

        PickUp(whoCollide);
        Destroy(gameObject);
    }
}
