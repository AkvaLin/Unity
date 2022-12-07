using System;
using System.Collections;
using Redcode.Extensions;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject loadedObject = Resources.Load("Prefabs/Bullet") as GameObject;
            if (loadedObject == null) { print("Error #1!"); return; }

            Transform bulletHole = transform.GetChild(0);
            Bullet bullet = Instantiate(loadedObject, bulletHole.position, transform.rotation).GetComponent<Bullet>();
            bullet.Launch(transform.rotation.eulerAngles);
        }
    }
}
