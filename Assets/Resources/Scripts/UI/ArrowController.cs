using System;
using System.Collections;
using System.Collections.Generic;
using Redcode.Extensions;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class ArrowController : MonoBehaviour
{
    [SerializeField] private GameObject canvas;
    private List<RectTransform> objects = new List<RectTransform>();
    private bool isEditing = false;

    public void Toggle()
    {
        isEditing = !isEditing;
    }

    public bool IsEditing()
    {
        return isEditing;
    }

    public void AddBlock(RectTransform block)
    {
        objects.Add(block);
    }
    
    public void Update()
    {
        if (!isEditing) { return; }
        if (objects.Count != 2) { return; }
        
        GameObject loadedObject = Resources.Load("Prefabs/ArrowImage") as GameObject;
        if (loadedObject == null) { return; }

        GameObject arrowImage = Instantiate(loadedObject);
        arrowImage.transform.SetParent(canvas.transform, true);
        float x = objects[1].localPosition.x +
                  objects[0].localPosition.x;
        float y = objects[1].localPosition.y +
                  objects[0].localPosition.y;
        var height1 = objects[0].rect.height;
        var height2 = objects[1].rect.height;
        var avgHeight = (height1 + height2) / 2;
        var dir = objects[0].position - objects[1].position;
        arrowImage.GetComponent<RectTransform>().SetLocalPositionXY(x/2, y/2 - avgHeight / 4);
        arrowImage.GetComponent<RectTransform>().SetPositionAndRotation(arrowImage.transform.position, Quaternion.FromToRotation(Vector3.left, dir));
        var x2 = math.abs(objects[0].localPosition.x -
                          objects[1].localPosition.x);
        var y2 = math.abs(objects[0].localPosition.y -
                          objects[1].localPosition.y);
        var width = objects[0].rect.width;
        arrowImage.GetComponent<RectTransform>().SetLocalScaleX(math.sqrt(x2*x2 + y2*y2) - width / 2);
        print(objects.Count);
        arrowImage.GetComponent<Arrow>().Setup(arrowImage, new List<RectTransform>() {objects[0], objects[1]});

        objects.RemoveAt(0);
        objects.RemoveAt(0);
    }
}
