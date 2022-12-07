using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageController : MonoBehaviour
{
    [SerializeField] public Image imageView;
    [SerializeField] private List<Sprite> images;
    
    private int currentImage = 0;

    public void ImageChange(Boolean direction)
    {
        if (direction)
        {
            if (currentImage - 1 >= 0)
            {
                imageView.sprite = images[currentImage - 1];
                currentImage--;
            }
        }
        else
        {
            if (currentImage < images.Count - 1)
            {
                imageView.sprite = images[currentImage + 1];
                currentImage++;
            }
        }
    }

    private void Start()
    {
        if (images.Count > 0)
        {
            imageView.sprite = images[0];
        }
    }
}
