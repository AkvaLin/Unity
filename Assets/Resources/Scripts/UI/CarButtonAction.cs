using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarButtonAction : MonoBehaviour
{
    public void onTap()
    {
        GameObject loadedGameObject = Resources.Load("Prefabs/Car") as GameObject;
        if (loadedGameObject == null) { return; }

        GameObject car = Instantiate(loadedGameObject);
    }
}
