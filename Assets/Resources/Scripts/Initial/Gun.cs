using System;
using System.Collections;
using Redcode.Extensions;
using System.Collections.Generic;
using UnityEngine;

public class Gun : GroundItem
{

    [SerializeField] private int ammoInMagazine = 12;
    [SerializeField] private int ammoAll = 64;
    [SerializeField] private float damage = 10.6f;

    public override void PickUp(GameObject whoCollide)
    {
        whoCollide.AddComponent<Shooting>();
        whoCollide.GetComponent<SpriteRenderer>().sprite = playerSprite;
    }
}
