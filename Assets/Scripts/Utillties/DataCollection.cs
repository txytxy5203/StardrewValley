using System;
using UnityEngine;

[Serializable]
public class ItemDetails
{
    public int itemID;
    public string itemName;
    public ItemType itemType;
    public Sprite itemIcon;
    public Sprite itemOnWorldIcon;
    public string itemDescription;
    public int itemUseRadius;
    public bool canPickedUp;
    public bool canDropped;
    public bool canCarried;
    public int itemPrice;
    [Range(0, 1)]
    public float sellPercentage;
}

[Serializable]
public struct InventoryItem
{
    public int itemID;

    public int itemAmount;
}