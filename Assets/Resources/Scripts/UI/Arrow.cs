using System.Collections;
using System.Collections.Generic;
using Redcode.Extensions;
using Unity.Mathematics;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    private GameObject arrowImage;
    private List<RectTransform> objects = new List<RectTransform>();

    public void Setup(GameObject arrow, List<RectTransform> objects)
    {
        this.arrowImage = arrow;
        this.objects = objects;
    }

    // Update is called once per frame
    void Update()
    {
        if (objects.Count != 2) { return; }
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
        var scale = math.sqrt(x2 * x2 + y2 * y2) - width / 2;
        if (scale < 20)
        {
            scale = 20;
        }
        arrowImage.GetComponent<RectTransform>().SetLocalScaleX(scale);
    }
}
