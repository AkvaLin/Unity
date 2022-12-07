using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BlockCreator : MonoBehaviour
{
    [SerializeField] private GameObject canvas;
    [SerializeField] private InputField field;

    public void AddBlock()
    {
        if (field.text.Length == 0) { return; }
        
        GameObject loadedObject = Resources.Load("Prefabs/Container") as GameObject;
        if (loadedObject == null) { return; }

        loadedObject.GetComponentInChildren<Image>().GetComponentInChildren<TextMeshProUGUI>().SetText(field.text);

        GameObject block = Instantiate(loadedObject);
        block.transform.SetParent(canvas.transform, false);
    }
}
