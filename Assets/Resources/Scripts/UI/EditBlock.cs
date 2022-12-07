using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class EditBlock : MonoBehaviour
{
    [SerializeField] private GameObject container;
    private ArrowController controller;
    private GameObject canvas;

    private void Start()
    {
        controller = GameObject.Find("ConnectBlocksButton").GetComponentInChildren<ArrowController>();
    }

    public void clickHandler(BaseEventData data)
    {
        canvas = GameObject.Find("BlockSchemeView");
        
        if (canvas == null) { return; }
        
        PointerEventData pointerData = (PointerEventData) data;

        if (pointerData.button == PointerEventData.InputButton.Right)
        {
            GameObject loadedObject = Resources.Load("Prefabs/EditField") as GameObject;
            if (loadedObject == null) { return; }

            GameObject field = Instantiate(loadedObject);
            field.GetComponent<EditFieldAction>().SetGameObject(container);
            field.transform.SetParent(canvas.transform, false);
        }

        if (controller.IsEditing() && pointerData.button == PointerEventData.InputButton.Left)
        {
            controller.AddBlock(container.GetComponent<RectTransform>());
        }
    }
}
