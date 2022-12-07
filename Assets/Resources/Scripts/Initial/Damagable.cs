using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damagable : MonoBehaviour
{
    [SerializeField] private float healthPoints = 100f;
    [SerializeField] private float maxHealt = 150f;

    public float HealthPoints
    {
        get
        {
            return healthPoints;
        }
        set
        {
            if (value > maxHealt) { value = maxHealt; }
            if (value < 0) { value = 0; }
            healthPoints = value;
        }
    }

    public void Heal(float heal)
    {
        HealthPoints += heal;
    }

    public void Damage(float damage)
    {
        HealthPoints -= damage;
    }
}
