using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drag : MonoBehaviour
{
    private Canvas canvas;
    private GameObject view;
    private Arrow arrow;

    private void Start()
    {
        canvas = GameObject.FindGameObjectWithTag("Canvas").GetComponent<Canvas>();
        view = GameObject.Find("BlockSchemeView");
    }

    public void DragHandler(BaseEventData data)
    {
        PointerEventData pointerData = (PointerEventData) data;
        Vector2 position;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            (RectTransform) canvas.transform,
            pointerData.position,
            canvas.worldCamera,
            out position);
        
        transform.position = canvas.transform.TransformPoint(position);
    }
}