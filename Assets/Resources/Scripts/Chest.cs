using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

public class Chest : MonoBehaviour
{
    private Player player;
    private Boolean isChestOpened = false;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite[] spriteArr;
    [SerializeField] private List<Item> _items;
    
    void Start()
    {
        player = FindObjectOfType<Player>();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    void OpenChest()
    {
        spriteRenderer.sprite = spriteArr[1];
        TrapChest.SendChestOpened();
    }

    void CloseChest()
    {
        spriteRenderer.sprite = spriteArr[0];
    }

    Item getFirstItem()
    {
        return _items[0];
    }

    Item getLastItem()
    {
        return _items.Last();
    }

    Item getItem(int index)
    {
        return _items[index];
    }

    void dropItem(int index)
    {
        Item item = _items[index];
        _items.Remove(item);
        Instantiate(item, 
            new Vector3(
                transform.position.x, 
                transform.position.y - 1, 
                transform.position.z
                ), 
            Quaternion.identity);
    }

    void addItem(Item item)
    {
        _items.Add(item);
    }

    private void OnMouseOver()
    {
        float distance = Vector3.Distance(transform.position, player.transform.position);

        if (distance <= 2)
        {
            if (isChestOpened)
            {
                if (Input.GetMouseButtonDown(1))
                {
                    if (_items.Count > 0)
                    {
                        dropItem(Random.Range(0, _items.Count));
                    }
                    CloseChest();
                    isChestOpened = false;
                }
            }
            else
            {
                if (Input.GetMouseButtonDown(1))
                {
                    OpenChest();
                    isChestOpened = true;
                }
            }
        }
    }
}
