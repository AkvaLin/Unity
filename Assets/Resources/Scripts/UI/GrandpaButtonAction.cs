using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrandpaButtonAction : MonoBehaviour
{
    public void onTap()
    {
        GameObject loadedGameObject = Resources.Load("Prefabs/Grandpa") as GameObject;
        if (loadedGameObject == null) { return; }

        GameObject grandpa = Instantiate(loadedGameObject);
    }
}
