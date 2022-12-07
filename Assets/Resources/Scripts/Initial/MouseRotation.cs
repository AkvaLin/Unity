using System;
using System.Collections;
using Redcode.Extensions;
using System.Collections.Generic;
using UnityEngine;

public class MouseRotation : MonoBehaviour
{

    [SerializeField] private float sensivityX = 10;
    [SerializeField] private float sensivityY = 10;

    private void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 perpendicular = transform.position - mousePos;
        transform.rotation = Quaternion.LookRotation(Vector3.back, perpendicular);
    }
}
