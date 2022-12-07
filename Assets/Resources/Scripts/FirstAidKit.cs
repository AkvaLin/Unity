using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstAidKit : GroundItem
{
    [SerializeField] private float heal = 50f;

    public override void PickUp(GameObject whoCollide)
    {
        if (whoCollide.GetComponent<Damagable>() != null)
        {
            whoCollide.GetComponent<Damagable>().Heal(heal);
        }
    }
}
