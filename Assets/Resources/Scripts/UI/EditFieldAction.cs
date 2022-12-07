using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EditFieldAction : MonoBehaviour
{
    private GameObject container;
    [SerializeField] private InputField editField;
    [SerializeField] private GameObject gameObject;

    public void SetGameObject(GameObject container)
    {
        this.container = container;
    }

    public void EditText()
    {
        if (editField.text.Length > 0)
        {
            container.GetComponentInChildren<Image>().GetComponentInChildren<TextMeshProUGUI>().SetText(editField.text);
        }
        else
        {
            Destroy(container);
        }
        Destroy(gameObject);
    }
}
