using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TrapChest : MonoBehaviour
{
    public static UnityEvent OnOpenEvent = new UnityEvent();

    public static void SendChestOpened()
    {
        OnOpenEvent.Invoke();
    }
}
